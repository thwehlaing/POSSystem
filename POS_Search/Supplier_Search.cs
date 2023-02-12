using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entity;

namespace POS_Search
{
    public partial class Supplier_Search : Search_Base
    {
        public string SupplierCD = "";
        public string SupplierName = "";
        public string PhoneNo = "";
        public string Address = "";
        public Supplier_Search()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataGridviewBind();
        }

        private void Supplier_Search_Load(object sender, EventArgs e)
        {
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ယူမည်", true);
        }

        private void DataGridviewBind()
        {
            SupplierEntity entity = new SupplierEntity();
            entity.SupplierName = txtSubCategory.Text;            
            SupplierBL sbl = new SupplierBL();
            
        }
    }
}
