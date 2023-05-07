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
    public class PurchaseItemBL : BaseBL
    {
        public bool PurchaseItem_Create(PurchaseEntity obj)
        {
            DBAccessBL dbl = new DBAccessBL();
            obj.Sqlprms = new SqlParameter[5];
            obj.Sqlprms[0] = new SqlParameter("@SupplierCD", SqlDbType.VarChar) { Value = obj.SupplierCD };
            obj.Sqlprms[1] = new SqlParameter("@PurchaseDate", SqlDbType.DateTime) { Value = obj.PurchaseDate };
            obj.Sqlprms[2] = new SqlParameter("@GrandTotal", SqlDbType.Money) { Value = obj.TotalAmt };
            obj.Sqlprms[3] = new SqlParameter("@PurchaseItemTable", SqlDbType.Structured) { Value = obj.PurchaseItem };
            obj.Sqlprms[4] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = obj.CreatedUser };
            bool result = dbl.InsertUpdateDeleteData("purchaseitem_create", GetConnectionString(), obj.Sqlprms);
            return result;
        }
    }
}
