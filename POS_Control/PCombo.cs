using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PCombo : ComboBox
    {
        BaseBL bbl;
        ErrorCheck errchk;

        //[Browsable(true)]
        //[Category("POS Properties")]
        //[Description("tableName")]
        //[DisplayName("Type")]
        public bool IsErrorOccurs { get; set; }
        public DataTable IsDatatableOccurs { get; set; }

        public PCombo(){
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular);           
            bbl = new BaseBL();
            errchk = new ErrorCheck();
            base.MinimumSize = new Size(100, 30);
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

        protected override void InitLayout()
        {
            base.InitLayout();
            base.AutoSize = false;
            base.Height = 30;
        }

        [DllImport("gdi32.dll")]
        internal static extern IntPtr CreateSolidBrush(int color);

        [DllImport("gdi32.dll")]
        internal static extern int SetBkColor(IntPtr hdc, int color);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            IntPtr brush;
            switch (m.Msg)
            {

                case (int)312:
                    SetBkColor(m.WParam, ColorTranslator.ToWin32(this.BackColor));
                    brush = CreateSolidBrush(ColorTranslator.ToWin32(this.BackColor));
                    m.Result = brush;
                    break;
                default:
                    break;
            }
        }
    }
}
