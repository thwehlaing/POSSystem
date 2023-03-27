using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class PurchaseItemBL:BaseBL
    {
        public bool PurchaseItem_Create(PurchaseItemEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[11];
            obj.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = obj.ItemCD };
            obj.Sqlprms[1] = new SqlParameter("@PackTypeCode", SqlDbType.VarChar) { Value = obj.PackTypeCode };
            //obj.Sqlprms[2] = new SqlParameter("@TradeCD", SqlDbType.VarChar) { Value = obj.TradeCD };
            //obj.Sqlprms[3] = new SqlParameter("@CashCD", SqlDbType.DateTime) { Value = obj.CashCD };
            obj.Sqlprms[4] = new SqlParameter("@UOMQty", SqlDbType.Int) { Value = obj.UOMQty };
            obj.Sqlprms[5] = new SqlParameter("@UOMPrice", SqlDbType.VarChar) { Value = obj.UOMPrice };
            obj.Sqlprms[6] = new SqlParameter("@PackQty", SqlDbType.Money) { Value = obj.PackQty };
            obj.Sqlprms[7] = new SqlParameter("@PackPrice", SqlDbType.VarChar) { Value = obj.PackPrice };
            obj.Sqlprms[8] = new SqlParameter("@SupplierCD", SqlDbType.Int) { Value = obj.SupplierCD };
            obj.Sqlprms[9] = new SqlParameter("@PurchaseDate", SqlDbType.VarChar) { Value = obj.PurchaseDate };
            obj.Sqlprms[10] = new SqlParameter("@CreatedUser", SqlDbType.Money) { Value = obj.CreatedUser };           
            bool result = dbl.InsertUpdateDeleteData("pr_purchaseitem_insert", GetConnectionString(), obj.Sqlprms);
            return result;
        }
    }
}
