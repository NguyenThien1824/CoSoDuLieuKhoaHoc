using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class CapDeTai
    {
        public CapDeTai()
        {
            DeTai = new HashSet<DeTai>();
        }

        public int MaCapDeTai { get; set; }
        public string TenCapDeTai { get; set; }

        public virtual ICollection<DeTai> DeTai { get; set; }
    }
}
