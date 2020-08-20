using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataDeTaiKhoaHocServices
    {
        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<DeTaiKhoaHocViewModel>> GetListDeTaiKhoHoc()
        {
            List<DeTaiKhoaHocViewModel> ls = new List<DeTaiKhoaHocViewModel>();
            foreach (var i in await db.DeTai.ToListAsync())
            {
                DeTaiKhoaHocViewModel a = new DeTaiKhoaHocViewModel()
                {
                    MaDeTai = i.MaDeTai,
                    MaDeTaiHoSo = i.MaDeTaiHoSo,
                    TenDeTai = i.TenDeTai,
                    MaLoaiDeTai = i.MaLoaiDeTai,
                    MaCapDeTai=i.MaCapDeTai,
                        MaDvchuTri = i.MaDvchuTri,
                    MaDonViQlthucHien = i.MaDonViQlthucHien,
                    MaLinhVuc = i.MaLinhVuc,
                    MucTieuDeTai = i.MucTieuDeTai,
                    NoiDungDeTai = i.NoiDungDeTai,
                    KetQuaDeTai = i.KetQuaDeTai,
                    NamBd = i.NamBd,
                    NamKt = i.NamKt,
                    MaXepLoai = i.MaXepLoai,
                    MaTinhTrang = i.MaTinhTrang,
                    MaPhanLoaiSp = i.MaPhanLoaiSp,
                    LienKetWeb = i.LienKetWeb,
                    LinkFileUpload = i.LinkFileUpload,
                    CoQuanTaiTro = i.CoQuanTaiTro             
                };
                ls.Add(a);
            }
            return ls;
        }
    }
}
