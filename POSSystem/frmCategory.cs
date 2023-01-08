using BL;
using POSBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class frmCategory : BaseForm
    {
        CategoryBL bl = new CategoryBL();
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            StartProgram();
            DataTable dt = new DataTable();
            dt = bl.Category_Select();
        }
    }
}
