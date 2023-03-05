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
        BaseBL bbl = new BaseBL();
        string SubCode = string.Empty;
        public SubCategory_Edit()
        {
            InitializeComponent();
        }

        private void SubCategory_Edit_Load(object sender, EventArgs e)
        {
            ProgramID = "SubCategory_Edit";
            ProgramName = "ပစ္စည်းအမျိုးအစား(ခွဲ) ပြင်ခြင်း";          
            PreviousCtrl =txtSubName;
            cboCategory.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြင်ခြင်း", true);
            BindCatgory();
            ErrorCheck();
        }

        private void BindCatgory()
        {
            CategoryBL cbl = new CategoryBL();
            DataTable dtCategory = new DataTable();
            dtCategory = cbl.Category_Select();
            DataRow dr = dtCategory.NewRow();
            dr["CategoryCD"] = "-1";
            dtCategory.Rows.InsertAt(dr, 0);
            cboCategory.DataSource = dtCategory;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryCD";
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
            SubCategoryEntity obj = GetUpdateSubCategory();
            SubCategoryBL bl = new SubCategoryBL();
            bool return_Bl = bl.SubCategory_Update(obj);
            if (return_Bl)
            {
                ClearData();
                bl.ShowMessage("I101");                
            }                
        }

        private SubCategoryEntity GetUpdateSubCategory()
        {
            SubCategoryEntity obj = new SubCategoryEntity();
            obj.SubCode = SubCode;
            obj.CategoryCD = cboCategory.SelectedValue.ToString();
            obj.SubName = txtSubName.Text;
            obj.Status = rdo_active.Checked == true ? "1" : "0";           
            obj.UpdatedUser= obj.OperatorCD;
            obj.ProgramID = obj.ProgramID;
            return obj;
        }
        public void ErrorCheck()
        {
            cboCategory.CheckRequired(true);
            txtSubName.CheckRequired(true);
        }

        public void ClearData()
        {
            cboCategory.SelectedIndex = -1;
            txtSubName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue!= "-1")
            {
                SubCategory_Search search = new SubCategory_Search(cboCategory.SelectedValue.ToString(),cboCategory.Text);
                search.ShowDialog();               
                SubCode = search.SubCategoryCD;
                txtSubName.Text = search.SubCategoryName;
            }
            else
                bbl.ShowMessage("E101");
        }
    }
}
