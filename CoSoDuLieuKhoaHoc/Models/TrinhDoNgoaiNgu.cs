using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class TrinhDoNgoaiNgu
    {
        public TrinhDoNgoaiNgu()
        {
            NgoaiNguNkh = new HashSet<NgoaiNguNkh>();
        }

        public int MaTrinhDoNn { get; set; }
        public string TenTrinhDo { get; set; }
        public string CapDo { get; set; }

        public virtual ICollection<NgoaiNguNkh> NgoaiNguNkh { get; set; }
    }
}
