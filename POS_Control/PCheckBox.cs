using BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PCheckBox:CheckBox
    {
        ErrorCheck errchk;
        BaseBL bl;
        //Constructor
        public PCheckBox()
        {
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular);
            bl = new BaseBL();
            errchk = new ErrorCheck();
        }
        public bool IsErrorOccurs { get; set; }
        public DataTable IsDatatableOccurs { get; set; }

        protected override void InitLayout()
        {
            base.InitLayout();
            base.AutoSize = false;
            base.Height = 19;
        }

        public bool ErrorCheck()
        {
            (bool, DataTable) r_value = errchk.Check(this);
            IsErrorOccurs = r_value.Item1;
            IsDatatableOccurs = r_value.Item2;
            //if (!IsErrorOccurs)
            //{
            //    Control nextControl = this.TopLevelControl.Controls.Find(NextControlName, true)[0];
            //    nextControl.Focus();
            //}
            return IsErrorOccurs;
        }
    }
}
