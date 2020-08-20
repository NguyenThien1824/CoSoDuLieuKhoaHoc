using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class LinhVuc
    {
        public LinhVuc()
        {
            DeTai = new HashSet<DeTai>();
            LinhVucBaiBao = new HashSet<LinhVucBaiBao>();
            LinhVucNghienCuuNkh = new HashSet<LinhVucNghienCuuNkh>();
            SachGiaoTrinh = new HashSet<SachGiaoTrinh>();
        }

        public int MaLinhVuc { get; set; }
        public string TenLinhVuc { get; set; }
        public int? MaNhomLinhVuc { get; set; }

        public virtual NhomLinhVuc MaNhomLinhVucNavigation { get; set; }
        public virtual ICollection<DeTai> DeTai { get; set; }
        public virtual ICollection<LinhVucBaiBao> LinhVucBaiBao { get; set; }
        public virtual ICollection<LinhVucNghienCuuNkh> LinhVucNghienCuuNkh { get; set; }
        public virtual ICollection<SachGiaoTrinh> SachGiaoTrinh { get; set; }
    }
}
