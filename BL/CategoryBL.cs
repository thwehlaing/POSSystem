using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoryBL:BaseBL
    {
        public DataTable Category_Select()
        {
            DBAccessBL dl = new DBAccessBL();
            var parameters = new SqlParameter[] {};
            //DataTable dt = dl.SelectDatatable("pr_select_category", GetConnectionString(), parameters);
            DataTable dt = dl.SelectDatatable("Get_Category", GetConnectionString(), parameters);
            return dt;
        }
    }
}
