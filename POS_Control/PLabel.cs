using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PLabel:Label
    {
        public PLabel() : base()
        {
            BackColor = Color.FromArgb(255, 230, 153);
            base.AutoSize = false;
            TextAlign = ContentAlignment.MiddleCenter;
            BorderStyle = BorderStyle.FixedSingle;
            FlatStyle = FlatStyle.Flat;
            base.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            base.Size = new Size(100, 19);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        protected override void InitLayout()
        {
            base.InitLayout();
            base.AutoSize = false;
            base.Height = 19;
        }
    }
}
