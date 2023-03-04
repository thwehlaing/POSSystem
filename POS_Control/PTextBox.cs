using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entity.SearchType;
using static POS_Control.PTextBox;

namespace POS_Control
{
    public class PTextBox : TextBox
    {
        BaseBL bl = new BaseBL();
        ErrorCheck errchk;
        public enum PTextBoxType
        {
            Normal = 0,
            Date = 1,//check dateformat
            Price = 2,//check price format
            Number = 3,//check integer only
            Time = 4,//Time format
            YearMonth = 5 //2019/01 format   
        }


        private PTextBoxType PType { get; set; }
        [Browsable(true)]
        [Category("POS Properties")]
        [Description("Select Control Type")]
        [DisplayName("Control Type")]
        public PTextBoxType TextBoxType
        {
            get { return PType; }
            set
            {
                PType = value;
            }
        }

        [Browsable(true)]
        [Category("POS Properties")]
        [Description("NextControlName")]
        [DisplayName("NextControlName")]
        public string NextControlName { get; set; }
        public Control NextControl { get; set; }

        [Browsable(true)]
        [Category("POS Properties")]
        [Description("SearchType")]
        [DisplayName("SearchType")]
        public ScType SearchType { get; set; }

        public PTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular);
            //cf = new CommonFunction();
            bl = new BaseBL();
            errchk = new ErrorCheck();

            base.MinimumSize = new Size(100, 20);
        }
        public override bool AutoSize
        {
            get => base.AutoSize; set => base.AutoSize = value;
        }

        public bool IsErrorOccurs { get; set; }
        public DataTable IsDatatableOccurs { get; set; }

        //public bool E101;
        //public string E101Type;

        //public Control ctrlE101_1;
        //public Control ctrlE101_2;
        //public Control ctrlE101_3;

        public  bool ErrorCheck()
        {
            (bool, DataTable) r_value = errchk.Check(this);
            IsErrorOccurs = r_value.Item1;
            IsDatatableOccurs = r_value.Item2;
            if (!IsErrorOccurs)
            {
                Control nextControl = this.TopLevelControl.Controls.Find(NextControlName, true)[0];
                nextControl.Focus();
            }
            return IsErrorOccurs;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ErrorCheck())
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    base.OnKeyDown(e);
                }
            }
        }
        [Browsable(true)]
        [Category("POS Properties")]
        [Description("Select Default Keyboard")]
        [DisplayName("Default Language")]
        public DefKey DefaultKeyboard { get; set; } = 0;
        public enum DefKey
        {
            English = 0,
            Myanmar = 1
        }
        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 255, 255);

            this.ImeMode = ImeMode.NoControl;
            if (DefaultKeyboard == DefKey.Myanmar)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("my-MM"));
            }

        }
        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLeave(e);
        }
        public bool E101;
        public void CheckRequired(bool value)
        {
            E101 = value;
        }
    }
}
