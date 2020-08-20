using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class DeTai
    {
        public DeTai()
        {
            DsbaiBaoDeTai = new HashSet<DsbaiBaoDeTai>();
            DsnguoiThamGiaDeTai = new HashSet<DsnguoiThamGiaDeTai>();
            KinhPhiDeTai = new HashSet<KinhPhiDeTai>();
        }

        public int MaDeTai { get; set; }
        public string MaDeTaiHoSo { get; set; }
        public string TenDeTai { get; set; }
        public int? MaLoaiDeTai { get; set; }
        public int? MaCapDeTai { get; set; }
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

        public virtual CapDeTai MaCapDeTaiNavigation { get; set; }
        public virtual DonViQl MaDonViQlthucHienNavigation { get; set; }
        public virtual DonViChuTri MaDvchuTriNavigation { get; set; }
        public virtual LinhVuc MaLinhVucNavigation { get; set; }
        public virtual LoaiHinhDeTai MaLoaiDeTaiNavigation { get; set; }
        public virtual PhanLoaiSp MaPhanLoaiSpNavigation { get; set; }
        public virtual TinhTrangDeTai MaTinhTrangNavigation { get; set; }
        public virtual XepLoai MaXepLoaiNavigation { get; set; }
        public virtual ICollection<DsbaiBaoDeTai> DsbaiBaoDeTai { get; set; }
        public virtual ICollection<DsnguoiThamGiaDeTai> DsnguoiThamGiaDeTai { get; set; }
        public virtual ICollection<KinhPhiDeTai> KinhPhiDeTai { get; set; }
    }
}
