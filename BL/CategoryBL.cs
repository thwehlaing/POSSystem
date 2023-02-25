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
            entity.Sqlprms = new SqlParameter[3];
            entity.Sqlprms[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar) { Value = entity.CategoryName.ToString() };
            entity.Sqlprms[1] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = entity.Status.ToString() };
            entity.Sqlprms[2] = new SqlParameter("@Operator", SqlDbType.VarChar) { Value = entity.OperatorCD };            
            return dl.InsertUpdateDeleteData("pr_category_insert", GetConnectionString(), entity.Sqlprms);
        }
        public bool Category_Update(CategoryEntity entity)
        {
            DBAccessBL dl = new DBAccessBL();
            entity.Sqlprms = new SqlParameter[4];
            entity.Sqlprms[0] = new SqlParameter("@CategoryCD", SqlDbType.NVarChar) { Value = entity.CategoryCD.ToString() };
            entity.Sqlprms[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar) { Value = entity.CategoryName.ToString() };
            entity.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = entity.Status.ToString() };
            entity.Sqlprms[3] = new SqlParameter("@Operator", SqlDbType.VarChar) { Value = entity.OperatorCD };
            return dl.InsertUpdateDeleteData("pr_category_update", GetConnectionString(), entity.Sqlprms);
        }
        public bool Category_Delete(CategoryEntity entity)
        {
            DBAccessBL dl = new DBAccessBL();
            entity.Sqlprms = new SqlParameter[2];
            entity.Sqlprms[0] = new SqlParameter("@CategoryCD", SqlDbType.NVarChar) { Value = entity.CategoryCD.ToString() };
            entity.Sqlprms[1] = new SqlParameter("@Operator", SqlDbType.VarChar) { Value = entity.OperatorCD };
            return dl.InsertUpdateDeleteData("pr_category_delete", GetConnectionString(), entity.Sqlprms);
        }

        public DataTable Category_Search(CategoryEntity entity)
        {
            DBAccessBL dl = new DBAccessBL();
            entity.Sqlprms = new SqlParameter[1];
            entity.Sqlprms[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar) { Value = entity.CategoryName.ToString() };
            return dl.SelectDatatable("pr_category_search", GetConnectionString(), entity.Sqlprms);
        }
    }
}
