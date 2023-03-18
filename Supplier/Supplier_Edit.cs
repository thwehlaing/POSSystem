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
using POS_Search;

namespace Supplier
{
    public partial class Supplier_Edit :BaseForm
    {
        string SupplierCD = string.Empty;
        public Supplier_Edit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Supplier_Search search = new Supplier_Search();
            search.ShowDialog();
            SupplierCD = search.Code;
            txtSupplierName.Text = search.Name;
            txtPhoneNo.Text = search.PNo;
            txtAddress.Text = search.SAddress;
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
            SupplierEntity obj = GetUpdateSupplier();
            SupplierBL bl = new SupplierBL();
            bool return_Bl = bl.Supplier_Update(obj);
            if (return_Bl)
            {
                bl.ShowMessage("I101");
                txtSupplierName.Focus();
                ClearData();
            }
        }

        private SupplierEntity GetUpdateSupplier()
        {
            SupplierEntity obj = new SupplierEntity();
            obj.SupplierCD = SupplierCD;
            obj.SupplierName = txtSupplierName.Text;
            obj.PhoneNo = txtPhoneNo.Text;
            obj.Address = txtAddress.Text;
            obj.Status = rdo_active.Checked == true ? "1" : "0";
            obj.UpdatedUser = obj.OperatorCD;
            obj.ProgramID = obj.ProgramID;
            return obj;
        }
        public void ErrorCheck()
        {
            txtSupplierName.CheckRequired(true);
            txtSupplierName.CheckExist(true, "Supplier", "EDIT");
            txtPhoneNo.CheckRequired(true);
            txtAddress.CheckRequired(true);
        }
        public void ClearData()
        {
            txtSupplierName.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
        }
    }
}
