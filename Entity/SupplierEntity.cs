using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SupplierEntity:BaseEntity
    {
        public string SupplierCD { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }        
    }
}
