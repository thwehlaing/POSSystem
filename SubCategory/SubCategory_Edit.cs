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
using POS_Search;
using BL;


namespace SubCategory
{
    public partial class SubCategory_Edit : BaseForm
    {
        BaseEntity base_entity = new BaseEntity();
        BaseBL bbl = new BaseBL();
        string CatCode = string.Empty;
        string SubCode = string.Empty;
        public SubCategory_Edit()
        {
            InitializeComponent();
        }

        private void SubCategory_Edit_Load(object sender, EventArgs e)
        {
            ProgramID = "SubCategory_Edit";
            ProgramName = "ပစ္စည်းအမျိုးအစား(ခွဲ) ပြင်ခြင်း";
            txtSubName.Focus();

            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြင်ခြင်း", true);
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
            SubCategoryEntity obj = GetUpdateCategory();
            SubCategoryBL bl = new SubCategoryBL();
            bool return_Bl = bl.SubCategory_Update(obj);
            if (return_Bl)
                bbl.ShowMessage("I101");
        }

        private SubCategoryEntity GetUpdateCategory()
        {
            SubCategoryEntity obj = new SubCategoryEntity();
            obj.SubCode = SubCode;
            obj.CategoryCD = CatCode;
            obj.SubName = txtSubName.Text;
            obj.Status = rdo_active.Checked == true ? "1" : "0";
            obj.UpdatedDate = DateTime.Now;
            obj.UpdatedUser= base_entity.OperatorCD;
            obj.ProgramID = base_entity.ProgramID;
            return obj;
        }
        public void ErrorCheck()
        {
           
            txtSubName.CheckRequired(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SubCategory_Search search = new SubCategory_Search();
            search.ShowDialog();
            CatCode = search.CatCD;
            SubCode = search.SubCategoryCD;
            txtSubName.Text = search.SubCategoryName;

        }
    }
}
