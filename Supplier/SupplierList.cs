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
    public partial class SupplierList :BaseForm
    {
        public SupplierList()
        {
            InitializeComponent();
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            ProgramID = "SupplierList";
            ProgramName = "ထောက်ပံ့သူ ပြခြင်း";
            PreviousCtrl = txtSupplierName;
            txtSupplierName.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြခြင်း", true);
            txtSupplierName.CheckRequired(true);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!txtSupplierName.IsErrorOccurs)
            {
                DBProcess();
            }
        }

        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                if (!txtSupplierName.IsErrorOccurs)
                {
                    DBProcess();
                }
            }
            base.FunctionProcess(tagID);
        }

        private void DBProcess()
        {
            SupplierEntity entity = GetSupplier();
            SupplierBL bl = new SupplierBL();
            dgvSupplier.Rows.Clear();
            dgvSupplier.DataSource = bl.Supplier_Search(entity);
        }

        private SupplierEntity GetSupplier()
        {
            SupplierEntity obj = new SupplierEntity();
            obj.SupplierName = txtSupplierName.Text;
            return obj;
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                SupplierBL bl = new SupplierBL();
                if (bl.ShowMessage("Q004") == DialogResult.Yes)
                {                   
                    SupplierEntity obj = new SupplierEntity();
                    obj.SupplierCD = dgvSupplier.Rows[e.RowIndex].Cells["SupplierCD"].Value.ToString();
                    obj.UpdatedUser = obj.OperatorCD;
                    bool return_Bl = bl.Supplier_Delete(obj);
                    if (return_Bl)
                    {
                        dgvSupplier.Rows.RemoveAt(e.RowIndex);
                        bl.ShowMessage("I102");                       
                    }
                }
            }
        }
    }
}
