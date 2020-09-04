using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
                    MaCapDeTai = i.MaCapDeTai,
                    MaDVChuTri = i.MaDvchuTri,
                    MaDonViQLThucHien = i.MaDonViQlthucHien,
                    MaLinhVuc = i.MaLinhVuc,
                    MucTieuDeTai = i.MucTieuDeTai,
                    NoiDungDeTai = i.NoiDungDeTai,
                    KetQuaDeTai = i.KetQuaDeTai,
                    NamBD = i.NamBd,
                    NamKT = i.NamKt,
                    MaXepLoai = i.MaXepLoai,
                    MaTinhTrang = i.MaTinhTrang,
                    MaPhanLoaiSP = i.MaPhanLoaiSp,
                    LienKetWeb = i.LienKetWeb,
                    LinkFileUpload = i.LinkFileUpload,
                };
                ls.Add(a);
            }
            return ls;
        }

        // ds kinh phi

        public List<DsKinhPhiDT> dsKinnhPhi(string x)// max de tai la x
        {

            var model = (from a in db.KinhPhiDeTai

                         join b in db.DeTai
                         on a.MaDeTai equals b.MaDeTai
                         select new DsKinhPhiDT
                         {
                             LoaiKinhPhi = a.LoaiKinhPhi,
                             NamCap = a.NamTiepNhan.ToString(),
                             SoTien = a.SoTien.ToString(),
                             LoaiTien = a.LoaiTien,

                         }); return model.ToList();
        }
        // DSThamGiaDT dstgdt = new DSThamGiaDT();
        public IList<DSThamGiaDT> dsngthamgia(int x)// max de tai la x
        {

            var model = (from a in db.DsnguoiThamGiaDeTai
                         join nkh in db.NhaKhoaHoc on a.MaNkh equals nkh.MaNkh
                         where a.MaNkh == x
                         select new DSThamGiaDT
                         {
                             TenNkhtg = nkh.HoNkh + " " + nkh.TenNkh

                         }); return model.ToList();
        }
        // dsdetai viewnodel
        public List<DeTaiKhoaHocSearchViewModel> dtkhsvmd()
        {
            var model = (from a in db.DeTai

                         join b in db.DonViChuTri
                         on a.MaDvchuTri equals b.MaDvchuTri
                         join c in db.DonViQl
                         on a.MaDonViQlthucHien equals c.MaDonVi
                         join d in db.LinhVuc
                         on a.MaLinhVuc equals d.MaLinhVuc
                         join dsthamgiadt in db.DsnguoiThamGiaDeTai
                         on a.MaDeTai equals dsthamgiadt.MaDeTai

                         select new DeTaiKhoaHocSearchViewModel
                         {
                             Madetai = a.MaDeTai,
                             TenDeTai = a.TenDeTai,
                             MaDeTaiHoSo = a.MaDeTaiHoSo,
                             LinhVuc = d.TenLinhVuc,
                             DonViChuTri = b.TenDvchuTri,
                             DonViThucHien = c.TenDonVi,


                         }

                       ); return model.ToList();
        }
        public int SLDeTai()
        {
            DeTai ndtkh = new DeTai();
            var purch = from a in db.DeTai
                        select a;
            return purch.Count();

        }
    }
    //Kinh phí




}

//
//   KinhPhi=i.KinhPhiDeTai,
//DSNguoiThamGiaDT =i.DsnguoiThamGiaDeTai,

