using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DonViChuTri
    {
        public DonViChuTri()
        {
            DeTai = new HashSet<DeTai>();
        }

        public int MaDvchuTri { get; set; }
        public string TenDvchuTri { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<DeTai> DeTai { get; set; }
    }
}
