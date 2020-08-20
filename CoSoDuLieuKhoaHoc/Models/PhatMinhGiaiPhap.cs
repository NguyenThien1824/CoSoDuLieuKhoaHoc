using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class PhatMinhGiaiPhap
    {
        public PhatMinhGiaiPhap()
        {
            DsphatMinhNkh = new HashSet<DsphatMinhNkh>();
        }

        public int MaPm { get; set; }
        public string TenPm { get; set; }
        public string SoHieuPm { get; set; }
        public string MotaPm { get; set; }
        public string DoiTuongSuDung { get; set; }
        public string QuocGiaCap { get; set; }
        public string LinkLienKet { get; set; }
        public byte[] AnhScanGiayChungNhan { get; set; }
        public byte[] AnhChupSanPham1 { get; set; }
        public byte[] AnhChupSanPham2 { get; set; }
        public DateTime? NamCongBo { get; set; }

        public virtual ICollection<DsphatMinhNkh> DsphatMinhNkh { get; set; }
    }
}
