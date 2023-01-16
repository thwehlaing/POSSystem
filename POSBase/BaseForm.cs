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

        #region Function Button
        protected PButton F1 { get => BtnF1; set => BtnF1 = value; }
        protected PButton F2 { get => BtnF2; set => BtnF2 = value; }
        protected PButton F3 { get => BtnF3; set => BtnF3 = value; }
        protected PButton F4 { get => BtnF4; set => BtnF4 = value; }
        protected PButton F5 { get => BtnF5; set => BtnF5 = value; }
        protected PButton F6 { get => BtnF6; set => BtnF6 = value; }
        protected PButton F7 { get => BtnF7; set => BtnF7 = value; }
        protected PButton F8 { get => BtnF8; set => BtnF8 = value; }
        protected PButton F9 { get => BtnF9; set => BtnF9 = value; }
        protected PButton F10 { get => BtnF10; set => BtnF10 = value; }
        protected PButton F11 { get => BtnF11; set => BtnF11 = value; }
        protected PButton F12 { get => BtnF12; set => BtnF12 = value; }
        #endregion
        public BaseForm()
        {
            InitializeComponent();
            tspCurrentDate.Text ="Date :"+ DateTime.Now.ToString("dd/MM/yyyy");           
        }
        
        protected void StartProgram()
        {
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

            //if (cmds.Length < 4)
            //    return false;

            //CompanyCD = cmds[1];
            //OperatorCD = cmds[2];
            //PCID = cmds[3];

            //if (string.IsNullOrWhiteSpace(CompanyCD)
            //    || string.IsNullOrWhiteSpace(OperatorCD)
            //    || string.IsNullOrWhiteSpace(PCID))
            //    return false;

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
                //    case ButtonType.BType.Close:
                //        if (bbl.ShowMessage("Q003") == DialogResult.Yes)
                //        {
                //            BaseEntity be = new BaseEntity();
                //            be.OperatorCD = OperatorCD;
                //            be.ProgramID = ProgramID;
                //            be.PC = PCID;
                //            bbl.D_Exclusive_Number_Remove(be);
                //            this.Close();
                //        }
                //        else
                //        {
                //            if (PreviousCtrl != null)
                //                PreviousCtrl.Focus();
                //            return;
                //        }
                //        break;
                //    case ButtonType.BType.New:
                //        if (programEntity.Insertable.Equals("1"))
                //            SetMode(btn, "1");
                //        break;
                //    case ButtonType.BType.Update:
                //        if (programEntity.Updatable.Equals("1"))
                //            SetMode(btn, "2");
                //        break;
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
                //    case ButtonType.BType.Save:
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
    }
}
