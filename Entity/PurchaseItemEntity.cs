using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PurchaseItemEntity:BaseEntity
    {
        public string PurchaseNo { get; set; }
        public string ItemCD { get; set; }
        public string PackTypeCode { get; set; }
        public string TradeCD { get; set; }
        public string CashCD { get; set; }
        public int UOMQty { get; set; }
        public double UOMPrice { get; set; }
        public int PackQty { get; set; }
        public double PackPrice { get; set; }
        public string SupplierCD { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
