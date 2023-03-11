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
        
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            ProgramID = "Supplier";
            ProgramName = "ထောက်ပံ့သူ";
            PreviousCtrl = txtSupplierName;
            txtSupplierName.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            ErrorCheck();
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                if (ErrorCheck(PanelDetail))
                {
                    DBProcess();
                }
            }
            base.FunctionProcess(tagID);
        }
        private void DBProcess()
        {
            SupplierEntity obj = GetInsertSupplier();
            SupplierBL bl = new SupplierBL();
            bool return_Bl = bl.Supplier_Create(obj);
            if (return_Bl)
            {
                bl.ShowMessage("I101");
                txtSupplierName.Focus();
                ClearData();
            }
        }

        private SupplierEntity GetInsertSupplier()
        {
            SupplierEntity obj = new SupplierEntity();
            obj.SupplierName = txtSupplierName.Text;
            obj.PhoneNo = txtPhoneNo.Text;
            obj.Address = txtAddress.Text;
            obj.Status = rdo_active.Checked == true ? "1" : "0";
            obj.CreatedUser = obj.OperatorCD;
            obj.ProgramID = obj.ProgramID;
            return obj;
        }
        public void ErrorCheck()
        {
            txtSupplierName.CheckRequired(true);
            txtPhoneNo.CheckRequired(true);
            txtAddress.CheckRequired(true);
        }
        public void ClearData()
        {
            txtSupplierName.Text ="";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
        }
    }
}
