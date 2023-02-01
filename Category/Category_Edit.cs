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

namespace Category
{
    public partial class Category_Edit : BaseForm
    {
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

            SetButton(ButtonType.BType.Display, F2, "ပြင်ခြင်း", true);
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                if (ErrorCheck(panelDetail))
                {

                }
            }
            base.FunctionProcess(tagID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Category_Search cate_Search = new Category_Search();
            cate_Search.ShowDialog();
        }
    }
}
