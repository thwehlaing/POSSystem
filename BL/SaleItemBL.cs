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
    public class SaleItemBL:BaseBL
    {
        public DataTable CashType_Select()
        {
            DBAccessBL dl = new DBAccessBL();
            var parameters = new SqlParameter[] { };
            DataTable dt = dl.SelectDatatable("pr_cashtype_select", GetConnectionString(), parameters);
            return dt;
        }
        public DataTable TradeType_Select()
        {
            DBAccessBL dl = new DBAccessBL();
            var parameters = new SqlParameter[] { };
            DataTable dt = dl.SelectDatatable("pr_tradetype_select", GetConnectionString(), parameters);
            return dt;
        }

        public bool SaleItem_Create(SaleItemEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[8];
            obj.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = obj.ItemCD };
            obj.Sqlprms[1] = new SqlParameter("@CashSaleCD", SqlDbType.VarChar) { Value = obj.CashSaleCD };
            obj.Sqlprms[2] = new SqlParameter("@GoodSaleCD", SqlDbType.VarChar) { Value = obj.GoodSaleCD };
            obj.Sqlprms[3] = new SqlParameter("@SaleDate", SqlDbType.DateTime) { Value = obj.SaleDate };
            obj.Sqlprms[4] = new SqlParameter("@Qty", SqlDbType.Int) { Value = obj.Qty };
            obj.Sqlprms[5] = new SqlParameter("@UOMCD", SqlDbType.VarChar) { Value = obj.UOMCD };
            obj.Sqlprms[6] = new SqlParameter("@Price", SqlDbType.Money) { Value = obj.Price };
            obj.Sqlprms[7] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = obj.CreatedUser };
            bool result = dbl.InsertUpdateDeleteData("pr_saleitem_insert", GetConnectionString(), obj.Sqlprms);
            return result;
        }
    }
}
