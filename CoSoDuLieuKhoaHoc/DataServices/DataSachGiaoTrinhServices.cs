using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using Microsoft.EntityFrameworkCore;


namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataSachGiaoTrinhServices
    {
        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<SachVaGiaoTrinhViewModel>> GetLisSachVaGiaoTrinh()
        {
            List<SachVaGiaoTrinhViewModel> ls = new List<SachVaGiaoTrinhViewModel>();
            foreach (var i in await db.SachGiaoTrinh.ToListAsync())
            {
                SachVaGiaoTrinhViewModel a = new SachVaGiaoTrinhViewModel()
                {


                    MaSach = i.MaSach,
                    MaIsbn = i.MaIsbn,
                    TenSach = i.TenSach,
                    MaLoai = i.MaLoai,
                    MaLinhVuc = i.MaLinhVuc,
                    MaNxb = i.MaNxb,
                    NamXuatBan = i.NamXuatBan,
                    Mota = i.Mota,
                    AnhBia1 = i.AnhBia1,
                    AnhBia4 = i.AnhBia4,
                    AnhBiaIsbn = i.AnhBiaIsbn,

                };
                ls.Add(a);
            }
            return ls;
        }
    }
}