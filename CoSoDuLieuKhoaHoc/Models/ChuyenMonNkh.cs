using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class ChuyenMonNkh
    {
        public int MaNkh { get; set; }
        public int MaChuyenMon { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        public virtual ChuyenMon MaChuyenMonNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
