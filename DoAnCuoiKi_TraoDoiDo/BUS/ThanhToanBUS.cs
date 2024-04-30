using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class ThanhToanBUS
    {
        ThanhToanDAO ttd = new ThanhToanDAO();
        public void LoadDS(FlowLayoutPanel fl)
        {
            List<ThanhToan> listtt = new List<ThanhToan>();
            listtt = ttd.LoadDanhSach();
            foreach (ThanhToan j in listtt)
            {
                UCThanhToan uctt = new UCThanhToan(j);
                uctt.Margin = new Padding(0, 0, 0, 8);
                fl.Controls.Add(uctt);
            }
        }

        public void HienThiSuKien(DateTimePicker dt, Label lb)
        {

            foreach (SuKien s in SuKienDAO.suKienList)
            {
                string startTimeString = s.BatDau;
                string endTimeString = s.KetThuc;
                string targetTimeString = dt.Value.ToString();

                DateTime startTime;
                DateTime endTime;
                DateTime targetTime;

                if (DateTime.TryParseExact(startTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime) &&
                    DateTime.TryParseExact(endTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime) &&
                    DateTime.TryParseExact(targetTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out targetTime))
                {
                    if (targetTime > startTime && targetTime < endTime)
                    {
                        lb.Text = s.GiamGia;
                    }
                    else
                    {
                        lb.Text = "Không có";
                    }
                }



            }
        }
        public void ThemThanhToan(ThanhToan tt)
        {
            ttd.themThanhToan(tt);
        }
        public void XoaThanhToan()
        {
            ttd.xoaThanhToan();
        }
        public void SuaThanhToan(ThanhToan tt)
        {
            ttd.SuaThanhToan(tt);
        }
        public string TinhTienHang()
        {
            string tienhang;
            tienhang = ttd.TinhTienHang();
            return tienhang;
        }
        public double tinhTienMa(string soluong, string gianban, string magiamgia)
        {
            int quantity;
            double price;
            double giamgia;
            double thanhtoanhang;
            if (int.TryParse(soluong, out quantity) && double.TryParse(gianban, out price) && double.TryParse(magiamgia, out giamgia))
            {
                thanhtoanhang = quantity * price - quantity * price * (giamgia / 100);

            }
            else
            {
                thanhtoanhang = 0;
            }
            return thanhtoanhang;
        }
        public double tinhTien(string soluong, string giaban)
        {
            int quantity;
            double price;
            double thanhtoanhang;
            if (int.TryParse(soluong, out quantity) && double.TryParse(giaban, out price))
            {
                thanhtoanhang = quantity * price;
            }
            else
            {
                thanhtoanhang = 0;
            }
            return thanhtoanhang;
        }
    }
}
