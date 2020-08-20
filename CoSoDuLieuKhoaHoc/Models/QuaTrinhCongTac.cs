using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class QuaTrinhCongTac
    {
        public int MaCt { get; set; }
        public int MaNkh { get; set; }
        public DateTime? ThoiGianBd { get; set; }
        public DateTime? ThoiGianKt { get; set; }
        public string TenCoQuan { get; set; }
        public string TenPhongBan { get; set; }
        public string DiaChiQoQuan { get; set; }
        public string TinhTp { get; set; }
        public string ChucVuCt { get; set; }

        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
