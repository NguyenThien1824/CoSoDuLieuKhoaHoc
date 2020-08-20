using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NganHang
    {
        public NganHang()
        {
            NganHangNkh = new HashSet<NganHangNkh>();
        }

        public int MaNh { get; set; }
        public string TenNh { get; set; }
        public string TenTiengAnh { get; set; }
        public string TenVietTat { get; set; }
        public string Website { get; set; }

        public virtual ICollection<NganHangNkh> NganHangNkh { get; set; }
    }
}
