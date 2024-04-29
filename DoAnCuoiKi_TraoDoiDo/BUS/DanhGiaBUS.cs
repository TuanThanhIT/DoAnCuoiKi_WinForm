using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class DanhGiaBUS
    {
        DanhGiaDAO dgd = new DanhGiaDAO();
        public bool ThemDanhGia(DanhGia dg)
        {
            return dgd.ThemDanhGia(dg);
        }
        public void LoadDanhGia(FlowLayoutPanel fl, string masanpham)
        {
            List<DanhGia> dgs = new List<DanhGia>();
            dgs = dgd.LoadDanhGia(masanpham);
            foreach (DanhGia j in dgs)
            {
                UCDanhGia ucgh = new UCDanhGia(j);
                ucgh.Margin = new Padding(0, 0, 0, 8);
                fl.Controls.Add(ucgh);
            }
        }
    }
}
