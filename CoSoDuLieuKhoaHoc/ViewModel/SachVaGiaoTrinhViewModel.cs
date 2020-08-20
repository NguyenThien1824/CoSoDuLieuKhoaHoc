using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoSoDuLieuKhoaHoc.ViewModel
{
    public class SachVaGiaoTrinhViewModel
    {
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
    }
}
