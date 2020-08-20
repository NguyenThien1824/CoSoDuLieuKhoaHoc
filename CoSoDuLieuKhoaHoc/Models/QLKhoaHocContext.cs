using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace CoSoDuLieuKhoaHoc.Models
{
    public partial class QLKhoaHocContext : DbContext
    {
        public QLKhoaHocContext()
        {
        }

        public QLKhoaHocContext(DbContextOptions<QLKhoaHocContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BacDaoTao> BacDaoTao { get; set; }
        public virtual DbSet<BaiBao> BaiBao { get; set; }
        public virtual DbSet<CapDeTai> CapDeTai { get; set; }
        public virtual DbSet<CapTapChi> CapTapChi { get; set; }
        public virtual DbSet<ChucNang> ChucNang { get; set; }
        public virtual DbSet<ChuyenMon> ChuyenMon { get; set; }
        public virtual DbSet<ChuyenMonNkh> ChuyenMonNkh { get; set; }
        public virtual DbSet<ChuyenNganh> ChuyenNganh { get; set; }
        public virtual DbSet<DanhGiaNgoaiNgu> DanhGiaNgoaiNgu { get; set; }
        public virtual DbSet<DeTai> DeTai { get; set; }
        public virtual DbSet<DonViChuTri> DonViChuTri { get; set; }
        public virtual DbSet<DonViQl> DonViQl { get; set; }
        public virtual DbSet<DsbaiBaoDeTai> DsbaiBaoDeTai { get; set; }
        public virtual DbSet<DsnguoiThamGiaBaiBao> DsnguoiThamGiaBaiBao { get; set; }
        public virtual DbSet<DsnguoiThamGiaDeTai> DsnguoiThamGiaDeTai { get; set; }
        public virtual DbSet<DsphatMinhNkh> DsphatMinhNkh { get; set; }
        public virtual DbSet<DstacGia> DstacGia { get; set; }
        public virtual DbSet<HocHam> HocHam { get; set; }
        public virtual DbSet<HocVi> HocVi { get; set; }
        public virtual DbSet<KinhPhiDeTai> KinhPhiDeTai { get; set; }
        public virtual DbSet<LinhVuc> LinhVuc { get; set; }
        public virtual DbSet<LinhVucBaiBao> LinhVucBaiBao { get; set; }
        public virtual DbSet<LinhVucNghienCuuNkh> LinhVucNghienCuuNkh { get; set; }
        public virtual DbSet<LoaiHinhDeTai> LoaiHinhDeTai { get; set; }
        public virtual DbSet<NgachVienChuc> NgachVienChuc { get; set; }
        public virtual DbSet<NganHang> NganHang { get; set; }
        public virtual DbSet<NganHangNkh> NganHangNkh { get; set; }
        public virtual DbSet<NganhDaoTao> NganhDaoTao { get; set; }
        public virtual DbSet<NgoaiNguNkh> NgoaiNguNkh { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NhaKhoaHoc> NhaKhoaHoc { get; set; }
        public virtual DbSet<NhaKhoaHocKh> NhaKhoaHocKh { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public virtual DbSet<NhomLinhVuc> NhomLinhVuc { get; set; }
        public virtual DbSet<PhanLoaiSach> PhanLoaiSach { get; set; }
        public virtual DbSet<PhanLoaiSp> PhanLoaiSp { get; set; }
        public virtual DbSet<PhanLoaiTapChi> PhanLoaiTapChi { get; set; }
        public virtual DbSet<PhatMinhGiaiPhap> PhatMinhGiaiPhap { get; set; }
        public virtual DbSet<QuaTrinhCongTac> QuaTrinhCongTac { get; set; }
        public virtual DbSet<QuaTrinhDaoTao> QuaTrinhDaoTao { get; set; }
        public virtual DbSet<SachGiaoTrinh> SachGiaoTrinh { get; set; }
        public virtual DbSet<TinhTrangDeTai> TinhTrangDeTai { get; set; }
        public virtual DbSet<TrinhDoNgoaiNgu> TrinhDoNgoaiNgu { get; set; }
        public virtual DbSet<XepLoai> XepLoai { get; set; }
        public object PhatMinhGiaiPhapViewModel { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().
                   AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("QLKhoaHoc3"));
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacDaoTao>(entity =>
            {
                entity.HasKey(e => e.MaBacDt)
                    .HasName("PK__BacDaoTao");

                entity.Property(e => e.MaBacDt).HasColumnName("MaBacDT");

                entity.Property(e => e.TenBacDt)
                    .IsRequired()
                    .HasColumnName("TenBacDT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BaiBao>(entity =>
            {
                entity.HasKey(e => e.MaBaiBao)
                    .HasName("PK__BaiBao");

                entity.Property(e => e.CqxuatBan)
                    .HasColumnName("CQXuatBan")
                    .HasMaxLength(50);

                entity.Property(e => e.MaIssn)
                    .HasColumnName("MaISSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamDangBao).HasColumnType("date");

                entity.Property(e => e.SoPhatHanh).HasMaxLength(50);

                entity.Property(e => e.TapPhatHanh).HasMaxLength(50);

                entity.Property(e => e.TenBaiBao)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.TrangBaiBao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaCapTapChiNavigation)
                    .WithMany(p => p.BaiBao)
                    .HasForeignKey(d => d.MaCapTapChi)
                    .HasConstraintName("FK_BaiBao_CapTapChi");

                entity.HasOne(d => d.MaLoaiTapChiNavigation)
                    .WithMany(p => p.BaiBao)
                    .HasForeignKey(d => d.MaLoaiTapChi)
                    .HasConstraintName("FK_BaiBao_PhanLoaiTapChi");
            });

            modelBuilder.Entity<CapDeTai>(entity =>
            {
                entity.HasKey(e => e.MaCapDeTai)
                    .HasName("PK__CapDeTai");

                entity.Property(e => e.TenCapDeTai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CapTapChi>(entity =>
            {
                entity.HasKey(e => e.MaCapTapChi)
                    .HasName("PK__CapTapChi");

                entity.Property(e => e.DanhMucNhom).HasMaxLength(100);

                entity.Property(e => e.TenCapTapChi)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ChucNang>(entity =>
            {
                entity.HasKey(e => e.MaChucNang);

                entity.Property(e => e.MaChucNang).ValueGeneratedNever();

                entity.Property(e => e.TenChucNang).HasMaxLength(50);
            });

            modelBuilder.Entity<ChuyenMon>(entity =>
            {
                entity.HasKey(e => e.MaChuyenMon)
                    .HasName("PK__ChuyenMon");

                entity.Property(e => e.TenChuyenMon)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ChuyenMonNkh>(entity =>
            {
                entity.HasKey(e => new { e.MaNkh, e.MaChuyenMon })
                    .HasName("PK__ChuyenMonNKH");

                entity.ToTable("ChuyenMonNKH");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

                entity.HasOne(d => d.MaChuyenMonNavigation)
                    .WithMany(p => p.ChuyenMonNkh)
                    .HasForeignKey(d => d.MaChuyenMon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChuyenMonNKH_fk1");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.ChuyenMonNkh)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChuyenMonNKH_fk0");
            });

            modelBuilder.Entity<ChuyenNganh>(entity =>
            {
                entity.HasKey(e => e.MaChuyenNganh)
                    .HasName("PK__ChuyenNganh");

                entity.Property(e => e.TenChuyenNganh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaNganhDaoTaoNavigation)
                    .WithMany(p => p.ChuyenNganh)
                    .HasForeignKey(d => d.MaNganhDaoTao)
                    .HasConstraintName("ChuyenNganh_fk0");
            });

            modelBuilder.Entity<DanhGiaNgoaiNgu>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.TenLoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeTai>(entity =>
            {
                entity.HasKey(e => e.MaDeTai)
                    .HasName("PK__DeTai");

                entity.Property(e => e.CoQuanTaiTro).HasMaxLength(100);

                entity.Property(e => e.MaDeTaiHoSo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaDonViQlthucHien).HasColumnName("MaDonViQLThucHien");

                entity.Property(e => e.MaDvchuTri).HasColumnName("MaDVChuTri");

                entity.Property(e => e.MaPhanLoaiSp).HasColumnName("MaPhanLoaiSP");

                entity.Property(e => e.NamBd)
                    .HasColumnName("NamBD")
                    .HasColumnType("date");

                entity.Property(e => e.NamKt)
                    .HasColumnName("NamKT")
                    .HasColumnType("date");

                entity.Property(e => e.TenDeTai)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaCapDeTaiNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaCapDeTai)
                    .HasConstraintName("DeTai_fk1");

                entity.HasOne(d => d.MaDonViQlthucHienNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaDonViQlthucHien)
                    .HasConstraintName("DeTai_fk3");

                entity.HasOne(d => d.MaDvchuTriNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaDvchuTri)
                    .HasConstraintName("DeTai_fk2");

                entity.HasOne(d => d.MaLinhVucNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaLinhVuc)
                    .HasConstraintName("DeTai_fk4");

                entity.HasOne(d => d.MaLoaiDeTaiNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaLoaiDeTai)
                    .HasConstraintName("DeTai_fk0");

                entity.HasOne(d => d.MaPhanLoaiSpNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaPhanLoaiSp)
                    .HasConstraintName("DeTai_fk7");

                entity.HasOne(d => d.MaTinhTrangNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaTinhTrang)
                    .HasConstraintName("DeTai_fk6");

                entity.HasOne(d => d.MaXepLoaiNavigation)
                    .WithMany(p => p.DeTai)
                    .HasForeignKey(d => d.MaXepLoai)
                    .HasConstraintName("DeTai_fk5");
            });

            modelBuilder.Entity<DonViChuTri>(entity =>
            {
                entity.HasKey(e => e.MaDvchuTri)
                    .HasName("PK__DonViChu");

                entity.Property(e => e.MaDvchuTri).HasColumnName("MaDVChuTri");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.TenDvchuTri)
                    .IsRequired()
                    .HasColumnName("TenDVChuTri")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DonViQl>(entity =>
            {
                entity.HasKey(e => e.MaDonVi)
                    .HasName("PK__DonViQL");

                entity.ToTable("DonViQL");

                entity.Property(e => e.DiaChiCq)
                    .HasColumnName("DiaChiCQ")
                    .HasMaxLength(50);

                entity.Property(e => e.DienThoaiCq)
                    .HasColumnName("DienThoaiCQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCq)
                    .HasColumnName("EmailCQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenDonVi)
                    .IsRequired()
                    .HasColumnName("TenDonVI")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DsbaiBaoDeTai>(entity =>
            {
                entity.HasKey(e => e.MaTt)
                    .HasName("PK__DSBaiBao__CE33A321FDE42CDD");

                entity.ToTable("DSBaiBaoDeTai");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.HasOne(d => d.MaBaiBaoNavigation)
                    .WithMany(p => p.DsbaiBaoDeTai)
                    .HasForeignKey(d => d.MaBaiBao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DSBaiBaoDeTai_fk1");

                entity.HasOne(d => d.MaDeTaiNavigation)
                    .WithMany(p => p.DsbaiBaoDeTai)
                    .HasForeignKey(d => d.MaDeTai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DSBaiBaoDeTai_fk0");
            });

            modelBuilder.Entity<DsnguoiThamGiaBaiBao>(entity =>
            {
                entity.HasKey(e => e.MaTt)
                    .HasName("PK__DSNguoiT");

                entity.ToTable("DSNguoiThamGiaBaiBao");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.NhiemVu).HasColumnType("ntext");

                entity.HasOne(d => d.MaBaiBaoNavigation)
                    .WithMany(p => p.DsnguoiThamGiaBaiBao)
                    .HasForeignKey(d => d.MaBaiBao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DSNguoiThamGiaBaiBao_fk0");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.DsnguoiThamGiaBaiBao)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DSNguoiThamGiaBaiBao_fk1");
            });

            modelBuilder.Entity<DsnguoiThamGiaDeTai>(entity =>
            {
                entity.HasKey(e => e.MaTt)
                    .HasName("PK__DSNguoiTG");

                entity.ToTable("DSNguoiThamGiaDeTai");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.NhiemVu).HasColumnType("ntext");

                entity.HasOne(d => d.MaDeTaiNavigation)
                    .WithMany(p => p.DsnguoiThamGiaDeTai)
                    .HasForeignKey(d => d.MaDeTai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DSNguoiThamGiaDeTai_fk0");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.DsnguoiThamGiaDeTai)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DSNguoiThamGiaDeTai_fk1");
            });

            modelBuilder.Entity<DsphatMinhNkh>(entity =>
            {
                entity.HasKey(e => e.MaTt);

                entity.ToTable("DSPhatMinhNKH");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.MaPm).HasColumnName("MaPM");

                entity.Property(e => e.VaiTro).HasMaxLength(50);

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.DsphatMinhNkh)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DSPhatMinh_NKH");

                entity.HasOne(d => d.MaPmNavigation)
                    .WithMany(p => p.DsphatMinhNkh)
                    .HasForeignKey(d => d.MaPm)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DSPhatMinh_PM");
            });

            modelBuilder.Entity<DstacGia>(entity =>
            {
                entity.HasKey(e => e.MaTt);

                entity.ToTable("DSTacGia");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.PhanCong).HasColumnType("ntext");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.DstacGia)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DSTacGia_NhaKhoaHoc");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.DstacGia)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DSTacGia_SachGiaoTrinh");
            });

            modelBuilder.Entity<HocHam>(entity =>
            {
                entity.HasKey(e => e.MaHocHam)
                    .HasName("PK__HocHam");

                entity.Property(e => e.TenHocHam).HasMaxLength(50);

                entity.Property(e => e.TenVietTat).HasMaxLength(10);
            });

            modelBuilder.Entity<HocVi>(entity =>
            {
                entity.HasKey(e => e.MaHocVi)
                    .HasName("PK__HocVi");

                entity.Property(e => e.TenHocVi).HasMaxLength(50);

                entity.Property(e => e.TenVietTat)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KinhPhiDeTai>(entity =>
            {
                entity.HasKey(e => e.MaPhi);

                entity.Property(e => e.LoaiTien)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamTiepNhan).HasColumnType("date");

                entity.HasOne(d => d.MaDeTaiNavigation)
                    .WithMany(p => p.KinhPhiDeTai)
                    .HasForeignKey(d => d.MaDeTai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KinhPhiDeTai_DeTai");
            });

            modelBuilder.Entity<LinhVuc>(entity =>
            {
                entity.HasKey(e => e.MaLinhVuc)
                    .HasName("PK__LinhVuc");

                entity.Property(e => e.TenLinhVuc).HasMaxLength(100);

                entity.HasOne(d => d.MaNhomLinhVucNavigation)
                    .WithMany(p => p.LinhVuc)
                    .HasForeignKey(d => d.MaNhomLinhVuc)
                    .HasConstraintName("LinhVuc_fk0");
            });

            modelBuilder.Entity<LinhVucBaiBao>(entity =>
            {
                entity.HasKey(e => new { e.MaBaiBao, e.MaLinhVuc })
                    .HasName("PK__LinhVuc_BaiBao");

                entity.HasOne(d => d.MaBaiBaoNavigation)
                    .WithMany(p => p.LinhVucBaiBao)
                    .HasForeignKey(d => d.MaBaiBao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LinhVucBaiBao_fk0");

                entity.HasOne(d => d.MaLinhVucNavigation)
                    .WithMany(p => p.LinhVucBaiBao)
                    .HasForeignKey(d => d.MaLinhVuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LinhVucBaiBao_fk1");
            });

            modelBuilder.Entity<LinhVucNghienCuuNkh>(entity =>
            {
                entity.HasKey(e => new { e.MaNkh, e.MaLinhVuc })
                    .HasName("PK__LinhVuc_NKH");

                entity.ToTable("LinhVucNghienCuuNKH");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.HasOne(d => d.MaLinhVucNavigation)
                    .WithMany(p => p.LinhVucNghienCuuNkh)
                    .HasForeignKey(d => d.MaLinhVuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LinhVucNghienCuuNKH_fk1");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.LinhVucNghienCuuNkh)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LinhVucNghienCuuNKH_fk0");
            });

            modelBuilder.Entity<LoaiHinhDeTai>(entity =>
            {
                entity.HasKey(e => e.MaLoaiDt);

                entity.Property(e => e.MaLoaiDt).HasColumnName("MaLoaiDT");

                entity.Property(e => e.TenLoaiDt)
                    .IsRequired()
                    .HasColumnName("TenLoaiDT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NgachVienChuc>(entity =>
            {
                entity.HasKey(e => e.MaNgach)
                    .HasName("PK__NgachVienChuc");

                entity.Property(e => e.TenNgach)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NganHang>(entity =>
            {
                entity.HasKey(e => e.MaNh);

                entity.Property(e => e.MaNh).HasColumnName("MaNH");

                entity.Property(e => e.TenNh)
                    .HasColumnName("TenNH")
                    .HasMaxLength(100);

                entity.Property(e => e.TenTiengAnh).HasMaxLength(100);

                entity.Property(e => e.TenVietTat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NganHangNkh>(entity =>
            {
                entity.HasKey(e => e.MaNkh);

                entity.ToTable("NganHangNKH");

                entity.Property(e => e.MaNkh)
                    .HasColumnName("MaNKH")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChiNhanhNh)
                    .HasColumnName("ChiNhanhNH")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.MaNh).HasColumnName("MaNH");

                entity.Property(e => e.Stknh)
                    .HasColumnName("STKNH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaNhNavigation)
                    .WithMany(p => p.NganHangNkh)
                    .HasForeignKey(d => d.MaNh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LoaiNganHang");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithOne(p => p.NganHangNkh)
                    .HasForeignKey<NganHangNkh>(d => d.MaNkh)
                    .HasConstraintName("FK_NganHangNKH");
            });

            modelBuilder.Entity<NganhDaoTao>(entity =>
            {
                entity.HasKey(e => e.MaNganhDaoTao)
                    .HasName("PK__NganhDaoTao");

                entity.Property(e => e.TenNganhDaoTao)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NgoaiNguNkh>(entity =>
            {
                entity.ToTable("NgoaiNguNKH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChungChi).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.MaTrinhDoNn).HasColumnName("MaTrinhDoNN");

                entity.Property(e => e.VanBang).HasMaxLength(50);

                entity.HasOne(d => d.DocNavigation)
                    .WithMany(p => p.NgoaiNguNkhDocNavigation)
                    .HasForeignKey(d => d.Doc)
                    .HasConstraintName("FK_NgoaiNguNKH_DanhGiaDoc");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.NgoaiNguNkh)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NgoaiNguNKH_NKH");

                entity.HasOne(d => d.MaTrinhDoNnNavigation)
                    .WithMany(p => p.NgoaiNguNkh)
                    .HasForeignKey(d => d.MaTrinhDoNn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NgoaiNguNKH_NgoaiNgu");

                entity.HasOne(d => d.NoiNavigation)
                    .WithMany(p => p.NgoaiNguNkhNoiNavigation)
                    .HasForeignKey(d => d.Noi)
                    .HasConstraintName("FK_NgoaiNguNKH_Noi");

                entity.HasOne(d => d.VietNavigation)
                    .WithMany(p => p.NgoaiNguNkhVietNavigation)
                    .HasForeignKey(d => d.Viet)
                    .HasConstraintName("FK_NgoaiNguNKH_DanhGiaViet");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.RandomKey)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usernames)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsernamesQl)
                    .HasColumnName("UsernamesQL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaChucNangNavigation)
                    .WithMany(p => p.NguoiDung)
                    .HasForeignKey(d => d.MaChucNang)
                    .HasConstraintName("FK_NguoiDung_ChucNang");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.NguoiDung)
                    .HasForeignKey(d => d.MaNkh)
                    .HasConstraintName("FK_NguoiDung_NKH");
            });

            modelBuilder.Entity<NhaKhoaHoc>(entity =>
            {
                entity.HasKey(e => e.MaNkh)
                    .HasName("PK__NKH");

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.EmailLienHe)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailThayThe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinhNkh)
                    .HasColumnName("GioiTinhNKH")
                    .HasMaxLength(50);

                entity.Property(e => e.HoNkh)
                    .HasColumnName("HoNKH")
                    .HasMaxLength(50);

                entity.Property(e => e.MaCndaoTao).HasColumnName("MaCNDaoTao");

                entity.Property(e => e.MaDonViQl).HasColumnName("MaDonViQL");

                entity.Property(e => e.MaNkhhoSo)
                    .HasColumnName("MaNKHHoSo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.SoCmnd)
                    .HasColumnName("SoCMND")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenNkh)
                    .HasColumnName("TenNKH")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaCndaoTaoNavigation)
                    .WithMany(p => p.NhaKhoaHoc)
                    .HasForeignKey(d => d.MaCndaoTao)
                    .HasConstraintName("NhaKhoaHoc_fk2");

                entity.HasOne(d => d.MaDonViQlNavigation)
                    .WithMany(p => p.NhaKhoaHoc)
                    .HasForeignKey(d => d.MaDonViQl)
                    .HasConstraintName("NhaKhoaHoc_fk3");

                entity.HasOne(d => d.MaHocHamNavigation)
                    .WithMany(p => p.NhaKhoaHoc)
                    .HasForeignKey(d => d.MaHocHam)
                    .HasConstraintName("NhaKhoaHoc_fk0");

                entity.HasOne(d => d.MaHocViNavigation)
                    .WithMany(p => p.NhaKhoaHoc)
                    .HasForeignKey(d => d.MaHocVi)
                    .HasConstraintName("NhaKhoaHoc_fk1");

                entity.HasOne(d => d.MaNgachVienChucNavigation)
                    .WithMany(p => p.NhaKhoaHoc)
                    .HasForeignKey(d => d.MaNgachVienChuc)
                    .HasConstraintName("NhaKhoaHoc_fk4");
            });

            modelBuilder.Entity<NhaKhoaHocKh>(entity =>
            {
                entity.HasKey(e => e.MaNkh)
                    .HasName("PK_NhaKhoaHoc_NghienCuu");

                entity.ToTable("NhaKhoaHoc_KH");

                entity.Property(e => e.MaNkh)
                    .HasColumnName("MaNKH")
                    .ValueGeneratedNever();

                entity.Property(e => e.GiaiThuong).HasColumnType("ntext");

                entity.Property(e => e.HuongNghienCuu).HasColumnType("ntext");

                entity.Property(e => e.ThamGiaToChu).HasColumnType("ntext");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithOne(p => p.NhaKhoaHocKh)
                    .HasForeignKey<NhaKhoaHocKh>(d => d.MaNkh)
                    .HasConstraintName("FK_NhaKhoaHoc_KH");
            });

            modelBuilder.Entity<NhaXuatBan>(entity =>
            {
                entity.HasKey(e => e.MaNxb);

                entity.Property(e => e.MaNxb).HasColumnName("MaNXB");

                entity.Property(e => e.DiaChiNxb)
                    .HasColumnName("DiaChiNXB")
                    .HasMaxLength(100);

                entity.Property(e => e.DiaChiWeb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DienThoaiNxb)
                    .HasColumnName("DienThoaiNXB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenNxb)
                    .HasColumnName("TenNXB")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NhomLinhVuc>(entity =>
            {
                entity.HasKey(e => e.MaNhomLinhVuc)
                    .HasName("PK__NhomLinhVuc");

                entity.Property(e => e.TenNhomLinhVuc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PhanLoaiSach>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__PhanLoaiSach");

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PhanLoaiSp>(entity =>
            {
                entity.HasKey(e => e.MaPhanLoai)
                    .HasName("PK__PhanLoaiSP");

                entity.ToTable("PhanLoaiSP");

                entity.Property(e => e.TenPhanLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PhanLoaiTapChi>(entity =>
            {
                entity.HasKey(e => e.MaLoaiTapChi)
                    .HasName("PK__PhanLoaiTapChi");

                entity.Property(e => e.TenLoaiTapChi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PhatMinhGiaiPhap>(entity =>
            {
                entity.HasKey(e => e.MaPm);

                entity.Property(e => e.MaPm).HasColumnName("MaPM");

                entity.Property(e => e.DoiTuongSuDung).HasColumnType("ntext");

                entity.Property(e => e.MotaPm)
                    .HasColumnName("MotaPM")
                    .HasColumnType("ntext");

                entity.Property(e => e.NamCongBo).HasColumnType("date");

                entity.Property(e => e.QuocGiaCap).HasMaxLength(50);

                entity.Property(e => e.SoHieuPm)
                    .HasColumnName("SoHieuPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenPm)
                    .HasColumnName("TenPM")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<QuaTrinhCongTac>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.Property(e => e.ChucVuCt)
                    .HasColumnName("ChucVuCT")
                    .HasMaxLength(100);

                entity.Property(e => e.DiaChiQoQuan).HasMaxLength(50);

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.TenCoQuan).HasMaxLength(50);

                entity.Property(e => e.TenPhongBan).HasMaxLength(100);

                entity.Property(e => e.ThoiGianBd)
                    .HasColumnName("ThoiGianBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoiGianKt)
                    .HasColumnName("ThoiGIanKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TinhTp)
                    .HasColumnName("TinhTP")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.QuaTrinhCongTac)
                    .HasForeignKey(d => d.MaNkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuaTrinhCongTac_fk0");
            });

            modelBuilder.Entity<QuaTrinhDaoTao>(entity =>
            {
                entity.HasKey(e => e.MaQt);

                entity.Property(e => e.MaQt).HasColumnName("MaQT");

                entity.Property(e => e.CoSoDaoTao).HasMaxLength(100);

                entity.Property(e => e.MaNkh).HasColumnName("MaNKH");

                entity.Property(e => e.ThoiGianBd)
                    .HasColumnName("ThoiGianBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoiGianKt)
                    .HasColumnName("ThoiGianKT")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MaHocViNavigation)
                    .WithMany(p => p.QuaTrinhDaoTao)
                    .HasForeignKey(d => d.MaHocVi)
                    .HasConstraintName("QuaTrinhDaoTao_fk1");

                entity.HasOne(d => d.MaNganhNavigation)
                    .WithMany(p => p.QuaTrinhDaoTao)
                    .HasForeignKey(d => d.MaNganh)
                    .HasConstraintName("QuaTrinhDaoTao_fk2");

                entity.HasOne(d => d.MaNkhNavigation)
                    .WithMany(p => p.QuaTrinhDaoTao)
                    .HasForeignKey(d => d.MaNkh)
                    .HasConstraintName("QuaTrinhDaoTao_fk0");
            });

            modelBuilder.Entity<SachGiaoTrinh>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__SachGiaoTrinh");

                entity.Property(e => e.AnhBiaIsbn).HasColumnName("AnhBiaISBN");

                entity.Property(e => e.MaIsbn)
                    .HasColumnName("MaISBN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaNxb).HasColumnName("MaNXB");

                entity.Property(e => e.Mota).HasColumnType("ntext");

                entity.Property(e => e.NamXuatBan).HasColumnType("date");

                entity.Property(e => e.TenSach)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.MaLinhVucNavigation)
                    .WithMany(p => p.SachGiaoTrinh)
                    .HasForeignKey(d => d.MaLinhVuc)
                    .HasConstraintName("SachGiaoTrinh_fk1");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SachGiaoTrinh)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("SachGiaoTrinh_fk0");

                entity.HasOne(d => d.MaNxbNavigation)
                    .WithMany(p => p.SachGiaoTrinh)
                    .HasForeignKey(d => d.MaNxb)
                    .HasConstraintName("FK_SachGiaoTrinh_NhaXuatBan");
            });

            modelBuilder.Entity<TinhTrangDeTai>(entity =>
            {
                entity.HasKey(e => e.MaTinhTrang)
                    .HasName("PK__TinhTrangDeTai");

                entity.Property(e => e.TenTinhTrang)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TrinhDoNgoaiNgu>(entity =>
            {
                entity.HasKey(e => e.MaTrinhDoNn)
                    .HasName("PK__TrinhDoNNgu");

                entity.Property(e => e.MaTrinhDoNn)
                    .HasColumnName("MaTrinhDoNN")
                    .ValueGeneratedNever();

                entity.Property(e => e.CapDo).HasMaxLength(50);

                entity.Property(e => e.TenTrinhDo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<XepLoai>(entity =>
            {
                entity.HasKey(e => e.MaXepLoai)
                    .HasName("PK__XepLoai");

                entity.Property(e => e.TenXepLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
