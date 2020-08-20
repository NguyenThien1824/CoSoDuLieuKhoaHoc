using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DstacGia
    {
        public int MaTt { get; set; }
        public int MaSach { get; set; }
        public int MaNkh { get; set; }
        public bool? LaChuBien { get; set; }
        public string PhanCong { get; set; }

        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
        public virtual SachGiaoTrinh MaSachNavigation { get; set; }
    }
}
