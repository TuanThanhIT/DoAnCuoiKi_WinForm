using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class BanDoBUS
    {
        BanDoDAO bdd = new BanDoDAO();
        public static bool checkButton;
        BUS bus = new BUS();
        private List<string> imagePaths;
        private List<Image> images;
        private int currentIndex;

        public BanDoBUS()
        {
            imagePaths = new List<string>();
            images = new List<Image>();
            currentIndex = -1;
        }
        public List<string> ImagePaths
        {
            get { return imagePaths; }
            set { imagePaths = value; }
        }


        public int CurrentIndex
        {
            get { return currentIndex; }
            set { currentIndex = value; }
        }
        public List<Image> Images
        {
            get { return images; }
            set { images = value; }
        }



        public DataTable DanhSachDangBan()
        {
            return bdd.DanhSachDangBan();
        }
        public DataTable LoadLSBanDo() 
        {
            return bdd.DanhSachLSBanDo();
        }
        public DataTable LoadTKBanDo()
        {
            return bdd.DanhSachTKBanDo();   
        }
        public bool ThemMatHang(BanDo bd)
        {
            return bdd.ThemMatHang(bd);
        }
        public bool XoaMatHang(BanDo bd)
        {
            return bdd.XoaMatHang(bd);
        }
        public bool XoaLSBanHang()
        {
            return bdd.XoaLSBanHang();
        }
        public bool SuaMatHang(BanDo bd)
        {
            return bdd.SuaMatHang(bd);

        }
        public void SuaMatHang1(BanDo bd)
        {
            bdd.SuaMatHang1(bd);
        }
       
        public List<BanHangReport> LoadDSBanHang(string check) // Đưa tất cả thông tin các mặt hàng đăng bán vào list
        {
            List<BanDo> listBanDo = new List<BanDo>();
            if(check == "T")
            {
                listBanDo = bdd.LoadTKBanHang();
            }
            else
            {
                listBanDo = bdd.LoadBaoCaoBanHang();
            }
            List<BanHangReport> listReport = new List<BanHangReport>();
            foreach (BanDo mh in listBanDo)
            {
                BanHangReport temp = new BanHangReport();
                temp.ID = mh.ID;
                temp.Mã_sản_phẩm = mh.Mã_sản_phẩm;
                temp.Tên_mặt_hàng = mh.Tên_mặt_hàng;
                temp.Loại_mặt_hàng = mh.Loại_mặt_hàng;
                temp.Giá_gốc = mh.Giá_gốc;
                temp.Giá_bán = mh.Giá_bán;
                temp.Mô_tả_mặt_hàng = mh.Mô_tả_mặt_hàng;
                temp.Mã_Voucher = mh.Mã_Voucher;
                temp.Giảm_giá = mh.Giảm_giá;
                temp.Số_lượng_Voucher = mh.Số_lượng_Voucher;
                temp.Số_lượng = mh.Số_lượng;
                temp.Địa_điểm = mh.Địa_điểm;
                temp.Phương_thức_giao_hàng = mh.Phương_thức_giao_hàng;
                temp.Tình_trạng_mặt_hàng = mh.Tình_trạng_mặt_hàng;
                temp.Ngày_đăng_bán = mh.Ngày_đăng_bán;

                listReport.Add(temp);
            }
            return listReport;  
        }
        public string ptGiaoHang(RadioButton rad1, RadioButton rad2, RadioButton rad3)
        {
            string deliveryMethod = string.Empty;
            if (rad1.Checked)
            {
                deliveryMethod = rad1.Text;
            }
            else if (rad2.Checked)
            {
                deliveryMethod = rad2.Text;
            }
            else if (rad3.Checked)
            {
                deliveryMethod = rad3.Text;
            }
            return deliveryMethod;
        }
        public void ptGiaoHang2(RadioButton rad1, RadioButton rad2, RadioButton rad3, string giaohang)
        {
            if (giaohang.Equals("Chuyen phat nhanh"))
            {
                rad1.Checked = true;
            }
            else if (giaohang.Equals("Giao hang boi nguoi ban"))
            {
                rad2.Checked = true;
            }
            else
            {
                rad3.Checked = false;
            }
        }
        public void ngayDangBan(DateTimePicker ngayDangBan, string ngayDangBanStr)
        {
            string format = "dd/MM/yyyy"; // Định dạng ngày tháng mong muốn

            DateTime ngayDangBanDateTime;
            bool isValidDateTime = DateTime.TryParseExact(ngayDangBanStr, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDangBanDateTime);

            if (isValidDateTime)
            {
                ngayDangBan.Value = ngayDangBanDateTime;
            }
            else
            {
                ngayDangBan.Value = DateTime.Now;
            }
        }
        public string RandomMaSanPham()
        {
            return bus.RandomMa(5);
        }
        public void LoadImage(PictureBox picIma, TextBox txtImaPath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    Image image = Image.FromFile(fileName);
                    images.Add(image);
                    imagePaths.Add(fileName);
                }

                if (images.Count > 0)
                {
                    currentIndex = 0;
                    picIma.SizeMode = PictureBoxSizeMode.Zoom;
                    picIma.Image = images[currentIndex];
                    txtImaPath.Text = imagePaths[currentIndex];
                }
            }
        }
        public void LoadImage2(PictureBox picIma, TextBox txtImaPath, List<string> imagePathss)
        {
            foreach (string imagePath in imagePathss)
            {
                Image image = Image.FromFile(imagePath);
                images.Add(image);
                imagePaths.Add(imagePath);
            }
            if (images.Count > 0)
            {
                currentIndex = 0;
                picIma.SizeMode = PictureBoxSizeMode.Zoom;
                picIma.Image = images[currentIndex];
                txtImaPath.Text = imagePathss[currentIndex];
            }
        }
        public void DeleteImage(PictureBox picIma, TextBox txtImaPath)
        {
            if (currentIndex >= 0 && currentIndex < images.Count)
            {
                images.RemoveAt(currentIndex);
                imagePaths.RemoveAt(currentIndex);

                if (images.Count > 0)
                {
                    currentIndex = Math.Min(currentIndex, images.Count - 1);
                    picIma.Image = images[currentIndex];
                    txtImaPath.Text = imagePaths[currentIndex];
                }
                else
                {
                    currentIndex = -1;
                    picIma.Image = null;
                    txtImaPath.Text = string.Empty;
                }
            }
        }
        public void ImageBefore(PictureBox picIma, TextBox txtImaPath)
        {
            if (images.Count > 0)
            {
                currentIndex = (currentIndex - 1 + images.Count) % images.Count;
                picIma.Image = images[currentIndex];
                txtImaPath.Text = imagePaths[currentIndex];
            }
        }
        public void ImageAfter(PictureBox picIma, TextBox txtImaPath)
        {
            if (images.Count > 0)
            {
                currentIndex = (currentIndex + 1) % images.Count;
                picIma.Image = images[currentIndex];
                txtImaPath.Text = imagePaths[currentIndex];
            }
        }


        public void LoadDanhSach(string a, FlowLayoutPanel fl, TextBox tk) 
        {
            List<BanDo> bds = bdd.LoadDanhSach();
            fl.Controls.Clear(); // Xóa các controls cũ trên flow layout

            string tuKhoa = tk.Text.ToLower(); // Chuyển đổi tìm kiếm về chữ thường

            foreach (BanDo j in bds)
            {
                if (a == "All")
                {
                    string tenMatHang = j.Tên_mặt_hàng.ToLower(); // Chuyển đổi tên mặt hàng về chữ thường

                    if (string.IsNullOrEmpty(tuKhoa) || tenMatHang.Contains(tuKhoa))
                    {
                        UCHienThi ucht = new UCHienThi(j);
                        ucht.Margin = new Padding(8);
                        fl.Controls.Add(ucht);
                    }
                }
                if(a == j.Loại_mặt_hàng)
                {
                    string tenMatHang = j.Tên_mặt_hàng.ToLower(); // Chuyển đổi tên mặt hàng về chữ thường

                    if (string.IsNullOrEmpty(tuKhoa) || tenMatHang.Contains(tuKhoa))
                    {
                        UCHienThi ucht = new UCHienThi(j);
                        ucht.Margin = new Padding(8);
                        fl.Controls.Add(ucht);
                    }
                }
            }
        }
        public void LoadDSSapXep(string a, FlowLayoutPanel fl, ComboBox cm)
        {
            fl.Controls.Clear(); // Xóa các controls cũ trên flow layout
            List<BanDo> bds = bdd.LoadDanhSach();
            List<BanDo> danhSachSapXep = new List<BanDo>();
            if (cm.Text == "Tên mặt hàng")
            {
                danhSachSapXep = bds.OrderBy(j => j.Tên_mặt_hàng).ToList();
            }
            else if(cm.Text == "Mới nhất")
            {
                danhSachSapXep = bds.OrderByDescending(j => DateTime.Parse(j.Ngày_đăng_bán)).ToList();
            }
            else
            {
                danhSachSapXep = bds.OrderBy(j => float.Parse(j.Giá_bán)).ToList();
            }
            foreach (BanDo j in danhSachSapXep)
            {
                if (a == "All")
                {
                    UCHienThi ucht = new UCHienThi(j);
                    ucht.Margin = new Padding(8);
                    fl.Controls.Add(ucht);
                }
                if(a == j.Loại_mặt_hàng)
                {
                    UCHienThi ucht = new UCHienThi(j);
                    ucht.Margin = new Padding(8);
                    fl.Controls.Add(ucht);
                }
            }
        }

        public void LoadDSVou(FlowLayoutPanel fl, TextBox tk)
        {
            List<BanDo> listVou = bdd.LoadDSVou();
            fl.Controls.Clear(); // Xóa các controls cũ trên flow layout
            string tuKhoa = tk.Text.ToLower(); // Chuyển đổi tìm kiếm về chữ thường
            foreach (BanDo j in listVou)
            {
                string tenMatHang = j.Tên_mặt_hàng.ToLower(); // Chuyển đổi tên mặt hàng về chữ thường
                if (string.IsNullOrEmpty(tuKhoa) || tenMatHang.Contains(tuKhoa))
                {
                    UCVoucher ucVou = new UCVoucher(j);
                    ucVou.Margin = new Padding(8);
                    fl.Controls.Add(ucVou);
                }
            }
        }

    }
}
