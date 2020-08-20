using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class LoaiHinhDeTai
    {
        public LoaiHinhDeTai()
        {
            DeTai = new HashSet<DeTai>();
        }

        public int MaLoaiDt { get; set; }
        public string TenLoaiDt { get; set; }

        public virtual ICollection<DeTai> DeTai { get; set; }
    }
}
