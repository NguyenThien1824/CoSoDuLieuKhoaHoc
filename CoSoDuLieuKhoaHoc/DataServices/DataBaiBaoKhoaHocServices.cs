using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataBaiBaoKhoaHocServices
    {
        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<BaiBaoKhoaHocViewModel>> GetListBaiBaoKhoaHoc()
        {
            List<BaiBaoKhoaHocViewModel> ls = new List<BaiBaoKhoaHocViewModel>();
            foreach (var i in await db.BaiBao.ToListAsync())
            {
                BaiBaoKhoaHocViewModel a = new BaiBaoKhoaHocViewModel()
                {
                    MaBaiBao = i.MaBaiBao,
                    MaIssn = i.MaIssn,




                    TenBaiBao = i.TenBaiBao,
                    LaTrongNuoc = i.LaTrongNuoc,
                    CqxuatBan = i.CqxuatBan,
                    MaLoaiTapChi = i.MaLoaiTapChi,
                    MaCapTapChi = i.MaCapTapChi,
                    NamDangBao = i.NamDangBao,
                    TapPhatHanh = i.TapPhatHanh,
                    SoPhatHanh = i.SoPhatHanh,
                    TrangBaiBao = i.TrangBaiBao,
                    LienKetWeb = i.LienKetWeb,
                    LinkFileUpLoad = i.LinkFileUpLoad
                };
                ls.Add(a);
            }
            return ls;
        }



        public List<BaiBaoSearchViewModel> DSBaiBaoKH()
        {

            /*
             * TEN BAIBAO
             * CQXuatBan
             * TenLinhVuc
             * TenCapTapChi 
             * TenLoaiTapChi
             * CQXuatBan
             * DSTACGIA
              */


            var model = (from bbao in db.BaiBao
                             // join dsthamgia in db.DsnguoiThamGiaBaiBao on bbao.MaBaiBao equals dsthamgia.MaBaiBao
                         join lvuc in db.LinhVucBaiBao on bbao.MaBaiBao equals lvuc.MaBaiBao
                         // join tgia in db.DstacGia on bbao.MaBaiBao equals tgia.MaNkh
                         join lvucbb in db.LinhVuc on lvuc.MaLinhVuc equals lvucbb.MaLinhVuc
                         join nkh in db.DsnguoiThamGiaBaiBao on bbao.MaBaiBao equals nkh.MaBaiBao
                         select new BaiBaoSearchViewModel()
                         {
                             TenBaiBao = bbao.TenBaiBao,
                             MaBaiBao = bbao.MaBaiBao,
                             CQXuatBan = bbao.CqxuatBan,//Tổng cục kĩ thuật
                             TenLinhVuc = lvucbb.TenLinhVuc,
                         });

            return model.ToList();
        }






    }
}

