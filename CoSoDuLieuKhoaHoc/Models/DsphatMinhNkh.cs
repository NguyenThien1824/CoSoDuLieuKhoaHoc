using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DsphatMinhNkh
    {
        public int MaTt { get; set; }
        public int? MaNkh { get; set; }
        public int? MaPm { get; set; }
        public bool? LaChuSoHuu { get; set; }
        public string VaiTro { get; set; }

        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
        public virtual PhatMinhGiaiPhap MaPmNavigation { get; set; }
    }
}
