using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DTO
{
    public class MuaHangReport
    {
        public string ID {  get; set; } 
        public string Họ_tên_người_mua { get; set; }
        public string Số_điện_thoại { get; set; }   
        public string Địa_chỉ { get; set; }
        public string Ngày_mua_hàng { get; set; }
        public string Tổng_thanh_toán {  get; set; }
        public string Mã_giao_dịch { get; set; }
    }
}
