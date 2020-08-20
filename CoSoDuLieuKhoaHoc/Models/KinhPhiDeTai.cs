using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class KinhPhiDeTai
    {
        public int MaPhi { get; set; }
        public int MaDeTai { get; set; }
        public string LoaiKinhPhi { get; set; }
        public DateTime? NamTiepNhan { get; set; }
        public int? SoTien { get; set; }
        public string LoaiTien { get; set; }

        public virtual DeTai MaDeTaiNavigation { get; set; }
    }
}
