using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SaleInvoiceEntity
    {
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Remark { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double NetAmount { get; set; }
    }
}
