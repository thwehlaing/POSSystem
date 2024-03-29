﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class PackagingTypeBL:BaseBL
    {
        public DataTable PackagingType_Select()
        {
            DBAccessBL dl = new DBAccessBL();
            var parameters = new SqlParameter[] { };
            return dl.SelectDatatable("pr_packagingtype_select", GetConnectionString(), parameters);
        }
        public bool PackagingType_Create(PackagingTypeEntity obj)
        {
            DBAccessBL dl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[4];
            obj.Sqlprms[0] = new SqlParameter("@PackTypeName", SqlDbType.NVarChar) { Value = obj.PackTypeName };
            obj.Sqlprms[1] = new SqlParameter("@UOMQty", SqlDbType.VarChar) { Value = obj.UOMQty };
            obj.Sqlprms[2] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };
            obj.Sqlprms[3] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = obj.CreatedUser };
            return dl.InsertUpdateDeleteData("pr_packagingtype_insert", GetConnectionString(), obj.Sqlprms);
        }
        public DataTable PackagingType_Search(PackagingTypeEntity obj)
        {
            DBAccessBL dl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[1];
            obj.Sqlprms[0] = new SqlParameter("@PackTypeName", SqlDbType.NVarChar) { Value = obj.PackTypeName };
            return dl.SelectDatatable("pr_packagingtype_search", GetConnectionString(), obj.Sqlprms);
        }
        public bool PackagingType_Edit(PackagingTypeEntity obj)
        {
            DBAccessBL dl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[5];
            obj.Sqlprms[0] = new SqlParameter("@PackTypeCode", SqlDbType.VarChar) { Value = obj.PackTypeCode };
            obj.Sqlprms[1] = new SqlParameter("@PackTypeName", SqlDbType.NVarChar) { Value = obj.PackTypeName };
            obj.Sqlprms[2] = new SqlParameter("@UOMQty", SqlDbType.VarChar) { Value = obj.UOMQty };
            obj.Sqlprms[3] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };
            obj.Sqlprms[4] = new SqlParameter("@UpdatedUser", SqlDbType.VarChar) { Value = obj.UpdatedUser };
            return dl.InsertUpdateDeleteData("pr_packagingtype_update", GetConnectionString(), obj.Sqlprms);
        }
        public bool PackagingType_Delete(PackagingTypeEntity obj)
        {
            DBAccessBL dl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[2];
            obj.Sqlprms[0] = new SqlParameter("@PackTypeCode", SqlDbType.VarChar) { Value = obj.PackTypeCode };
            obj.Sqlprms[1] = new SqlParameter("@UpdatedUser", SqlDbType.VarChar) { Value = obj.UpdatedUser };
            return dl.InsertUpdateDeleteData("pr_packagingtype_delete", GetConnectionString(), obj.Sqlprms);
        }

        public DataTable PackagingType_ExistCheck(string SupplierName)
        {
            PackagingTypeEntity entity = new PackagingTypeEntity();
            DBAccessBL dl = new DBAccessBL();
            entity.Sqlprms = new SqlParameter[2];
            entity.Sqlprms[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = SupplierName };
            entity.Sqlprms[1] = new SqlParameter("@TableName", SqlDbType.NVarChar) { Value = "PackagingType" };
            return dl.SelectDatatable("pr_existcheck", GetConnectionString(), entity.Sqlprms);
        }
        public DataTable BindQtyPerPack(string PackTypeCode)
        {
            DBAccessBL dl = new DBAccessBL();
            PackagingTypeEntity entity = new PackagingTypeEntity();
            entity.Sqlprms = new SqlParameter[1];
            entity.Sqlprms[0] = new SqlParameter("@PackTypeCode", SqlDbType.NVarChar) { Value = PackTypeCode };           
            return dl.SelectDatatable("pr_packagingtype_selectQtyPerPack", GetConnectionString(), entity.Sqlprms);
        }
    }
}
