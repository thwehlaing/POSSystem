using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StockItemEntity:BaseEntity
    {
        public string ItemCD { get; set; }
        public string CategoryCD { get; set; }
        public string SubCode { get; set; }
        public string ItemName { get; set; }
        public string UOMCD { get; set; }
        public int Qty { get; set; }
        public double LastSalePrice { get; set; }
        public string BarCode { get; set; }
        public int ReOrderQty { get; set; }
        public string Status { get; set; }
    }
}
