using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CashLedgerEntity
    {
        public string CashLedgerNo { get; set; }
        public string LedgerType { get; set; }
        public string ItemCD { get; set; }
        public int OpenAmt { get; set; }
        public int PurchaseAmt { get; set; }
        public int SaleAmt { get; set; }
        public int CloseAmt { get; set; }
        public DateTime LedgerDate { get; set; }
    }
}
