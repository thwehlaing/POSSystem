using Entity;
using POS_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Search
{
    public partial class Search_Base : Form
    {
        public Search_Base()
        {
            InitializeComponent();
        }
        private void btnFunctionClick(object sender, EventArgs e)
        {
            PButton btn = (PButton)sender;
            if (btn.ButtonType == ButtonType.BType.Normal)
            {
                SendKeys.Send("{F9}");
            }
            else
                FireClickEvent(btn, 1);
        }
        protected void FireClickEvent(PButton btn, int type)
        {
            //switch (btn.ButtonType)
            //{
            //    case ButtonType.BType.Close:
            //        this.Close();
            //        break;
            //    case ButtonType.BType.Search:
            //    case ButtonType.BType.Save:
            //        FunctionProcess(btn.Tag.ToString());
            //        break;

            //}
        }

        public virtual void FunctionProcess(string tagID)
        {
        }
    }
}
