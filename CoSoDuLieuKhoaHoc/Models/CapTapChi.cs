using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class CapTapChi
    {
        public CapTapChi()
        {
            BaiBao = new HashSet<BaiBao>();
        }

        public int MaCapTapChi { get; set; }
        public string TenCapTapChi { get; set; }
        public string DanhMucNhom { get; set; }

        public virtual ICollection<BaiBao> BaiBao { get; set; }
    }
}
