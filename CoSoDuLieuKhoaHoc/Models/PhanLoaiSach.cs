using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class PhanLoaiSach
    {
        public PhanLoaiSach()
        {
            SachGiaoTrinh = new HashSet<SachGiaoTrinh>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<SachGiaoTrinh> SachGiaoTrinh { get; set; }
    }
}
