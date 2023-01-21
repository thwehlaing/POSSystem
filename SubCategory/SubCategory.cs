using Entity;
using POSBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubCategory
{
    public partial class SubCategory : BaseForm
    {
        BaseEntity base_entity;
        public SubCategory()
        {
            InitializeComponent();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            ProgramID = "SubCategory";
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Display, F2, "ထည့်မည်", true);
            cboCategory.Focus();
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "12")
            {              
                DBProcess();
            }
            base.FunctionProcess(tagID);
        }

        private void DBProcess()
        {
            SubCategoryEntity entity = GetInsertSubCategory();
        }

        private SubCategoryEntity GetInsertSubCategory()
        {
            SubCategoryEntity obj = new SubCategoryEntity();
            obj.CategoryCD = cboCategory.SelectedValue.ToString();
            obj.SubCode = "";
            obj.SubName = txtSubCategory.Text;
            obj.CreatedDate = DateTime.Now;
            obj.InsertOperator = base_entity.OperatorCD;
            obj.ProgramID = base_entity.ProgramID;
            return obj;
        }

        private void ErrorCheck()
        {
            //E102
           //txtSubCategory.e0
        }
    }
}
