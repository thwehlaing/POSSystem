using BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class ErrorCheck
    {
        BaseBL bbl = new BaseBL();
        public void ShowErrorMessage(string messageID)
        {
            bbl.ShowMessage(messageID);
        }
        public void ShowErrorMessage(string messageID, string par0)
        {
            bbl.ShowMessage(messageID, par0);
        }
        public (bool, DataTable) Check(Control ctrl)
        {
            DataTable dt = new DataTable();
            if (ctrl is PTextBox)
            {
                PTextBox PTextBox = ctrl as PTextBox;
                (bool, DataTable) r_value = TextBoxErrorCheck(PTextBox);
                return r_value;
            }
            if (ctrl is PCombo)
            {
                PCombo pCombo = ctrl as PCombo;
                (bool, DataTable) r_value = ComboErrorCheck(pCombo);
                return r_value;
            }
            //if (ctrl is SCheckBox)
            //{
            //    SCheckBox sCheckBox = ctrl as SCheckBox;
            //    (bool, DataTable) r_value = CheckBoxErrorCheck(sCheckBox);
            //    return r_value;
            //}
            return (false, dt);
        }

        private (bool, DataTable) TextBoxErrorCheck(PTextBox PTextBox)
        {
            DataTable rDt = new DataTable();

            if (PTextBox.E101)
            {
                if (string.IsNullOrWhiteSpace(PTextBox.Text))
                {
                    ShowErrorMessage("E101");
                    PTextBox.Focus();
                    return (true, rDt);
                }
            }
            return (false, rDt);
        }

        private (bool, DataTable) ComboErrorCheck(PCombo pCombo)
        {
            DataTable rDt = new DataTable();

            if (pCombo.E102)
            {
                if (pCombo.SelectedIndex.ToString() == "-1" || pCombo.SelectedIndex.ToString() == "0")
                {
                    ShowErrorMessage("E102");
                    pCombo.Focus();
                    return (true, rDt);
                }
            }
            //if (PCombo.E106)
            //{
            //    if (!string.IsNullOrEmpty(PCombo.ctrlE106_1.Text.ToString()) && !string.IsNullOrEmpty(PCombo.ctrlE106_2.Text.ToString()))
            //    {
            //        bool bl = Matches(PCombo.ctrlE106_2.SelectedValue.ToString(), PCombo.ctrlE106_1.SelectedValue.ToString());
            //        if (!bl)
            //        {
            //            ShowErrorMessage("E106");
            //            PCombo.Focus();
            //            return (true, rDt);
            //        }
            //    }
            //}
            return (false, rDt);
            
        }
    }
}
