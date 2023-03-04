using Entity;
using POS_Search;
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
using Entity;
using BL;

namespace Category
{
    public partial class Category_Edit : BaseForm
    {
        string CatCD = string.Empty;
        public Category_Edit()
        {
            InitializeComponent();
        }

        private void Category_Edit_Load(object sender, EventArgs e)
        {
            ProgramID = "Category_Edit";
            ProgramName = "ပစ္စည်းအမျိုးအစား ပြင်ခြင်း";
            txtName.Focus();

            StartProgram();

            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);

            SetButton(ButtonType.BType.Save, F2, "ပြင်ခြင်း", true);

            ErrorChek();
        }
        private void ErrorChek()
        {
            txtName.CheckRequired(true);
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                if (!txtName.IsErrorOccurs)
                {
                    DBProcess();
                }
            }
            base.FunctionProcess(tagID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Category_Search cate_Search = new Category_Search();
            cate_Search.ShowDialog();
            txtName.Text = cate_Search.Category_Name;
            CatCD = cate_Search.CategoryCD;
        }

        private void DBProcess()
        {
            CategoryEntity obj = GetUpdateCategory();
            CategoryBL bl = new CategoryBL();
            bool return_Bl = bl.Category_Update(obj);
            if (return_Bl)
            {
                bl.ShowMessage("I101");
                txtName.Focus();
            }
        }

        private CategoryEntity GetUpdateCategory()
        {
            CategoryEntity obj = new CategoryEntity();
            obj.CategoryCD = CatCD;
            obj.CategoryName = txtName.Text;
            obj.Status = rdo_active.Checked == true ? "1" : "0";
            obj.UpdatedUser = obj.OperatorCD;
            obj.ProgramID = obj.ProgramID;
            return obj;
        }
    }
}
