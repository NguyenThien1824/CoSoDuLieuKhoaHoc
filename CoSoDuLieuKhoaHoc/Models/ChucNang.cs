using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class ChucNang
    {
        public ChucNang()
        {
            NguoiDung = new HashSet<NguoiDung>();
        }

        public int MaChucNang { get; set; }
        public string TenChucNang { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
    }
}
