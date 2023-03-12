using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;

namespace POS_Search
{
    public partial class PackagingType_Search : Search_Base
    {
        public string PTypeCD = string.Empty;
        public string PTypeName = string.Empty;
        public int PQty = 0;
        public PackagingType_Search()
        {
            InitializeComponent();
            Search_Form_Name = "ထုပ်ပိုးခြင်းအမျိုးအစား";
        }

        private void PackagingType_Search_Load(object sender, EventArgs e)
        {
            txtPackTypeName.Focus();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ယူမည်", true);
            DataGridviewBind();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataGridviewBind();
        }
        private void DataGridviewBind()
        {
            PackagingTypeEntity entity = new PackagingTypeEntity();
            entity.PackTypeName = txtPackTypeName.Text;
            PackagingTypeBL sbl = new PackagingTypeBL();
            dgvPackagingType.Rows.Clear();
            DataTable dt = sbl.PackagingType_Search(entity);
            if (dt.Rows.Count > 0)
                dgvPackagingType.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvPackagingType.Rows[i].Cells["PackTypeCode"].Value = dt.Rows[i]["PackTypeCode"].ToString();
                dgvPackagingType.Rows[i].Cells["PackTypeName"].Value = dt.Rows[i]["PackTypeName"].ToString();
                dgvPackagingType.Rows[i].Cells["UOMQty"].Value = dt.Rows[i]["UOMQty"].ToString();
            }
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                DataGridViewRow row = dgvPackagingType.CurrentRow;
                GetDataGridViewData(row);
            }
            base.FunctionProcess(tagID);
        }
        private void GetDataGridViewData(DataGridViewRow row)
        {
            if (row != null)
            {
                PTypeCD = row.Cells["PackTypeCode"].Value.ToString();
                PTypeName = row.Cells["PackTypeName"].Value.ToString();
                PQty = Convert.ToInt32(row.Cells["UOMQty"].Value.ToString());
            }
            this.Close();
        }

        private void dgvPackagingType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetDataGridViewData(dgvPackagingType.Rows[e.RowIndex]);
            }
        }
    }
}
