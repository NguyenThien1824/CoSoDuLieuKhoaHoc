using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class PhanLoaiTapChi
    {
        public PhanLoaiTapChi()
        {
            BaiBao = new HashSet<BaiBao>();
        }

        public int MaLoaiTapChi { get; set; }
        public string TenLoaiTapChi { get; set; }

        public virtual ICollection<BaiBao> BaiBao { get; set; }
    }
}
