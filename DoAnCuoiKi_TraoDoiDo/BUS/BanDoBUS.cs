using DoAnCuoiKi_TraoDoiDo;
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
        public bool ThemMatHang(BanDo bd)
        {
            return bdd.ThemMatHang(bd);
        }
        public bool XoaMatHang(BanDo bd)
        {
            return bdd.XoaMatHang(bd);
        }
        public bool SuaMatHang(BanDo bd)
        {
            return bdd.SuaMatHang(bd);

        }
        public void SuaMatHang1(BanDo bd)
        {
            bdd.SuaMatHang1(bd);
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


        public void LoadDanhSach(string a, FlowLayoutPanel fl)
        {
            List<BanDo> bds = new List<BanDo>();
            bds = bdd.LoadDanhSach();
            foreach (BanDo j in bds)
            {
                if (a == "All")
                {
                    UCHienThi ucht = new UCHienThi(j);
                    ucht.Margin = new Padding(8);
                    fl.Controls.Add(ucht);
                }
                if (a == j.Loai_Mat_Hang)
                {
                    UCHienThi ucht = new UCHienThi(j);
                    ucht.Margin = new Padding(8);
                    fl.Controls.Add(ucht);
                }
                if (a == "MaVoucher" && j.Ma_Voucher != "null")
                {
                    UCVoucher ucvc = new UCVoucher(j);
                    ucvc.Margin = new Padding(0, 0, 0, 8);
                    fl.Controls.Add(ucvc);
                }
            }
        }



    }
}
