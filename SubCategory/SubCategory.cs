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


namespace SubCategory
{
    public partial class SubCategory : BaseForm
    {
        BaseEntity base_entity = new BaseEntity();
        BaseBL bbl = new BaseBL();
        public SubCategory()
        {
            InitializeComponent();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            ProgramID = "SubCategory";
            ProgramName = "ပစ္စည်းအမျိုးအစား(ခွဲ) သိမ်းခြင်း";
            cboCategory.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
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
            SubCategoryEntity obj = GetInsertSubCategory();
            SubCategoryBL bl = new SubCategoryBL();
            bool return_Bl = bl.SubCategory_CUD(obj);
            if (return_Bl)
                bbl.ShowMessage("I101");
        }

        private SubCategoryEntity GetInsertSubCategory()
        {
            SubCategoryEntity obj = new SubCategoryEntity();
            obj.CategoryCD = cboCategory.SelectedValue.ToString();
            obj.SubName = txtSubCategory.Text;
            obj.Status = rdo_active.Checked == true ? "1" : "0";
            obj.CreatedDate = DateTime.Now;
            obj.CreatedUser = base_entity.OperatorCD;
            obj.ProgramID = base_entity.ProgramID;
            return obj;
        }
        public void ErrorCheck()
        {
            cboCategory.CheckRequired(true);
            txtSubCategory.CheckRequired(true);
        }
    }
}
