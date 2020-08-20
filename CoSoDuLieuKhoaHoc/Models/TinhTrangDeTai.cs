using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class TinhTrangDeTai
    {
        public TinhTrangDeTai()
        {
            DeTai = new HashSet<DeTai>();
        }

        public int MaTinhTrang { get; set; }
        public string TenTinhTrang { get; set; }

        public virtual ICollection<DeTai> DeTai { get; set; }
    }
}
