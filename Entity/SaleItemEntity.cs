using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SaleItemEntity:BaseEntity
    {
        public string SaleNo { get; set; }

        public string ItemCD { get; set; }
        public string CashSaleCD { get; set; }
        public string GoodSaleCD { get; set; }
        public DateTime SaleDate { get; set; }
        public string InvoiceNo { get; set; }
        public int Qty { get; set; }
        public string UOMCD { get; set; }
        public double Price { get; set; }
    }
}
