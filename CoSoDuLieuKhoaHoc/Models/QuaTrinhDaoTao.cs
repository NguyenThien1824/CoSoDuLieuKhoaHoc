using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class QuaTrinhDaoTao
    {
        public int MaQt { get; set; }
        public int MaNkh { get; set; }
        public DateTime? ThoiGianBd { get; set; }
        public DateTime? ThoiGianKt { get; set; }
        public int? MaHocVi { get; set; }
        public string CoSoDaoTao { get; set; }
        public int? MaNganh { get; set; }

        public virtual HocVi MaHocViNavigation { get; set; }
        public virtual NganhDaoTao MaNganhNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
