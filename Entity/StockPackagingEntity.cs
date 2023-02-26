using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StockPackagingEntity:BaseEntity
    {
        public string ItemCD { get; set; }
        public string PackTypeCode { get; set;}
        public int Qty { get; set; }
        public int OpenQty { get; set; }
    }
}
