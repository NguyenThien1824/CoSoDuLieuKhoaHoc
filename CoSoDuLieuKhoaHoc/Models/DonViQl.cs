using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DonViQl
    {
        public DonViQl()
        {
            DeTai = new HashSet<DeTai>();
            NhaKhoaHoc = new HashSet<NhaKhoaHoc>();
        }

        public int MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public string DiaChiCq { get; set; }
        public string DienThoaiCq { get; set; }
        public string EmailCq { get; set; }

        public virtual ICollection<DeTai> DeTai { get; set; }
        public virtual ICollection<NhaKhoaHoc> NhaKhoaHoc { get; set; }
    }
}
