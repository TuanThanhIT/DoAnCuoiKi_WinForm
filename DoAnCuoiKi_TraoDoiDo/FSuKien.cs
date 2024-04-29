using DoAnCuoiKi_TraoDoiDo.BUS;
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
        SuKienBUS skb = new SuKienBUS();
        public FormSuKien()
        {
            InitializeComponent();
        }

        private void FormSuKien_Load(object sender, EventArgs e)
        {
            DataTable a = skb.Load();
            gvSKsukien.DataSource = a;
        }




        private void btnSkThem_Click(object sender, EventArgs e)
        {
            SuKien sk = new SuKien(txtSKTen.Text, txtSKGiamgia.Text, dateTimeSKbatdau.Value.ToString(), dateTimeSKKetthuc.Value.ToString());
            if (skb.ThemSuKien(sk) == true)
            {
                MessageBox.Show("Tạo sự kiện thành công");
                FormSuKien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Tạo sự kiện thất bại");
                MessageBox.Show("Tạo sự kiện thất bại");
            }
        }

        private void btnSkXoa_Click(object sender, EventArgs e)
        {
            SuKien sk = new SuKien(txtSKTen.Text);
            if (skb.XoaSuKien(sk))
            {
                MessageBox.Show("Gỡ sự kiện thành công");
                FormSuKien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa sự kiện thất bại");
            }
        }

        private void btnSkSua_Click(object sender, EventArgs e)
        {
            SuKien sk = new SuKien(txtSKTen.Text, txtSKGiamgia.Text, dateTimeSKbatdau.Value.ToString(), dateTimeSKKetthuc.Value.ToString());
            if (skb.SuaSuKien(sk))
            {
                MessageBox.Show("Sửa sự kiện thành công");
                FormSuKien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa sự kiện thất bại");
            }
        }


        private void gvSKsukien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvSKsukien.Rows[e.RowIndex];
                txtSKTen.Text = row.Cells["Sự kiện"].Value.ToString();
                txtSKGiamgia.Text = row.Cells["Giảm giá (%)"].Value.ToString();
                string ngayBatDauStr = row.Cells["Bắt đầu"].Value.ToString();
                DateTime ngayBatDau;
                if (DateTime.TryParse(ngayBatDauStr, out ngayBatDau))
                {
                    dateTimeSKbatdau.Value = ngayBatDau;
                }
                else
                {
                    dateTimeSKbatdau.Value = DateTime.Now;
                }
                string ngayKetThucStr = row.Cells["Kết thúc"].Value.ToString();
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
    }
}
