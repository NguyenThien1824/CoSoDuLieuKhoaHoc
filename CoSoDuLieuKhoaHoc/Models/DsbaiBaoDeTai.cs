using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DsbaiBaoDeTai
    {
        public int MaTt { get; set; }
        public int MaDeTai { get; set; }
        public int MaBaiBao { get; set; }
        public string GhiChu { get; set; }

        public virtual BaiBao MaBaiBaoNavigation { get; set; }
        public virtual DeTai MaDeTaiNavigation { get; set; }
    }
}
