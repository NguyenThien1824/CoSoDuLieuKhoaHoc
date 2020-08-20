using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class LinhVucBaiBao
    {
        public int MaBaiBao { get; set; }
        public int MaLinhVuc { get; set; }

        public virtual BaiBao MaBaiBaoNavigation { get; set; }
        public virtual LinhVuc MaLinhVucNavigation { get; set; }
    }
}
