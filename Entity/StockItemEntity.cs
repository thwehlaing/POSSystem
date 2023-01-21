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
        public string Qty { get; set; }
        public string LastSalePrice { get; set; }
        public string BarCode { get; set; }
        public string ReOrderQty { get; set; }
    }
}
