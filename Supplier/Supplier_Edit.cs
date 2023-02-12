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
using Entity;
using BL;

namespace Supplier
{
    public partial class Supplier_Edit :BaseForm
    {
        public Supplier_Edit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void Supplier_Edit_Load(object sender, EventArgs e)
        {
            ProgramID = "Supplier Edit";
            ProgramName = "ထောက်ပံ့သူ";
            PreviousCtrl = txtSupplierName;
            txtSupplierName.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
        }
    }
}
