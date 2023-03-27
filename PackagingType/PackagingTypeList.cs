using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSBase;
using BL;
using Entity;

namespace PackagingType
{
    public partial class PackagingTypeList : BaseForm
    {
        BaseBL bbl = new BaseBL();
        public PackagingTypeList()
        {
            InitializeComponent();
        }

        private void PackagingTypeList_Load(object sender, EventArgs e)
        {
            ProgramID = "PackagingTypeList";
            ProgramName = "အထုပ်ထုပ်ပိုးခြင်းအမျိုးအစား စာရင်း";
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Display, F2, "ပြမည်", true);
            DBProcess();
        }
        private void DBProcess()
        {
            PackagingTypeBL bl = new PackagingTypeBL();
            dgvPackagingType.Rows.Clear();
            DataTable dt = bl.PackagingType_Select();
            if (dt.Rows.Count > 0)
                dgvPackagingType.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvPackagingType.Rows[i].Cells["PackTypeCode"].Value = dt.Rows[i]["PackTypeCode"].ToString();
                dgvPackagingType.Rows[i].Cells["PackTypeName"].Value = dt.Rows[i]["PackTypeName"].ToString();
                dgvPackagingType.Rows[i].Cells["UOMQty"].Value = dt.Rows[i]["UOMQty"].ToString();
            }
        }

        private void dgvPackagingType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (bbl.ShowMessage("Q004") == DialogResult.Yes)
                {
                    PackagingTypeBL bl = new PackagingTypeBL();
                    PackagingTypeEntity obj = new PackagingTypeEntity();
                    obj.PackTypeCode = dgvPackagingType.Rows[e.RowIndex].Cells["PackTypeCode"].Value.ToString();
                    obj.UpdatedUser = obj.OperatorCD;
                    bool return_Bl = bl.PackagingType_Delete(obj);
                    if (return_Bl)
                    {
                        dgvPackagingType.Rows.RemoveAt(e.RowIndex);
                        bbl.ShowMessage("I102");
                    }
                }
            }
        }
    }
}
