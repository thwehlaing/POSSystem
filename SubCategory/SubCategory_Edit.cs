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


namespace SubCategory
{
    public partial class SubCategory_Edit : BaseForm
    {
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
            SetButton(ButtonType.BType.Display, F2, "ပြင်ခြင်း", true);
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                if (ErrorCheck(PanelDetail))
                {

                }
            }
            base.FunctionProcess(tagID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SubCategory_Search search = new SubCategory_Search();
            search.ShowDialog();
            txtSubName.Text = search.SubCategoryName;

        }
    }
}
