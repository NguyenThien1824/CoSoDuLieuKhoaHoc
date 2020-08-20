using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class PhanLoaiSp
    {
        public PhanLoaiSp()
        {
            DeTai = new HashSet<DeTai>();
        }

        public int MaPhanLoai { get; set; }
        public string TenPhanLoai { get; set; }

        public virtual ICollection<DeTai> DeTai { get; set; }
    }
}
