using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoSoDuLieuKhoaHoc.DataServices;

using System.Data.Entity;
namespace CoSoDuLieuKhoaHoc.ViewModel
{
    public class NhaKhoaHocViewModel
    {
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
        public string? TenHocHam { get; set; }

        public int? MaHocVi { get; set; }
        public int? MaCndaoTao { get; set; }
        public int? MaDonViQl { get; set; }
        public byte[] AnhCaNhan { get; set; }
        public int? MaNgachVienChuc { get; set; }
        public string SoCmnd { get; set; }
        public string NoiSinh { get; set; }

    }
}
