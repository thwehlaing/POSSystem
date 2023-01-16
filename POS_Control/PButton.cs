using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PButton:Button
    {
        public ButtonType.BType ButtonType { get; set; }
        public PButton()
        {
            this.BackColor = ColorTranslator.FromHtml("#BFBFBF");
            this.Font = new Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.FlatStyle = FlatStyle.Popup;
        }
    }
}
