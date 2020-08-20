using System;

namespace CoSoDuLieuKhoaHoc.ViewModel
{
    public class DeTaiKhoaHocViewModel
    {
        internal cdtvmd a;

        public int MaDeTai { get; set; }
        public string MaDeTaiHoSo { get; set; }
        public string TenDeTai { get; set; }
        public int? MaLoaiDeTai { get; set; }
 
        public int? MaCapDeTai { get; set; }
        public string Tencapdetai { get; set; }
        public int? MaDvchuTri { get; set; }
        public int? MaDonViQlthucHien { get; set; }
        public int? MaLinhVuc { get; set; }
        public string MucTieuDeTai { get; set; }
        public string NoiDungDeTai { get; set; }
        public string KetQuaDeTai { get; set; }
        public DateTime? NamBd { get; set; }
        public DateTime? NamKt { get; set; }
        public int? MaXepLoai { get; set; }
        public int? MaTinhTrang { get; set; }
        public int? MaPhanLoaiSp { get; set; }
        public string LienKetWeb { get; set; }
        public string LinkFileUpload { get; set; }
        public string CoQuanTaiTro { get; set; }

    }
}
