using CoSoDuLieuKhoaHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoSoDuLieuKhoaHoc.ViewModel;
namespace CoSoDuLieuKhoaHoc.MyInterface
{
    interface INhaKhoaHocManager
    {
        Task<List<NhaKhoaHocViewModel>> GetListNhaKhoaHoc();
    }
}
