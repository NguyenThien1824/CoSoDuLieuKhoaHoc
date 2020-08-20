using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NhaXuatBan
    {
        public NhaXuatBan()
        {
            SachGiaoTrinh = new HashSet<SachGiaoTrinh>();
        }

        public int MaNxb { get; set; }
        public string TenNxb { get; set; }
        public string DiaChiNxb { get; set; }
        public string DienThoaiNxb { get; set; }
        public string DiaChiWeb { get; set; }

        public virtual ICollection<SachGiaoTrinh> SachGiaoTrinh { get; set; }
    }
}
