using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoSoDuLieuKhoaHoc.ViewModel
{
    public class PhatMinhGiaiPhapViewModel
    {
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
    }
}
