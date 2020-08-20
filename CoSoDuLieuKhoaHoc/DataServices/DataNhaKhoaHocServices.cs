using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoSoDuLieuKhoaHoc.Models;
using CoSoDuLieuKhoaHoc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace CoSoDuLieuKhoaHoc.DataServices
{
    public class DataNhaKhoaHocServices
    {
        private QLKhoaHocContext db = new QLKhoaHocContext();
        public async Task<List<NhaKhoaHocViewModel>> GetListNhaKhoaHoc()
        {
            List<NhaKhoaHocViewModel> ls = new List<NhaKhoaHocViewModel>();
            foreach (var i in await db.NhaKhoaHoc.ToListAsync())
            {
                NhaKhoaHocViewModel a = new NhaKhoaHocViewModel() 
                { 
                    MaNkh = i.MaNkh,
                    AnhCaNhan = i.AnhCaNhan, 
                    DiaChiLienHe = i.DiaChiLienHe,
                    DienThoai = i.DienThoai, 
                    EmailLienHe = i.EmailLienHe, 
                    EmailThayThe = i.EmailThayThe, 
                    GioiTinhNkh = i.GioiTinhNkh, 
                    HoNkh = i.HoNkh, 
                    MaCndaoTao = i.MaCndaoTao,
                    MaDonViQl = i.MaDonViQl,
                    MaHocHam = i.MaHocHam, 
                    MaHocVi = i.MaHocVi, 
                    MaNgachVienChuc = i.MaNgachVienChuc, 
                    MaNkhhoSo = i.MaNkhhoSo, 
                    NgaySinh = i.NgaySinh, 
                    NoiSinh = i.NoiSinh, 
                    SoCmnd = i.SoCmnd, 
                    TenNkh = i.TenNkh 
                };
                ls.Add(a);
            }
            return ls;
        }
      
        public List<NhaKhoaHocViewModel> NhaKhoaHoc_HocHam()
        {
            var model = from a in db.NhaKhoaHoc
                        join b in db.HocHam
                        on a.MaHocHam equals b.MaHocHam
                        where a.MaHocHam == b.MaHocHam
                        select new NhaKhoaHocViewModel()
                        {
                            MaNkh = a.MaNkh,
                            TenHocHam = b.TenHocHam
                        };
                return model.ToList();
         }
        public List<NhaKhoaHoc> NhaKhoaHoc_ChuyenMon()
        {
            var model = from 
                        a in db.NhaKhoaHoc
                        join b in db.ChuyenMonNkh  
                        on a.MaNkh equals b.MaNkh
                        join c in db.ChuyenMon
                        on b.MaChuyenMon equals c.MaChuyenMon
                        where a.MaNkh == b.MaNkh 
                        select new NhaKhoaHoc()
                        {
                           MaNkh=a.MaNkh,
                           ChuyenMonNkh=c.ChuyenMonNkh
                           
                
                        };
            return model.ToList();

        }
        public List<NhaKhoaHoc> NhaKhoaHoc_HocVi()
        {
            var model = from a in db.HocVi
                        join b in db.NhaKhoaHoc
                        on a.MaHocVi equals b.MaHocVi
                        where a.MaHocVi == b.MaHocVi
                        select new NhaKhoaHoc()
                        {
                            MaHocVi = a.MaHocVi,


                        };
            return model.ToList();
        }

    }
}
/*
 Kim Hoàng Lộc
Giáo sư - Thạc sĩ
Ngành đào tạo:
Giảng viên chính

Chuyên ngành đào tạo:
Kiểm thử

Đơn vị quản lý:
Khoa Công nghệ Thông tin

*/


/*
 Họ và tên: Đặng Thị Thuận An
Giới tính: Nữ
Nơi sinh:
Năm sinh: 1971

 Địa chỉ:
10 B Kiệt 25 Hai Bà Trưng, Thành phố Huế, Thừa Thiên Huế , Thừa Thiên Huế . .   
 Liên hệ:
Điện thoại: 0913465444
Email: dangthithuanan@yahoo.com

Tài khoản ngân hàng:
Số tài khoản: 20192341
Tên ngân hàng: Ngân hàng Chính sách xã hội
Chi nhánh: An Đông

Chuyên môn:
Chức danh:
Phó giáo sư - 1995
Ngành đào tạo:
Công Nghệ Thông Tin

Chuyên ngành đào tạo:
Hệ thống thông ti

Chuyên môn giảng dạy:
Chuyên môn 1; Chuyên môn 2;

Lĩnh vực nghiên cứu:
VẬT LÝ; TÂM LÝ HỌC; KINH TẾ VÀ KINH DOANH;

Trình độ ngoại ngữ:
Tiếng Tây Ban Nha
Tiếng Ý
Đơn vị quản lý
Đơn vị	Địa chỉ cơ quan	Điện thoại cơ quan	Email cơ quan
Khoa Công nghệ Thông tin

Quá trình công tác
2006
2008
Thời gian	01/12/2006 - 01/02/2008
Tên cơ quan công tác	ĐH Sư phạm
Tên phòng ban công tác	Khoa CNTT
Chức vụ	Chuyên viên


Quá trình đào tạo
1993
1995
Học vị	Phổ thông
Cơ sở đào tạo	
Ngành đào tạo	Công Nghệ Thông Tin
Năm tốt nghiệp	1993
 */
