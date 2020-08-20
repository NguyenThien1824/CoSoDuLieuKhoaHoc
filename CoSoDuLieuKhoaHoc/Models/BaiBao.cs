using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class BaiBao
    {
        public BaiBao()
        {
            DsbaiBaoDeTai = new HashSet<DsbaiBaoDeTai>();
            DsnguoiThamGiaBaiBao = new HashSet<DsnguoiThamGiaBaiBao>();
            LinhVucBaiBao = new HashSet<LinhVucBaiBao>();
        }

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

        public virtual CapTapChi MaCapTapChiNavigation { get; set; }
        public virtual PhanLoaiTapChi MaLoaiTapChiNavigation { get; set; }
        public virtual ICollection<DsbaiBaoDeTai> DsbaiBaoDeTai { get; set; }
        public virtual ICollection<DsnguoiThamGiaBaiBao> DsnguoiThamGiaBaiBao { get; set; }
        public virtual ICollection<LinhVucBaiBao> LinhVucBaiBao { get; set; }
    }
}
