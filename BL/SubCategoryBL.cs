using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SubCategoryBL:BaseBL
    {
        public DataTable GetSubCategory()
        {
            DBAccessBL dbl = new DBAccessBL();
            var parameter = new SqlParameter[] {};
            DataTable dt = dbl.SelectDatatable("pr_select_subcategory", GetConnectionString(), parameter);
            return dt;
        }
        public bool SubCategory_CUD(SubCategoryEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[5];            
            obj.Sqlprms[0] = new SqlParameter("@CategoryCD", SqlDbType.VarChar) { Value = obj.CategoryCD };
            obj.Sqlprms[1] = new SqlParameter("@SubName", SqlDbType.VarChar) { Value = obj.SubName };
            obj.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };
            obj.Sqlprms[3] = new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = obj.CreatedDate };
            obj.Sqlprms[4] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = obj.CreatedUser };
            //obj.Sqlprms[5] = new SqlParameter("@Mode", SqlDbType.VarChar) { Value = obj.Mode };
            bool result = dbl.InsertUpdateDeleteData("SubCategory_cud", GetConnectionString(), obj.Sqlprms);
            return result;
        }
    }
}
