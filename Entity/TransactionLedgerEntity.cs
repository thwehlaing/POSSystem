using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TransactionLedgerEntity:BaseEntity
    {
        public string LedgerNo { get; set; }
        public string ItemCD { get; set; }
        public int OpenQty { get; set; }
        public int PurchaseQty { get; set; }
        public int SaleQty { get; set; }
        public int CloseQty { get; set; }
        public string PackTypeCode { get; set; }
        public int PackQty { get; set; }
        public string TransactionType { get; set; }
        public DateTime LedgerDate { get; set; }
    }
}
