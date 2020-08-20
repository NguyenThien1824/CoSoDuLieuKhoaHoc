
using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataPhatMinhGiaiPhapServices
    {

        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<PhatMinhGiaiPhapViewModel>> GetListPhatMinh()
        {
            List<PhatMinhGiaiPhapViewModel> ls = new List<PhatMinhGiaiPhapViewModel>();
            foreach (var i in await db.PhatMinhGiaiPhap.ToListAsync())
            {
                PhatMinhGiaiPhapViewModel a = new PhatMinhGiaiPhapViewModel()
                {
                    MaPm = i.MaPm,
                    TenPm = i.TenPm,
                    SoHieuPm = i.SoHieuPm,
                    MotaPm = i.MotaPm,
                    DoiTuongSuDung = i.DoiTuongSuDung,
                    QuocGiaCap = i.QuocGiaCap,
                    LinkLienKet = i.LinkLienKet,
                    AnhScanGiayChungNhan = i.AnhScanGiayChungNhan,
                    AnhChupSanPham1 = i.AnhChupSanPham1,
                    AnhChupSanPham2 = i.AnhChupSanPham2,
                    NamCongBo = i.NamCongBo


                };
                ls.Add(a);
            }
            return ls;
        }
    }
}

