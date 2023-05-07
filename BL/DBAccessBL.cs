using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DBAccessBL
    {
        public DBAccessBL()
        {
          
        }

        public DataTable SelectDatatable(string StoreprocedureName, string ConnectionString, params SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            var newCon = new SqlConnection(ConnectionString);
            using (var adapt = new SqlDataAdapter(StoreprocedureName, newCon))
            {
                newCon.Open();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (para != null)
                {
                    para = ChangeToDBNull(para);
                    adapt.SelectCommand.Parameters.AddRange(para);
                }

                adapt.Fill(dt);
                newCon.Close();
            }
            return dt;
        }


        private SqlParameter[] ChangeToDBNull(SqlParameter[] para)
        {
            foreach (var p in para)
            {
                if (p.SqlDbType != SqlDbType.Structured)
                {
                    if (p.Value == null || string.IsNullOrWhiteSpace(p.Value.ToString()))
                    {
                        p.Value = DBNull.Value;
                        p.SqlValue = DBNull.Value;
                    }
                    else
                    {
                        p.Value = p.Value.ToString().Trim();
                        p.SqlValue = p.Value.ToString().Trim();
                    }
                }
            }

            return para;
        }

        public bool InsertUpdateDeleteData(string sSQL, string conStr, params SqlParameter[] para)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = sSQL;
                if (para != null)
                    para = ChangeToDBNull(para);
                sqlCommand.Parameters.AddRange(para);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
