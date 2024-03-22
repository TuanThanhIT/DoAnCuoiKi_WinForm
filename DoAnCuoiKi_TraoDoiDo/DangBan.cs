using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormDangBan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FormDangBan()
        {
            InitializeComponent();
        }
        FormTrangChu mainForm;
        public void OpenChildForm(Form childForm)
        {
            mainForm = this.ParentForm as FormTrangChu;

            if (mainForm != null)
            {
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.panelTrangChu.Controls.Clear();
                mainForm.panelTrangChu.Controls.Add(childForm);
                childForm.Show();
            }
        }

        private void btnDangbanThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanDo());
        }

        private void btnDbQuaylai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanDo());
        }

        private void btnDbChinhsua_Click(object sender, EventArgs e)
        {

        }

        private void FormDangBan_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ĐăngBán", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu trong DataGridView
                gvDangban.DataSource = dataTable;

                // Để hiển thị cột ảnh, bạn cần tạo một cột DataGridViewImageColumn cho cột ảnh trong DataGridView
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "Hình ảnh";
                imageColumn.HeaderText = "Hình ảnh";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Có thể thay đổi kiểu hiển thị ảnh tùy ý
                gvDangban.Columns.Add(imageColumn);

                // Thiết lập dữ liệu cho cột ảnh
                foreach (DataGridViewRow row in gvDangban.Rows)
                {
                    byte[] imageData = (byte[])row.Cells["Hình_ảnh"].Value;
                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            row.Cells["Hình ảnh"].Value = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
