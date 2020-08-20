using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataBaiBaoKhoaHocServices
    {
        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<BaiBaoKhoaHocViewModel>> GetListBaiBaoKhoaHoc()
        {
            List<BaiBaoKhoaHocViewModel> ls = new List<BaiBaoKhoaHocViewModel>();
            foreach (var i in await db.BaiBao .ToListAsync())
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
        
    }
}

