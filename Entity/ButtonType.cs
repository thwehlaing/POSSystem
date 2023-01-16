using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ButtonType
    {
        public BType BtnType { get; set; }
        public enum BType
        {
            Normal,
            New,
            Update,
            Delete,
            Save,
            Cancel,
            Close, 
            Display
        }
    }
}
