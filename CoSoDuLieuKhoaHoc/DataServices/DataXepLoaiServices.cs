using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoSoDuLieuKhoaHoc.MyInterface;

namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataXepLoaiServices 
    {
        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<XepLoaiViewModel>> GetListXepLoai()
        {
            List<XepLoaiViewModel> ls = new List<XepLoaiViewModel>();
            foreach (var i in await db.XepLoai.ToListAsync())
            {
                XepLoaiViewModel a = new XepLoaiViewModel()
                { 
                    MaXepLoai = i.MaXepLoai, TenXepLoai = i.TenXepLoai 
                };
                ls.Add(a);
            }
            return ls ;
        }
    }
}
