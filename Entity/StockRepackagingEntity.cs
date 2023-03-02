using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StockRepackagingEntity:BaseEntity
    {
        public string RepackageNo { get; set; }
        public string ItemCD { get; set; }
        public string PackTypeCode { get; set; }
        public string Qty { get; set; }
        public string RepackageDate { get; set; }
        public string UOMQty { get; set; }
    }
}
