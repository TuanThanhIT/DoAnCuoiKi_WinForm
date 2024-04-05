using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormSuKien : Form
    {
        SuKienDao sdk = new SuKienDao();
        public FormSuKien()
        {
            InitializeComponent();
        }

        private void FormSuKien_Load(object sender, EventArgs e)
        {
            DataTable a = sdk.Load();
            gvSKsukien.DataSource = a;
        }

        private void btnSKThem_Click(object sender, EventArgs e)
        {
            SuKien sk = new SuKien(txtSKTen.Text, txtSKGiamgia.Text, dateTimeSKbatdau.Value.ToString(), dateTimeSKKetthuc.Value.ToString());
            sdk.themSuKien(sk);
            FormSuKien_Load(sender, e);
        }

        private void btnSKXoa_Click(object sender, EventArgs e)
        {
            SuKien sk = new SuKien(txtSKTen.Text, txtSKGiamgia.Text, dateTimeSKbatdau.Value.ToString(), dateTimeSKKetthuc.Value.ToString());
            sdk.xoaSuKien(sk);
            FormSuKien_Load(sender, e);
        }

        private void gvSKsukien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvSKsukien.Rows[e.RowIndex];
                txtSKTen.Text = row.Cells["Tên_sự_kiện"].Value.ToString();
                txtSKGiamgia.Text = row.Cells["Giảm_giá"].Value.ToString();
                string ngayBatDauStr = row.Cells["Bắt_đầu"].Value.ToString();
                DateTime ngayBatDau;
                if (DateTime.TryParse(ngayBatDauStr, out ngayBatDau))
                {
                    dateTimeSKbatdau.Value = ngayBatDau;
                }
                else
                {
                    dateTimeSKbatdau.Value = DateTime.Now;
                }
                string ngayKetThucStr = row.Cells["Kết_thúc"].Value.ToString();
                DateTime ngayKetThuc;
                if (DateTime.TryParse(ngayKetThucStr, out ngayKetThuc))
                {
                    dateTimeSKKetthuc.Value = ngayKetThuc;
                }
                else
                {
                    dateTimeSKKetthuc.Value = DateTime.Now;
                }
            }
        }

        private void btnSKSua_Click(object sender, EventArgs e)
        {
            SuKien sk = new SuKien(txtSKTen.Text, txtSKGiamgia.Text, dateTimeSKbatdau.Value.ToString(), dateTimeSKKetthuc.Value.ToString());
            sdk.suaSuKien(sk);
            FormSuKien_Load(sender, e);
        }

    }
}
