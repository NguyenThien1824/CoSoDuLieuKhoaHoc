using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NganhDaoTao
    {
        public NganhDaoTao()
        {
            ChuyenNganh = new HashSet<ChuyenNganh>();
            QuaTrinhDaoTao = new HashSet<QuaTrinhDaoTao>();
        }

        public int MaNganhDaoTao { get; set; }
        public string TenNganhDaoTao { get; set; }

        public virtual ICollection<ChuyenNganh> ChuyenNganh { get; set; }
        public virtual ICollection<QuaTrinhDaoTao> QuaTrinhDaoTao { get; set; }
    }
}
