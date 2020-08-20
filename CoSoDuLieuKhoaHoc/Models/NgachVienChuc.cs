using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NgachVienChuc
    {
        public NgachVienChuc()
        {
            NhaKhoaHoc = new HashSet<NhaKhoaHoc>();
        }

        public int MaNgach { get; set; }
        public string TenNgach { get; set; }

        public virtual ICollection<NhaKhoaHoc> NhaKhoaHoc { get; set; }
    }
}
