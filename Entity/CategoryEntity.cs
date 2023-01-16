using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CategoryEntity : BaseEntity
    {       
        public string CategoryCD { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
    }
}
