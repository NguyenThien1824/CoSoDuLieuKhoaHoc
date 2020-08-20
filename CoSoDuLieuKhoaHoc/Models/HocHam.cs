using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class HocHam
    {
        public HocHam()
        {
            NhaKhoaHoc = new HashSet<NhaKhoaHoc>();
        }

        public int MaHocHam { get; set; }
        public string TenVietTat { get; set; }
        public string TenHocHam { get; set; }

        public virtual ICollection<NhaKhoaHoc> NhaKhoaHoc { get; set; }
    }
}
