using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSBase;
using BL;
using Entity;


namespace Supplier
{
    public partial class Supplier : BaseForm
    {
        BaseBL bl = new BaseBL();
        
        public Supplier()
        {
            InitializeComponent();
        }
    }
}
