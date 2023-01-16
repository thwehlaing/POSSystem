using Entity;
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

namespace SubCategory
{
    public partial class SubCategory : BaseForm
    {
        public SubCategory()
        {
            InitializeComponent();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            ProgramID = "SubCategory";
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Display, F2, "ပြမည်", true);
        }
    }
}
