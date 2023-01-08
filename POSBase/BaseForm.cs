using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSBase
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            tspCurrentDate.Text ="Date :"+ DateTime.Now.ToString("dd/MM/yyyy");
            tspSaleMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspSaleMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspPurchaseMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspPurchaseMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspLedgerMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspLedgerMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspReportMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspReportMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspSettingMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspSettingMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
        }

        private void tspSaleMenu_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void tspSaleMenu_DropDownOpened(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void tspSaleMenu_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Black;
        }

        private void tspSaleMenu_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.White;
        }
        private void ChangeMenuColor(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Black;
        }
        private void ChangeBackMenuColor(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.White;
        }
        protected void StartProgram()
        {
            string filePath = string.Empty;
            ReadIniFile readIni = new ReadIniFile();
            //if (Debugger.IsAttached)
            //{
            //    System.Uri u = new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            //    filePath = System.IO.Path.GetDirectoryName(u.LocalPath) + @"\" + "DBConfig.ini";
            //}
            //else
            //{
                filePath = @"C:\\DBConfig\\DBConfig.ini";
           // }
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
    }
}
