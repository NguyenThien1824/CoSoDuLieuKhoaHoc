using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class SachGiaoTrinh
    {
        public SachGiaoTrinh()
        {
            DstacGia = new HashSet<DstacGia>();
        }

        public int MaSach { get; set; }
        public string MaIsbn { get; set; }
        public string TenSach { get; set; }
        public int? MaLoai { get; set; }
        public int? MaLinhVuc { get; set; }
        public int? MaNxb { get; set; }
        public DateTime? NamXuatBan { get; set; }
        public string Mota { get; set; }
        public byte[] AnhBia1 { get; set; }
        public byte[] AnhBia4 { get; set; }
        public byte[] AnhBiaIsbn { get; set; }

        public virtual LinhVuc MaLinhVucNavigation { get; set; }
        public virtual PhanLoaiSach MaLoaiNavigation { get; set; }
        public virtual NhaXuatBan MaNxbNavigation { get; set; }
        public virtual ICollection<DstacGia> DstacGia { get; set; }
    }
}
