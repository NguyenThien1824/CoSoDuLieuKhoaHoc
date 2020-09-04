using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoSoDuLieuKhoaHoc.ViewModel
{
    public class BaiBaoSearchViewModel
    {
        public string MaIssn { get; set; }
        public int MaBaiBao { get; set; }
        public string TenBaiBao { get; set; }
        public int MaLinhVuc { get; set; }
        public string TenLinhVuc { get; set; }
        public int MaLoaiTapChi { get; set; }
        public string TenLoaiTapChi { get; set; }
        public string CQXuatBan { get; set; }
        public int MaPhanLoaiTapChi { get; set; }
        public string TenPhanLoaiTapChi { get; set; }
        public int MaCapTapChi { get; set; }
        public string TenCapTapChi { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public string SearchValue { get; set; }
        public string TacGia { get; set; }

    }
}
