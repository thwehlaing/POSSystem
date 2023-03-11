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


namespace PackagingType
{
    public partial class PackagingType : BaseForm
    {
        public PackagingType()
        {
            InitializeComponent();
        }

        private void PackagingType_Load(object sender, EventArgs e)
        {
            ProgramID = "PackagingType";
            ProgramName = "ထုပ်ပိုးခြင်းအမျိုးအစား";
            StartProgram();
            PreviousCtrl = txtPackTypeName;
            txtPackTypeName.Focus();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            ErrorCheck();
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
                if (ErrorCheck(PanelDetail))
                {
                    DBProcess();
                }                
            }
            base.FunctionProcess(tagID);
        }

        private void DBProcess()
        {
            PackagingTypeEntity obj = GetInsertPackagingType();
            PackagingTypeBL bl = new PackagingTypeBL();
            bool return_Bl = bl.PackagingType_Create(obj);
            if (return_Bl)
            {
                bl.ShowMessage("I101");
                txtPackTypeName.Text = "";
                txtQty.Text = "";
                txtPackTypeName.Focus();
            }
        }

        private PackagingTypeEntity GetInsertPackagingType()
        {
            PackagingTypeEntity entity = new PackagingTypeEntity();
            entity.PackTypeName = txtPackTypeName.Text;           
            entity.UOMQty = Convert.ToInt32(txtQty.Text);
            entity.Status = rdo_active.Checked == true ? "1" : "0";
            entity.CreatedUser = entity.OperatorCD;
            entity.ProgramID = entity.ProgramID;
            return entity;
        }
    }
}
