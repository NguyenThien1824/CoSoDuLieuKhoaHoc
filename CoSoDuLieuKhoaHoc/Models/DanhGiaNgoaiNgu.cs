using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DanhGiaNgoaiNgu
    {
        public DanhGiaNgoaiNgu()
        {
            NgoaiNguNkhDocNavigation = new HashSet<NgoaiNguNkh>();
            NgoaiNguNkhNoiNavigation = new HashSet<NgoaiNguNkh>();
            NgoaiNguNkhVietNavigation = new HashSet<NgoaiNguNkh>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<NgoaiNguNkh> NgoaiNguNkhDocNavigation { get; set; }
        public virtual ICollection<NgoaiNguNkh> NgoaiNguNkhNoiNavigation { get; set; }
        public virtual ICollection<NgoaiNguNkh> NgoaiNguNkhVietNavigation { get; set; }
    }
}
