using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SubCategoryEntity:BaseEntity
    {
        public string SubCode { get; set; }
        public string CategoryCD { get; set; }
        public string SubName { get; set; }
        public string Status { get; set; }
    }
}
