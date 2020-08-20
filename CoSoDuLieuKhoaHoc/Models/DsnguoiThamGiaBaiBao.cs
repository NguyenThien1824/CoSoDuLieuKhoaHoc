using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DsnguoiThamGiaBaiBao
    {
        public int MaTt { get; set; }
        public int MaBaiBao { get; set; }
        public int MaNkh { get; set; }
        public bool? LaTacGiaChinh { get; set; }
        public string NhiemVu { get; set; }

        public virtual BaiBao MaBaiBaoNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
