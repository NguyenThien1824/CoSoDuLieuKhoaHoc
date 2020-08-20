using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoSoDuLieuKhoaHoc.ViewModel
{
    public class BaiBaoKhoaHocViewModel
    {
        public int MaBaiBao { get; set; }
        public string MaIssn { get; set; }
        public string TenBaiBao { get; set; }
        public bool? LaTrongNuoc { get; set; }
        public string CqxuatBan { get; set; }
        public int? MaLoaiTapChi { get; set; }
        public int? MaCapTapChi { get; set; }
        public DateTime? NamDangBao { get; set; }
        public string TapPhatHanh { get; set; }
        public string SoPhatHanh { get; set; }
        public string TrangBaiBao { get; set; }
        public string LienKetWeb { get; set; }
        public string LinkFileUpLoad { get; set; }
    }
}
