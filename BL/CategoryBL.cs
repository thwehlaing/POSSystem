using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Reflection;

namespace BL
{
    public class CategoryBL:BaseBL
    {
        public DataTable Category_Select()
        {
            DBAccessBL dl = new DBAccessBL();
            var parameters = new SqlParameter[] {};
            DataTable dt = dl.SelectDatatable("pr_category_select", GetConnectionString(), parameters);           
            return dt;
        }

        public bool Category_Insert(CategoryEntity entity)
        {
            DBAccessBL dl = new DBAccessBL();
            var parameters = new SqlParameter[] {
                new SqlParameter("@CategoryName", SqlDbType.NVarChar){ Value = entity.CategoryName.ToString() },
                new SqlParameter("@Status", SqlDbType.VarChar){ Value = entity.Status.ToString() },
                 new SqlParameter("@Operator", SqlDbType.VarChar){ Value = entity.OperatorCD.ToString() },
            };            
            return dl.InsertUpdateDeleteData("pr_category_insert", GetConnectionString(), parameters);
        }
    }
}
