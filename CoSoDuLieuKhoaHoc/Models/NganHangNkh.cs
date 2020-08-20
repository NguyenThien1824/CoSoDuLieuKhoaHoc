using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NganHangNkh
    {
        public int MaNkh { get; set; }
        public string Stknh { get; set; }
        public int? MaNh { get; set; }
        public string ChiNhanhNh { get; set; }
        public string GhiChu { get; set; }

        public virtual NganHang MaNhNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
