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
        public DataTable SubCategory_Select(SubCategoryEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[2];
            obj.Sqlprms[0] = new SqlParameter("@CategoryCD", SqlDbType.VarChar) { Value = obj.CategoryCD };
            obj.Sqlprms[1] = new SqlParameter("@SubName", SqlDbType.NVarChar) { Value = obj.SubName };
            DataTable dt = dbl.SelectDatatable("pr_subcategory_select", GetConnectionString(), obj.Sqlprms);
            return dt;
        }
        public bool SubCategory_Create(SubCategoryEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[4];            
            obj.Sqlprms[0] = new SqlParameter("@CategoryCD", SqlDbType.VarChar) { Value = obj.CategoryCD };
            obj.Sqlprms[1] = new SqlParameter("@SubName", SqlDbType.NVarChar) { Value = obj.SubName };
            obj.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };           
            obj.Sqlprms[3] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = obj.CreatedUser };           
            bool result = dbl.InsertUpdateDeleteData("pr_subcategory_insert", GetConnectionString(), obj.Sqlprms);
            return result;
        }
        public bool SubCategory_Update(SubCategoryEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[5];
            obj.Sqlprms[0] = new SqlParameter("@CategoryCD", SqlDbType.VarChar) { Value = obj.CategoryCD };
            obj.Sqlprms[1] = new SqlParameter("@SubName", SqlDbType.NVarChar) { Value = obj.SubName };
            obj.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };           
            obj.Sqlprms[3] = new SqlParameter("@UpdatedUser", SqlDbType.VarChar) { Value = obj.UpdatedUser };
            obj.Sqlprms[4] = new SqlParameter("@SubCode", SqlDbType.VarChar) { Value = obj.SubCode };
            bool result = dbl.InsertUpdateDeleteData("pr_subcategory_update", GetConnectionString(), obj.Sqlprms);
            return result;
        }
        public DataTable SubCategory_Search(SubCategoryEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[2];
            obj.Sqlprms[0] = new SqlParameter("@CategoryCD", SqlDbType.VarChar) { Value = obj.CategoryCD };
            obj.Sqlprms[1] = new SqlParameter("@SubName", SqlDbType.NVarChar) { Value = obj.SubName };
            DataTable dt = dbl.SelectDatatable("pr_subcategory_search", GetConnectionString(), obj.Sqlprms);
            return dt;
        }

        public bool SubCategory_Delete(SubCategoryEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[2];
            obj.Sqlprms[0] = new SqlParameter("@SubCode", SqlDbType.VarChar) { Value = obj.SubCode };
            obj.Sqlprms[1] = new SqlParameter("@UpdatedUser", SqlDbType.VarChar) { Value = obj.UpdatedUser };
            bool result  = dbl.InsertUpdateDeleteData("pr_subcategory_delete", GetConnectionString(), obj.Sqlprms);
            return result;
        }

        public DataTable SubCategory_SelectAll()
        {
            DBAccessBL dbl = new DBAccessBL();
            var parameters = new SqlParameter[] { };
            DataTable dt = dbl.SelectDatatable("pr_subcategory_selectall", GetConnectionString(), parameters);
            return dt;
        }
    }
}
