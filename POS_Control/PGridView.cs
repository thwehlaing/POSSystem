using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PGridView:DataGridView
    {
        public void SetGridDesign()
        {
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 255, 255);
            this.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular);
        }
    }
}
