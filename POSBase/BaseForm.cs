using BL;
using Entity;
using POS_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;

namespace POSBase
{
    public partial class BaseForm : Form
    {
        protected List<ToolStripMenuItem> MenuItemList { get; set; }
        protected List<ToolStripMenuItem> SubMenuItemList { get; set; }
        BaseBL bbl = new BaseBL();

        #region Login Information
        protected string CompanyCD { get; set; }
        protected string OperatorCD { get; set; }
        protected string PCID { get; set; }
        protected string LoginDate { get; set; }
        #endregion
        protected string ProgramID { get; set; }
        protected string ProgramName { get; set; }

        #region Function Button
        protected PButton F1 { get => BtnF1; set => BtnF1 = value; }
        protected PButton F2 { get => BtnF2; set => BtnF2 = value; }
        #endregion
        public BaseForm()
        {
            InitializeComponent();           
            tspCurrentDate.Text ="Date :"+ DateTime.Now.ToString("dd/MM/yyyy");           
        }
        
        protected void StartProgram()
        {
            BaseTitle.Text = ProgramName;
            string filePath = string.Empty;
            ReadIniFile readIni = new ReadIniFile();
           
            filePath = @"C:\\DBConfig\\DBConfig.ini";
            Dictionary<string, string> dicConfig = readIni.ReadConfig(filePath, "DataBase", "POSDB");
            if (this.GetCmdLine() == false || dicConfig.Count == 0)
            {
                //起動時エラー    DB接続不可能
                this.Close();
                System.Environment.Exit(0);
            }

            BaseBL.IEntity.DatabaseServer = dicConfig["DatabaseServer"];
            BaseBL.IEntity.DatabaseName = dicConfig["DatabaseName"];
            BaseBL.IEntity.DatabaseLoginID = dicConfig["DatabaseLoginID"];
            BaseBL.IEntity.DatabasePassword = dicConfig["DatabasePassword"];


            //StaffEntity staffEntity = new StaffEntity
            //{
            //    StaffCD = OperatorCD
            //};

            ////set LoginName & LoginDate
            //staffEntity = staffBL.GetStaffEntity(staffEntity);
            //sLabel1.Text = staffEntity.StaffName;
            //sLabel2.Text = staffEntity.LoginDate;
            //LoginDate = staffEntity.LoginDate;

            //staffEntity.ProgramID = ProgramID;
            //staffEntity.PC = PCID;
            //programEntity = staffBL.Staff_AccessCheck(staffEntity);
            //if (programEntity == null)
            //{
            //    this.Close();
            //    System.Environment.Exit(0);
            //}
        }
        private bool GetCmdLine()
        {
            string[] cmds = System.Environment.GetCommandLineArgs();

            if (cmds.Length < 4)
                return false;

            CompanyCD = cmds[1];
            OperatorCD = cmds[2];
            PCID = cmds[3];

            if (string.IsNullOrWhiteSpace(CompanyCD)
                || string.IsNullOrWhiteSpace(OperatorCD)
                || string.IsNullOrWhiteSpace(PCID))
                return false;

            return true;
        }

        private void btnFunctionClick(object sender, EventArgs e)
        {
            PButton btn = (PButton)sender;
            FireClickEvent(btn);
        }
        protected void FireClickEvent(PButton btn)
        {
            if (btn.Visible)
            {
                switch (btn.ButtonType)
                {
                    case ButtonType.BType.Close:
                        //if (bbl.ShowMessage("Q003") == DialogResult.Yes)
                        //{
                        //    BaseEntity be = new BaseEntity();
                        //    be.OperatorCD = OperatorCD;
                        //    be.ProgramID = ProgramID;
                        //    be.PC = PCID;
                        //    bbl.D_Exclusive_Number_Remove(be);
                        //    this.Close();
                        //}
                        //else
                        //{
                        //    if (PreviousCtrl != null)
                        //        PreviousCtrl.Focus();
                        //    return;
                        //}
                        break;
                    //case ButtonType.BType.New:
                    //    FunctionProcess(btn.Tag.ToString());
                    //    break;
                    //case ButtonType.BType.Update:
                    //    if (programEntity.Updatable.Equals("1"))
                    //        SetMode(btn, "2");
                    //    break;
                    //    case ButtonType.BType.Delete:
                    //        if (programEntity.Deletable.Equals("1"))
                    //            SetMode(btn, "3");
                    //        break;
                    //    case ButtonType.BType.Inquiry:
                    //        if (programEntity.Inquirable.Equals("1"))
                    //            SetMode(btn, "4");
                    //        break;
                    //    case ButtonType.BType.Cancel:
                    //        if (bbl.ShowMessage("Q004") != DialogResult.Yes)
                    //        {
                    //            //cboMode.Enabled = false;
                    //            if (PreviousCtrl != null)
                    //                PreviousCtrl.Focus();
                    //        }
                    //        else
                    //        {
                    //            //cboMode.Enabled = true;
                    //            FunctionProcess(btn.Tag.ToString());
                    //        }
                    //        break;
                    //    case ButtonType.BType.Import:
                    //        FunctionProcess(btn.Tag.ToString());
                    //        break;
                    //    case ButtonType.BType.Confirm:
                    //        FunctionProcess(btn.Tag.ToString());
                    //        break;
                    //    case ButtonType.BType.Display:
                    //        FunctionProcess(btn.Tag.ToString());
                    //        break;
                    //    case ButtonType.BType.Memory:
                    //        FunctionProcess(btn.Tag.ToString());
                    //        break;
                    case ButtonType.BType.Save:
                        FunctionProcess(btn.Tag.ToString());
                        break;
                        //        if (cboMode.SelectedValue == null)
                        //        {
                        //            if (bbl.ShowMessage("Q101") != DialogResult.Yes)
                        //            {
                        //                //cboMode.Enabled = false;
                        //                if (PreviousCtrl != null)
                        //                    PreviousCtrl.Focus();
                        //            }
                        //            else
                        //            {
                        //                //cboMode.Enabled = true;
                        //                FunctionProcess(btn.Tag.ToString());
                        //            }
                        //        }
                        //        else if (cboMode.SelectedValue.ToString() == "1" || cboMode.SelectedValue.ToString() == "2")
                        //        {
                        //            if (ErrorCheck(PanelTitle) && ErrorCheck(this.Controls.Find("PanelDetail", true)[0] as Panel))
                        //            {
                        //                if (bbl.ShowMessage("Q101") != DialogResult.Yes)
                        //                {
                        //                    //cboMode.Enabled = false;
                        //                    if (PreviousCtrl != null)
                        //                        PreviousCtrl.Focus();
                        //                }
                        //                else
                        //                {
                        //                    //cboMode.Enabled = true;
                        //                    FunctionProcess(btn.Tag.ToString());
                        //                }
                        //            }
                        //        }
                        //        else if (cboMode.SelectedValue.ToString() == "3")
                        //        {
                        //            if (bbl.ShowMessage("Q102") != DialogResult.Yes)
                        //            {
                        //                //cboMode.Enabled = false;
                        //                if (PreviousCtrl != null)
                        //                    PreviousCtrl.Focus();
                        //            }
                        //            else
                        //            {
                        //                //cboMode.Enabled = true;
                        //                FunctionProcess(btn.Tag.ToString());
                        //            }
                        //        }
                        //        break;
                        //    case ButtonType.BType.Process:
                        //        if (bbl.ShowMessage("Q002") != DialogResult.Yes)
                        //        {
                        //            if (PreviousCtrl != null)
                        //                PreviousCtrl.Focus();
                        //        }
                        //        else
                        //            FunctionProcess(btn.Tag.ToString());
                        //        break;
                        //    case ButtonType.BType.ExcelExport:
                        //        if (ErrorCheck(this.Controls.Find("PanelDetail", true)[0] as Panel))
                        //        {
                        //            if (bbl.ShowMessage("Q205") != DialogResult.Yes)
                        //            {
                        //                if (PreviousCtrl != null)
                        //                    PreviousCtrl.Focus();
                        //            }
                        //            else
                        //                FunctionProcess(btn.Tag.ToString());
                        //        }
                        //        break;
                        //    case ButtonType.BType.CSVExport:
                        //        if (ErrorCheck(this.Controls.Find("PanelDetail", true)[0] as Panel))
                        //        {
                        //            if (bbl.ShowMessage("Q203") != DialogResult.Yes)
                        //            {
                        //                if (PreviousCtrl != null)
                        //                    PreviousCtrl.Focus();
                        //            }
                        //            else
                        //                FunctionProcess(btn.Tag.ToString());
                        //        }
                        //        break;
                }
            }
        }

        public virtual void FunctionProcess(string tagID)
        {
            //MessageBox.Show("Go");
        }

        protected void SetButton(ButtonType.BType buttonType, PButton button, string buttonText, bool visible)
        {
            button.ButtonType = buttonType;
            switch (buttonType)
            {
            //     New,
            //Update,
            //Delete,
            //Save,
            //Cancel,
            //Close, 
            //Display
                case ButtonType.BType.New:
                    button.Text = buttonText;
                    break;
                case ButtonType.BType.Update:
                    button.Text = buttonText;
                    break;
                case ButtonType.BType.Delete:
                    button.Text = buttonText;
                    break;
                case ButtonType.BType.Save:
                    button.Text = buttonText;
                    break;
                case ButtonType.BType.Close:
                    button.Text = buttonText;
                    break;
                case ButtonType.BType.Display:
                    button.Text = buttonText;
                    break;
            }

            button.Visible = visible;
        }

        protected bool ErrorCheck(Panel panel)
        {
            Dictionary<int, Control> dic = new Dictionary<int, Control>();

            foreach (Control ctrl in panel.Controls)
            {
                if (!(ctrl is Label))
                    dic.Add(ctrl.TabIndex, ctrl);
            }


            foreach (KeyValuePair<int, Control> ctrldic in dic.OrderBy(key => key.Key))
            {
                Control ctrl = ctrldic.Value as Control;

                if ((ctrl is PTextBox))
                {
                    PTextBox st = ctrl as PTextBox;
                    if (st.ErrorCheck())
                        return false;
                }
                if (ctrl is PCombo)
                {
                    PCombo sc = ctrl as PCombo;
                    if (sc.ErrorCheck())
                        return false;
                }
                if (ctrl is PCheckBox)
                {
                    PCheckBox sch = ctrl as PCheckBox;
                    if (sch.ErrorCheck())
                        return false;
                }
            }
            return true;
        }
    }
}
