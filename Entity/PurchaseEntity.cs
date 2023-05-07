using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class PurchaseEntity:BaseEntity
    {
        public string PurchaseNo { get; set; }
        public string SupplierCD { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double TotalAmt { get; set; }
        public string Status { get; set; }
        public string PNoInvoice { get; set; }
        public DataTable PurchaseItem { get; set; }
    }

    public class PurchaseItemEntity
    {       
        public string ItemCD { get; set; }
        public string PackTypeCode { get; set; }
        public int UOMQty { get; set; }
        public double UOMPrice { get; set; }
        public int PackQty { get; set; }
        public double PackPrice { get; set; }
    }
}
