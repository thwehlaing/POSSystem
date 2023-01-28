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
            ProgramName = "ပစ္စည်းအမျိုးအစား";

            StartProgram();

            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
           
            SetButton(ButtonType.BType.Display, F2, "ပြမည်", true);
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
    }
}
