using BL;
using POS_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Entity.SearchType;

namespace POS_Search
{
    public class Search_TextBox:PTextBox
    {
        BaseBL bl = new BaseBL();
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ErrorCheck();
            }
            if (e.KeyCode == Keys.F9)
            {
                Search();
            }
        }
        public void Search()
        {
            switch (this.SearchType)
            {
                case Entity.SearchType.ScType.Category:

                    Category_Search cate_Search = new Category_Search();
                    cate_Search.ShowDialog();
                    break;
            }
        }
    }
}
