using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class HocVi
    {
        public HocVi()
        {
            NhaKhoaHoc = new HashSet<NhaKhoaHoc>();
            QuaTrinhDaoTao = new HashSet<QuaTrinhDaoTao>();
        }

        public int MaHocVi { get; set; }
        public string TenVietTat { get; set; }
        public string TenHocVi { get; set; }

        public virtual ICollection<NhaKhoaHoc> NhaKhoaHoc { get; set; }
        public virtual ICollection<QuaTrinhDaoTao> QuaTrinhDaoTao { get; set; }
    }
}
