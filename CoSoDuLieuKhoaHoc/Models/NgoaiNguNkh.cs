using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NgoaiNguNkh
    {
        public int Id { get; set; }
        public int MaNkh { get; set; }
        public int MaTrinhDoNn { get; set; }
        public int? Doc { get; set; }
        public int? Viet { get; set; }
        public int? Noi { get; set; }
        public string VanBang { get; set; }
        public string ChungChi { get; set; }
        public string GhiChu { get; set; }

        public virtual DanhGiaNgoaiNgu DocNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
        public virtual TrinhDoNgoaiNgu MaTrinhDoNnNavigation { get; set; }
        public virtual DanhGiaNgoaiNgu NoiNavigation { get; set; }
        public virtual DanhGiaNgoaiNgu VietNavigation { get; set; }
    }
}
