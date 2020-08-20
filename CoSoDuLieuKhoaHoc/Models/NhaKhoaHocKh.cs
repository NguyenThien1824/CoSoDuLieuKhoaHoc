using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NhaKhoaHocKh
    {
        public int MaNkh { get; set; }
        public string HuongNghienCuu { get; set; }
        public string GiaiThuong { get; set; }
        public string ThamGiaToChu { get; set; }

        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
