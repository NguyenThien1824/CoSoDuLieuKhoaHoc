using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataBacDaoTaoServices
    {
        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<BacDaoTaoViewModel>> getlistbacdaotao()
        {
            List<BacDaoTaoViewModel> ls = new List<BacDaoTaoViewModel>();
            foreach (var i in await db.BacDaoTao.ToListAsync())
            {
                BacDaoTaoViewModel a = new BacDaoTaoViewModel() { MaBacDt = i.MaBacDt, TenBacDt = i.TenBacDt };
                ls.Add(a);
            }
            return ls;
        }
    }
}
