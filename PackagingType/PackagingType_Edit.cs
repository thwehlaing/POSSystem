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
using POS_Search;

namespace PackagingType
{
    public partial class PackagingType_Edit : BaseForm
    {
        string PTypeCode = string.Empty;
        public PackagingType_Edit()
        {
            InitializeComponent();
        }

        private void PackagingType_Edit_Load(object sender, EventArgs e)
        {
            ProgramID = "PackagingType_Edit";
            ProgramName = "ထုပ်ပိုးခြင်းအမျိုးအစား ပြင်ဆင်ချက်";
            StartProgram();
            PreviousCtrl = txtPackTypeName;
            txtPackTypeName.Focus();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြင်မည်", true);
            ErrorCheck();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PackagingType_Search search = new PackagingType_Search();
            search.ShowDialog();
            PTypeCode = search.PTypeCD;
            txtPackTypeName.Text = search.PTypeName;
            txtQty.Text = search.PQty.ToString();
        }
        
        private void ErrorCheck()
        {
            txtPackTypeName.CheckRequired(true);
            txtQty.CheckRequired(true);
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                DoProcess();
            }
            base.FunctionProcess(tagID);
        }

        private void DoProcess()
        {
            PackagingTypeEntity entity = GetUpdatePackagingType();
            PackagingTypeBL bl = new PackagingTypeBL();
            bool result = bl.PackagingType_Edit(entity);
            if (result)
            {
                bl.ShowMessage("I101");
                txtPackTypeName.Text = "";
                txtQty.Text = "";
            }
        }
        private PackagingTypeEntity GetUpdatePackagingType()
        {
            PackagingTypeEntity entity = new PackagingTypeEntity();
            entity.PackTypeCode = PTypeCode;
            entity.PackTypeName = txtPackTypeName.Text;
            entity.Qty = Convert.ToInt32(txtQty.Text);
            entity.Status = rdo_active.Checked ? "1" : "0";
            entity.UpdatedUser = entity.OperatorCD;
            return entity;
        }
    }
}
