using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class BUS
    {
        public string RandomMa(int doDai)
        {
            const string kyTuDung = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Tạo một HashSet để lưu trữ các mã sản phẩm đã được sử dụng
            HashSet<string> maSanPhamDaSuDung = new HashSet<string>();

            // Tạo một đối tượng Random
            Random random = new Random();

            // Tạo lặp cho đến khi tạo được mã sản phẩm mới
            while (true)
            {
                // Tạo một StringBuilder để xây dựng mã sản phẩm
                var stringBuilder = new System.Text.StringBuilder();

                // Tạo mã sản phẩm mới
                for (int i = 0; i < doDai; i++)
                {
                    char kyTuNgauNhien = kyTuDung[random.Next(kyTuDung.Length)];
                    stringBuilder.Append(kyTuNgauNhien);
                }

                string maMoi = stringBuilder.ToString();

                // Kiểm tra xem mã sản phẩm đã được sử dụng chưa
                if (!maSanPhamDaSuDung.Contains(maMoi))
                {
                    maSanPhamDaSuDung.Add(maMoi);
                    return maMoi;
                }
            }
        }
    }
}
