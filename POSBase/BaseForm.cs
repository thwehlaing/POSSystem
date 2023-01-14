using BL;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSBase
{
    public partial class BaseForm : Form
    {
        protected List<ToolStripMenuItem> MenuItemList { get; set; }
        protected List<ToolStripMenuItem> SubMenuItemList { get; set; }
        public BaseForm()
        {
            InitializeComponent();
            tspCurrentDate.Text ="Date :"+ DateTime.Now.ToString("dd/MM/yyyy");
            this.MenuItemList = new List<ToolStripMenuItem> { tspSaleMenu, tspPurchaseMenu, tspLedgerMenu, tspReportMenu, tspSettingMenu };
            this.SubMenuItemList = new List<ToolStripMenuItem> { tspSale,tspInvoice,tspDamage,tspPurchase,tspRepackage,tspStockLedger,tspCashLedger,
                                   tspDailyRpt,tspMonthlyRpt,tspYearlyRpt,tspCategory,tspSubCategory,tspStock,tspSupplier,tspUser,tspPackage};
            this.MenuItemList.ForEach(x => x.MouseEnter += this.ChangeMenuColor);
            this.MenuItemList.ForEach(x => x.MouseLeave += this.ChangeBackMenuColor);
            this.SubMenuItemList.ForEach(x => x.Click += this.MenuItem_Click);
        }
        private void ChangeMenuColor(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Black;
        }
        private void ChangeBackMenuColor(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Black;
        }

        protected virtual void MenuItem_Click(object sender, EventArgs e)
        {

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
