using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class LinhVucNghienCuuNkh
    {
        public int MaNkh { get; set; }
        public int MaLinhVuc { get; set; }

        public virtual LinhVuc MaLinhVucNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
