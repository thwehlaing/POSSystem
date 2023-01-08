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
        public bool UseTran;
        public DBAccessBL()
        {
            UseTran = false;
        }

        public DataTable SelectDatatable(string StoreprocedureName, string ConnectionString, params SqlParameter[] para)
        {
            if (UseTran)
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.Transaction = sqlTransaction;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = StoreprocedureName;

                    var adapt = new SqlDataAdapter(StoreprocedureName, sqlConnection);
                    adapt.SelectCommand = sqlCommand;

                    if (para != null)
                        para = ChangeToDBNull(para);
                    sqlCommand.Parameters.AddRange(para);

                    DataTable dt = new DataTable();

                    try
                    {
                        adapt.Fill(dt);
                        sqlTransaction.Commit();
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        throw ex;
                    }
                }
            }
            else
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
        }


        private SqlParameter[] ChangeToDBNull(SqlParameter[] para)
        {
            foreach (var p in para)
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

            return para;
        }

        public string InsertUpdateDeleteData(string sSQL, string conStr, params SqlParameter[] para)
        {
            if (UseTran)
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
                        return "true";
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        throw ex;
                    }
                }
            }
            else
            {
                try
                {
                    var newCon = new SqlConnection(conStr);
                    if (para != null)
                        para = ChangeToDBNull(para);
                    SqlCommand cmd = new SqlCommand(sSQL, newCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddRange(para);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return "true";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
