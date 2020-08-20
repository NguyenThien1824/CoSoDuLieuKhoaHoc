using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
namespace CoSoDuLieuKhoaHoc.Models

{
    public partial class XepLoai
    {
        public XepLoai()
        {
            DeTai = new HashSet<DeTai>();
        }

        public int MaXepLoai { get; set; }
        public string TenXepLoai { get; set; }

        public virtual ICollection<DeTai> DeTai { get; set; }
    }
}
