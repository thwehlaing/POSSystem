using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POS_Control.PTextBox;

namespace POS_Control
{
    public class PTextBox:TextBox
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
        [Description("Select Default Keyboard")]
        [DisplayName("Default Language")]
        public DefKey DefaultKeyboard { get; set; } = 0;
        public enum DefKey
        {
            English = 0,
            Myanmar = 1
        }

        public PTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular);
            //cf = new CommonFunction();
            bl = new BaseBL();
            errchk = new ErrorCheck();

            base.MinimumSize = new Size(100, 19);
        }
        public override bool AutoSize
        {
            get => base.AutoSize; set => base.AutoSize = value;
        }
        public bool E101;
        public string E101Type;

        public bool IsErrorOccurs { get; set; }
        public DataTable IsDatatableOccurs { get; set; }
        public bool ErrorCheck()
        {
            (bool, DataTable) r_value = errchk.Check(this);
            IsErrorOccurs = r_value.Item1;
            IsDatatableOccurs = r_value.Item2;
            //if (!IsErrorOccurs)
            //{
            //    if (NextControl != null)
            //        NextControl.Focus();
            //}

            //if (cf.IsByteLengthOver(MaxLength, Text))
            //{
            //    IsErrorOccurs = true;
            //    MessageBox.Show("入力された文字が長すぎます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Focus();
            //}
            return IsErrorOccurs;
        }
    }
}
