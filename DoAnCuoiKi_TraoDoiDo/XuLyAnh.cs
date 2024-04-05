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
    public class XuLyAnh
    {
        public static List<string> imagePaths;
        public static List<Image> images;
        public static int currentIndex;

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
        public int CurrentIndex
        {
            get { return currentIndex; }
            set { currentIndex = value; }
        }
    }
}
