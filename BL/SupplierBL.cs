using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BL
{
    public class SupplierBL:BaseBL
    {
        public bool Supplier_Create(SupplierEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[5];
            obj.Sqlprms[0] = new SqlParameter("@SupplierName", SqlDbType.NVarChar) { Value = obj.SupplierName };
            obj.Sqlprms[1] = new SqlParameter("@PhoneNo", SqlDbType.NVarChar) { Value = obj.PhoneNo };
            obj.Sqlprms[2] = new SqlParameter("@Address", SqlDbType.NVarChar) { Value = obj.Address };
            obj.Sqlprms[3] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };
            obj.Sqlprms[4] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = obj.CreatedUser };
            bool result = dbl.InsertUpdateDeleteData("pr_supplier_insert", GetConnectionString(), obj.Sqlprms);
            return result;
        }

        public DataTable Supplier_Search(SupplierEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[1];
            obj.Sqlprms[0] = new SqlParameter("@SupplierName", SqlDbType.NVarChar) { Value = obj.SupplierName };          
            DataTable dt = dbl.SelectDatatable("pr_supplier_search", GetConnectionString(), obj.Sqlprms);
            return dt;
        }

        public bool Supplier_Update(SupplierEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[6];
            obj.Sqlprms[0] = new SqlParameter("@SupplierCD", SqlDbType.VarChar) { Value = obj.SupplierCD };
            obj.Sqlprms[1] = new SqlParameter("@SupplierName", SqlDbType.NVarChar) { Value = obj.SupplierName };
            obj.Sqlprms[2] = new SqlParameter("@PhoneNo", SqlDbType.NVarChar) { Value = obj.PhoneNo };
            obj.Sqlprms[3] = new SqlParameter("@Address", SqlDbType.NVarChar) { Value = obj.Address };
            obj.Sqlprms[4] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };
            obj.Sqlprms[5] = new SqlParameter("@UpdatedUser", SqlDbType.VarChar) { Value = obj.UpdatedUser };
            bool result = dbl.InsertUpdateDeleteData("pr_supplier_update", GetConnectionString(), obj.Sqlprms);
            return result;
        }

    }
}
