﻿using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PCombo:  ComboBox
    {
        BaseBL bl = new BaseBL();
        ErrorCheck errchk;
        public PCombo()
        {
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular);
            errchk = new ErrorCheck();

            base.MinimumSize = new Size(100, 20);
        }
        [Browsable(true)]
        [Category("POS Properties")]
        [Description("NextControlName")]
        [DisplayName("NextControlName")]
        public string NextControlName { get; set; }
        public Control NextControl { get; set; }
        public bool IsErrorOccurs { get; set; }
        public DataTable IsDatatableOccurs { get; set; }
        public bool ErrorCheck()
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
            if (e.KeyCode == Keys.F9)
            {
                this.DroppedDown = true;
            }
            else if (e.KeyCode == Keys.Enter)//to show search screen when user press enter in Combo Task NO. 576 NMW
            {
                ErrorCheck();
            }
        }
        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 255, 255);
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLeave(e);
        }
    }
}
