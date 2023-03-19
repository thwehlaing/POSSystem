using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PackagingTypeEntity:BaseEntity
    {
        public string PackTypeCode { get; set; }
        public string PackTypeName { get; set; }
        public int UOMQty { get; set; }
        public string Status { get; set; }
    }
}
