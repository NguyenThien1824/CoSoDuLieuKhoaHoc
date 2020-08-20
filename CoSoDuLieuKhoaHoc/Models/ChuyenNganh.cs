using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class ChuyenNganh
    {
        public ChuyenNganh()
        {
            NhaKhoaHoc = new HashSet<NhaKhoaHoc>();
        }

        public int MaChuyenNganh { get; set; }
        public string TenChuyenNganh { get; set; }
        public int? MaNganhDaoTao { get; set; }

        public virtual NganhDaoTao MaNganhDaoTaoNavigation { get; set; }
        public virtual ICollection<NhaKhoaHoc> NhaKhoaHoc { get; set; }
    }
}
