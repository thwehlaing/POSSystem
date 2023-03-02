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
    public class StockPackagingBL:BaseBL
    {
        public bool StockPackaging_Insert(StockPackagingEntity entity)
        {
            DBAccessBL dl = new DBAccessBL();
            entity.Sqlprms = new SqlParameter[4];
            entity.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = entity.ItemCD.ToString() };
            entity.Sqlprms[1] = new SqlParameter("@PackTypeCode", SqlDbType.VarChar) { Value = entity.PackTypeCode.ToString() };
            entity.Sqlprms[2] = new SqlParameter("@Qty", SqlDbType.Int) { Value = entity.Qty };
            entity.Sqlprms[3] = new SqlParameter("@CreatedUser", SqlDbType.VarChar) { Value = entity.OperatorCD };
            return dl.InsertUpdateDeleteData("pr_stockpackaging_insert", GetConnectionString(), entity.Sqlprms);
        }

        public DataTable StockPackaging_Select(StockPackagingEntity entity)
        {
            DBAccessBL dl = new DBAccessBL();
            entity.Sqlprms = new SqlParameter[1];
            entity.Sqlprms[0] = new SqlParameter("@ItemCD", SqlDbType.VarChar) { Value = entity.ItemCD };
            return dl.SelectDatatable("pr_stockpackaging_select", GetConnectionString(), entity.Sqlprms);
        }
    }
}
