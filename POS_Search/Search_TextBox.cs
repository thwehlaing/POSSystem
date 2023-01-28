using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Search
{
    public class Search_TextBox:TextBox
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Search();
            }
        }
        public void Search()
        {
           
        }
    }
}
