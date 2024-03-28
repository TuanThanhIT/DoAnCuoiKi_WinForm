using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class XuLyAnh
    {
        private List<string> imagePaths;
        private List<Image> images;
        private int currentIndex;

        public List<string> ImagePaths
        {
            get { return imagePaths; }
            set { imagePaths = value; }
        }
        public List<Image> Images
        {
            get { return images; }
            set { images = value; }
        }

        public void ImageLoad(PictureBox a, System.Windows.Forms.TextBox b)
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
                    a.SizeMode = PictureBoxSizeMode.Zoom;
                    a.Image = images[currentIndex];
                    b.Text = imagePaths[currentIndex];
                }
            }
        }
        public void HienThiAnh(PictureBox a, System.Windows.Forms.TextBox b)
        {
            if (images.Count > 0)
            {
                currentIndex = 0;
                a.SizeMode = PictureBoxSizeMode.Zoom;
                a.Image = images[currentIndex];
                b.Text = imagePaths[currentIndex];
            }

        }
        public void Before(PictureBox a, System.Windows.Forms.TextBox b)
        {
            if (images.Count > 0)
            {
                currentIndex = (currentIndex - 1 + images.Count) % images.Count;
                a.Image = images[currentIndex];
                b.Text = imagePaths[currentIndex];
            }
        }
        public void After(PictureBox a, System.Windows.Forms.TextBox b)
        {
            if (images.Count > 0)
            {
                currentIndex = (currentIndex + 1) % images.Count;
                a.Image = images[currentIndex];
                b.Text = imagePaths[currentIndex];
            }
        }
        public void Rong()
        {
            images = new List<Image>();
            imagePaths = new List<string>();
            currentIndex = -1;
        }
        public void XoaAnhHienTai(PictureBox a, System.Windows.Forms.TextBox b)
        {
            if (currentIndex >= 0 && currentIndex < images.Count)
            {
                images.RemoveAt(currentIndex);
                imagePaths.RemoveAt(currentIndex);

                if (images.Count > 0)
                {
                    currentIndex = Math.Min(currentIndex, images.Count - 1);
                    a.Image = images[currentIndex];
                    b.Text = imagePaths[currentIndex];
                }
                else
                {
                    currentIndex = -1;
                    a.Image = null;
                    b.Text = string.Empty;
                }
            }
        }
    }
}
