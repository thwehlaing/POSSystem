using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class StockItemBL:BaseBL
    {
        public DataTable UOM_Select()
        {
            DBAccessBL dl = new DBAccessBL();
            var parameters = new SqlParameter[] { };
            DataTable dt = dl.SelectDatatable("pr_uom_select", GetConnectionString(), parameters);
            return dt;
        }
      
        public bool StockItem_Create(StockItemEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[9];
            obj.Sqlprms[0] = new SqlParameter("@SubCode", SqlDbType.VarChar) { Value = obj.SubCode };
            obj.Sqlprms[1] = new SqlParameter("@ItemName", SqlDbType.NVarChar) { Value = obj.ItemName };
            obj.Sqlprms[2] = new SqlParameter("@UOMCD", SqlDbType.VarChar) { Value = obj.UOMCD };
            obj.Sqlprms[3] = new SqlParameter("@Qty", SqlDbType.Int) { Value = obj.Qty };
            obj.Sqlprms[4] = new SqlParameter("@LastSalePrice", SqlDbType.Money) { Value = obj.LastSalePrice };
            obj.Sqlprms[5] = new SqlParameter("@BarCode", SqlDbType.VarChar) { Value = obj.BarCode };
            obj.Sqlprms[6] = new SqlParameter("@ReorderQty", SqlDbType.Int) { Value = obj.ReOrderQty };
            obj.Sqlprms[7] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };
            obj.Sqlprms[8] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = obj.CreatedUser };
            bool result = dbl.InsertUpdateDeleteData("pr_stockitem_insert", GetConnectionString(), obj.Sqlprms);
            return result;
        }

        public DataTable StockItem_Search(StockItemEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[2];
            obj.Sqlprms[0] = new SqlParameter("@SubCode", SqlDbType.VarChar) { Value = obj.SubCode };
            obj.Sqlprms[1] = new SqlParameter("@ItemName", SqlDbType.NVarChar) { Value = obj.ItemName };
            DataTable dt = dbl.SelectDatatable("pr_stockitem_search", GetConnectionString(), obj.Sqlprms);
            return dt;
        }

        public bool StockItem_Update(StockItemEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[9];
            obj.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = obj.ItemCD };
            obj.Sqlprms[1] = new SqlParameter("@ItemName", SqlDbType.NVarChar) { Value = obj.ItemName };
            obj.Sqlprms[2] = new SqlParameter("@UOMCD", SqlDbType.VarChar) { Value = obj.UOMCD };
            obj.Sqlprms[3] = new SqlParameter("@Qty", SqlDbType.Int) { Value = obj.Qty };
            obj.Sqlprms[4] = new SqlParameter("@LastSalePrice", SqlDbType.Money) { Value = obj.LastSalePrice };
            obj.Sqlprms[5] = new SqlParameter("@BarCode", SqlDbType.VarChar) { Value = obj.BarCode };
            obj.Sqlprms[6] = new SqlParameter("@ReorderQty", SqlDbType.Int) { Value = obj.ReOrderQty };
            obj.Sqlprms[7] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = obj.Status };
            obj.Sqlprms[8] = new SqlParameter("@UpdatedUser", SqlDbType.VarChar) { Value = obj.UpdatedUser };           
            bool result = dbl.InsertUpdateDeleteData("pr_stockitem_update", GetConnectionString(), obj.Sqlprms);
            return result;
        }

        public bool StockItem_Delete(StockItemEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[2];
            obj.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = obj.ItemCD };
            obj.Sqlprms[1] = new SqlParameter("@UpdatedUser", SqlDbType.VarChar) { Value = obj.UpdatedUser };
            bool result = dbl.InsertUpdateDeleteData("pr_stockitem_delete", GetConnectionString(), obj.Sqlprms);
            return result;
        }

        public DataTable StockItem_SelectBySubCategory(StockItemEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[1];
            obj.Sqlprms[0] = new SqlParameter("@SubCode", SqlDbType.VarChar) { Value = obj.SubCode };
            DataTable dt = dbl.SelectDatatable("pr_stockitem_selectbysubcategory", GetConnectionString(), obj.Sqlprms);
            return dt;
        }
        public DataTable StockItem_ExistCheck(string SubName)
        {
            StockItemEntity entity = new StockItemEntity();
            DBAccessBL dl = new DBAccessBL();
            entity.Sqlprms = new SqlParameter[2];
            entity.Sqlprms[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = SubName };
            entity.Sqlprms[1] = new SqlParameter("@TableName", SqlDbType.NVarChar) { Value = "StockItem" };
            return dl.SelectDatatable("pr_existcheck", GetConnectionString(), entity.Sqlprms);
        }
    }
}
