using System;
using System.Collections.Generic;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class NguoiDung
    {
        public int Id { get; set; }
        public string Usernames { get; set; }
        public byte[] Passwords { get; set; }
        public int? MaNkh { get; set; }
        public int? MaChucNang { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool? IsActive { get; set; }
        public string UsernamesQl { get; set; }
        public string RandomKey { get; set; }

        public virtual ChucNang MaChucNangNavigation { get; set; }
        public virtual NhaKhoaHoc MaNkhNavigation { get; set; }
    }
}
