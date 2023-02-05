using BL;
using Entity;
using POS_Control;
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
    public partial class Category : BaseForm
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            ProgramID = "Category";
            ProgramName = "ပစ္စည်းအမျိုးအစား သိမ်းခြင်း";
            txtName.Focus();
            PreviousCtrl = txtName;

            StartProgram();

            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
           
            SetButton(ButtonType.BType.Display, F2, "သိမ်းမည်", true);

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
                if (ErrorCheck(panelDetail))
                {
                    DBProcess();
                }
            }
            base.FunctionProcess(tagID);
        }
        private void DBProcess()
        {
            CategoryEntity entity = new CategoryEntity();
            entity.CategoryName = txtName.Text;
            entity.Status = rdo_active.Checked ? "1" : "0";
            CategoryBL bl = new CategoryBL();
            
        }
    }
}
