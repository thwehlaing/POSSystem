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
        public string Code = "";
        public string Name = "";
        public string PNo = "";
        public string SAddress = "";
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
            DataGridviewBind();
        }

        private void DataGridviewBind()
        {
            SupplierEntity entity = new SupplierEntity();
            entity.SupplierName = txtSubCategory.Text;            
            SupplierBL sbl = new SupplierBL();
            dgvSupplier.DataSource = sbl.Supplier_Search(entity);
        }

        private void dgvSupplier_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetDataGridViewData(dgvSupplier.Rows[e.RowIndex]);
            }
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                DataGridViewRow row = dgvSupplier.CurrentRow;
                GetDataGridViewData(row);
            }
            base.FunctionProcess(tagID);
        }

        private void GetDataGridViewData(DataGridViewRow row)
        {
            if (row != null)
            {
                Code = row.Cells["SupplierCD"].Value.ToString();
                Name = row.Cells["SupplierName"].Value.ToString();
                PNo = row.Cells["PhoneNo"].Value.ToString();
                SAddress = row.Cells["Address"].Value.ToString();
            }
            this.Close();
        }
       
    }
}
