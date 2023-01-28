using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PRadio: RadioButton
    {
        [Browsable(true)]
        [Category("POS Properties")]
        [Description("NextControlName")]
        [DisplayName("NextControlName")]
        public string NextControlName { get; set; }
        public Control NextControl { get; set; }

        public PRadio() : base()
        {
            base.AutoSize = false;
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular);
            base.Size = new Size(100, 20);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!string.IsNullOrEmpty(NextControlName))
                {
                    Control nextControl = this.TopLevelControl.Controls.Find(NextControlName, true)[0];
                    nextControl.Focus();
                }
                base.OnKeyDown(e);
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
