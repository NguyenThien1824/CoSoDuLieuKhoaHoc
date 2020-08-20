using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NhaKhoaHoc
    {
        public NhaKhoaHoc()
        {
            ChuyenMonNkh = new HashSet<ChuyenMonNkh>();
            DsnguoiThamGiaBaiBao = new HashSet<DsnguoiThamGiaBaiBao>();
            DsnguoiThamGiaDeTai = new HashSet<DsnguoiThamGiaDeTai>();
            DsphatMinhNkh = new HashSet<DsphatMinhNkh>();
            DstacGia = new HashSet<DstacGia>();
            LinhVucNghienCuuNkh = new HashSet<LinhVucNghienCuuNkh>();
            NgoaiNguNkh = new HashSet<NgoaiNguNkh>();
            NguoiDung = new HashSet<NguoiDung>();
            QuaTrinhCongTac = new HashSet<QuaTrinhCongTac>();
            QuaTrinhDaoTao = new HashSet<QuaTrinhDaoTao>();
        }

        public int MaNkh { get; set; }
        public string MaNkhhoSo { get; set; }
        public string HoNkh { get; set; }
        public string TenNkh { get; set; }
        public string GioiTinhNkh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChiLienHe { get; set; }
        public string DienThoai { get; set; }
        public string EmailLienHe { get; set; }
        public string EmailThayThe { get; set; }
        public int? MaHocHam { get; set; }
        public int? MaHocVi { get; set; }
        public int? MaCndaoTao { get; set; }
        public int? MaDonViQl { get; set; }
        public byte[] AnhCaNhan { get; set; }
        public int? MaNgachVienChuc { get; set; }
        public string SoCmnd { get; set; }
        public string NoiSinh { get; set; }

        public virtual ChuyenNganh MaCndaoTaoNavigation { get; set; }
        public virtual DonViQl MaDonViQlNavigation { get; set; }
        public virtual HocHam MaHocHamNavigation { get; set; }
        public virtual HocVi MaHocViNavigation { get; set; }
        public virtual NgachVienChuc MaNgachVienChucNavigation { get; set; }
        public virtual NganHangNkh NganHangNkh { get; set; }
        public virtual NhaKhoaHocKh NhaKhoaHocKh { get; set; }
        public virtual ICollection<ChuyenMonNkh> ChuyenMonNkh { get; set; }
        public virtual ICollection<DsnguoiThamGiaBaiBao> DsnguoiThamGiaBaiBao { get; set; }
        public virtual ICollection<DsnguoiThamGiaDeTai> DsnguoiThamGiaDeTai { get; set; }
        public virtual ICollection<DsphatMinhNkh> DsphatMinhNkh { get; set; }
        public virtual ICollection<DstacGia> DstacGia { get; set; }
        public virtual ICollection<LinhVucNghienCuuNkh> LinhVucNghienCuuNkh { get; set; }
        public virtual ICollection<NgoaiNguNkh> NgoaiNguNkh { get; set; }
        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
        public virtual ICollection<QuaTrinhCongTac> QuaTrinhCongTac { get; set; }
        public virtual ICollection<QuaTrinhDaoTao> QuaTrinhDaoTao { get; set; }
    }
}
