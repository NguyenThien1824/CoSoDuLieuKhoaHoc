using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class ChuyenMon
    {
        public ChuyenMon()
        {
            ChuyenMonNkh = new HashSet<ChuyenMonNkh>();
        }

        public int MaChuyenMon { get; set; }
        public string TenChuyenMon { get; set; }

        public virtual ICollection<ChuyenMonNkh> ChuyenMonNkh { get; set; }
    }
}
