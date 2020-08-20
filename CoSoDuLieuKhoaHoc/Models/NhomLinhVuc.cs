using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NhomLinhVuc
    {
        public NhomLinhVuc()
        {
            LinhVuc = new HashSet<LinhVuc>();
        }

        public int MaNhomLinhVuc { get; set; }
        public string TenNhomLinhVuc { get; set; }

        public virtual ICollection<LinhVuc> LinhVuc { get; set; }
    }
}
