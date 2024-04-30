using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class SuKienBUS
    {
        SuKienDAO skd = new SuKienDAO();
        public bool ThemSuKien(SuKien sk)
        {
            return skd.ThemSuKien(sk);
        }
        public bool XoaSuKien(SuKien sk)
        {
            return skd.XoaSuKien(sk);
        }
        public bool SuaSuKien(SuKien sk)
        {
            return skd.SuaSuKien(sk);
        }
        public DataTable Load()
        {
            return skd.Load();
        }
        public void LoadSukien(FlowLayoutPanel fl)
        {
            List<SuKien> suKiens = new List<SuKien>();
            suKiens = skd.LoadAll();
            foreach (SuKien sk in suKiens)
            {
                UCSuKien ucsk = new UCSuKien(sk);
                ucsk.Margin = new Padding(0, 0, 0, 8);
                fl.Controls.Add(ucsk);
            }
        }
    }
}
