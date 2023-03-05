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
    }
}
