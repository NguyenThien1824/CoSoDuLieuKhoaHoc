using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DsnguoiThamGiaDeTai
    {
        public int MaTt { get; set; }
        public int MaDeTai { get; set; }
        public int MaNkh { get; set; }
        public bool? LaChuNhiem { get; set; }
        public string NhiemVu { get; set; }

        public virtual DeTai MaDeTaiNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
