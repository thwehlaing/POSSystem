using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserEntity:BaseEntity
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
