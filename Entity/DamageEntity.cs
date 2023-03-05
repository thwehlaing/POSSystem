using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DamageEntity:BaseEntity
    {
        public string DamageNo { get; set; }
        public string ItemCD { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }
        public DateTime DamageDate { get; set; }
    }
}
