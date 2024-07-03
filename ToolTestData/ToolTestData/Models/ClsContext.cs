using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToolTestData.Models;

public partial class ClsContext : DbContext
{
    public ClsContext()
    {
    }

    public ClsContext(DbContextOptions<ClsContext> options)
        : base(options)
    {
    }
    public virtual DbSet<ClsText> ClsTexts { get; set; }
    public virtual DbSet<BangCap> BangCaps { get; set; }

    public virtual DbSet<BenhNhan> BenhNhans { get; set; }

    public virtual DbSet<BenhNhanTrenHangCho> BenhNhanTrenHangChos { get; set; }

    public virtual DbSet<BenhVien> BenhViens { get; set; }

    public virtual DbSet<Bhyt> Bhyts { get; set; }

    public virtual DbSet<Ca> Cas { get; set; }

    public virtual DbSet<CaTruc> CaTrucs { get; set; }

    public virtual DbSet<ChiTietDichVuDangGoi> ChiTietDichVuDangGois { get; set; }

    public virtual DbSet<ChiTietDotKham> ChiTietDotKhams { get; set; }

    public virtual DbSet<ChiTietGoiKham> ChiTietGoiKhams { get; set; }

    public virtual DbSet<ChiTietHoaDonDienTu> ChiTietHoaDonDienTus { get; set; }

    public virtual DbSet<ChiTietToaThuoc> ChiTietToaThuocs { get; set; }

    public virtual DbSet<ChonKetQua> ChonKetQuas { get; set; }

    public virtual DbSet<ChuongIcd10> ChuongIcd10s { get; set; }

    public virtual DbSet<ChuongIcd9> ChuongIcd9s { get; set; }

    public virtual DbSet<ChuyenDoiDonVi> ChuyenDoiDonVis { get; set; }

    public virtual DbSet<ClsCaChup> ClsCaChups { get; set; }

    public virtual DbSet<ClsCdhaChiTietCt> ClsCdhaChiTietCts { get; set; }

    public virtual DbSet<ClsCdhaChiTietMri> ClsCdhaChiTietMris { get; set; }

    public virtual DbSet<ClsCdhaChiTietNoiSoi> ClsCdhaChiTietNoiSois { get; set; }

    public virtual DbSet<ClsCdhaChiTietPhieuDoApLucHmtt> ClsCdhaChiTietPhieuDoApLucHmtts { get; set; }

    public virtual DbSet<ClsCdhaChiTietPhieuSieuAm> ClsCdhaChiTietPhieuSieuAms { get; set; }

    public virtual DbSet<ClsCdhaChiTietPhieuSieuAmTim> ClsCdhaChiTietPhieuSieuAmTims { get; set; }

    public virtual DbSet<ClsCdhaChiTietXquang> ClsCdhaChiTietXquangs { get; set; }

    public virtual DbSet<ClsCdhaSatDopplerDongQuaVanBaLa> ClsCdhaSatDopplerDongQuaVanBaLas { get; set; }

    public virtual DbSet<ClsCdhaSatDopplerDongQuaVanDongMachChu> ClsCdhaSatDopplerDongQuaVanDongMachChus { get; set; }

    public virtual DbSet<ClsCdhaSatDopplerDongQuaVanDongMachPhoi> ClsCdhaSatDopplerDongQuaVanDongMachPhois { get; set; }

    public virtual DbSet<ClsCdhaSatDopplerDongQuaVanHaiLa> ClsCdhaSatDopplerDongQuaVanHaiLas { get; set; }

    public virtual DbSet<ClsCdhaSatHaiD> ClsCdhaSatHaiDs { get; set; }

    public virtual DbSet<ClsCdhaSatMoTaHinhAnh> ClsCdhaSatMoTaHinhAnhs { get; set; }

    public virtual DbSet<ClsCdhaSatTm> ClsCdhaSatTms { get; set; }

    public virtual DbSet<ClsChamThuThuat> ClsChamThuThuats { get; set; }

    public virtual DbSet<ClsChiTietGiaiPhauBenh> ClsChiTietGiaiPhauBenhs { get; set; }

    public virtual DbSet<ClsChiTietThuocCuaBn> ClsChiTietThuocCuaBns { get; set; }

    public virtual DbSet<ClsChiTietTuyDo> ClsChiTietTuyDos { get; set; }

    public virtual DbSet<ClsDanhGium> ClsDanhGia { get; set; }

    public virtual DbSet<ClsDichVuChamThem> ClsDichVuChamThems { get; set; }

    public virtual DbSet<ClsGpbMauNhuom> ClsGpbMauNhuoms { get; set; }

    public virtual DbSet<ClsKio> ClsKios { get; set; }

    public virtual DbSet<ClsLoaiPhieuChiDinh> ClsLoaiPhieuChiDinhs { get; set; }

    public virtual DbSet<ClsNhmBienBanHuy> ClsNhmBienBanHuys { get; set; }

    public virtual DbSet<ClsNhmChiTietLoMau> ClsNhmChiTietLoMaus { get; set; }

    public virtual DbSet<ClsNhmChiTietPhieuDangKyMau> ClsNhmChiTietPhieuDangKyMaus { get; set; }

    public virtual DbSet<ClsNhmDanhMucMau> ClsNhmDanhMucMaus { get; set; }

    public virtual DbSet<ClsNhmKho> ClsNhmKhos { get; set; }

    public virtual DbSet<ClsNhmLoMau> ClsNhmLoMaus { get; set; }

    public virtual DbSet<ClsNhmLoaiChePham> ClsNhmLoaiChePhams { get; set; }

    public virtual DbSet<ClsNhmLogDangKi> ClsNhmLogDangKis { get; set; }

    public virtual DbSet<ClsNhmLogMau> ClsNhmLogMaus { get; set; }

    public virtual DbSet<ClsNhmLogThuThuat> ClsNhmLogThuThuats { get; set; }

    public virtual DbSet<ClsNhmLogTuiMau> ClsNhmLogTuiMaus { get; set; }

    public virtual DbSet<ClsNhmMaSanPhamIsbt> ClsNhmMaSanPhamIsbts { get; set; }

    public virtual DbSet<ClsNhmNhaCungCap> ClsNhmNhaCungCaps { get; set; }

    public virtual DbSet<ClsNhmNhomMauTheoIsbt> ClsNhmNhomMauTheoIsbts { get; set; }

    public virtual DbSet<ClsNhmPhanLoaiChePham> ClsNhmPhanLoaiChePhams { get; set; }

    public virtual DbSet<ClsNhmPhieuDangKyMau> ClsNhmPhieuDangKyMaus { get; set; }

    public virtual DbSet<ClsNhmPhieuHoanKho> ClsNhmPhieuHoanKhos { get; set; }

    public virtual DbSet<ClsNhmPhieuYeuCauLinh> ClsNhmPhieuYeuCauLinhs { get; set; }

    public virtual DbSet<ClsNhmTuiMau> ClsNhmTuiMaus { get; set; }

    public virtual DbSet<ClsPhanLoaiNhomDichVu> ClsPhanLoaiNhomDichVus { get; set; }

    public virtual DbSet<ClsPhienLamViec> ClsPhienLamViecs { get; set; }

    public virtual DbSet<ClsPhieuChiDinh> ClsPhieuChiDinhs { get; set; }

    public virtual DbSet<ClsPhieuYeuCauChinhSua> ClsPhieuYeuCauChinhSuas { get; set; }

    public virtual DbSet<ClsSoDaCap> ClsSoDaCaps { get; set; }

    public virtual DbSet<ClsTag> ClsTags { get; set; }

    public virtual DbSet<ClsTdKetQuaTuyDo> ClsTdKetQuaTuyDos { get; set; }

    public virtual DbSet<ClsTdMoTaTieuBanMauNgoaiVi> ClsTdMoTaTieuBanMauNgoaiVis { get; set; }

    public virtual DbSet<ClsTdcnChiTietDienCo> ClsTdcnChiTietDienCos { get; set; }

    public virtual DbSet<ClsTdcnChiTietDienNao> ClsTdcnChiTietDienNaos { get; set; }

    public virtual DbSet<ClsTdcnChiTietDienTim> ClsTdcnChiTietDienTims { get; set; }

    public virtual DbSet<ClsTdcnChiTietDoCnhoHap> ClsTdcnChiTietDoCnhoHaps { get; set; }

    public virtual DbSet<ClsTdcnDienCoKetQuaDienCoKim> ClsTdcnDienCoKetQuaDienCoKims { get; set; }

    public virtual DbSet<ClsTdcnDienCoKetQuaDttkcamGiac> ClsTdcnDienCoKetQuaDttkcamGiacs { get; set; }

    public virtual DbSet<ClsTdcnDienCoKetQuaDttkvanDong> ClsTdcnDienCoKetQuaDttkvanDongs { get; set; }

    public virtual DbSet<ClsTdcnDienCoKetQuaHstgtiemCoTay> ClsTdcnDienCoKetQuaHstgtiemCoTays { get; set; }

    public virtual DbSet<ClsThuocCuaBn> ClsThuocCuaBns { get; set; }

    public virtual DbSet<ClsThuocVatTu> ClsThuocVatTus { get; set; }

    public virtual DbSet<CoSo> CoSos { get; set; }

    public virtual DbSet<CongTy> CongTies { get; set; }

    public virtual DbSet<DanToc> DanTocs { get; set; }

    public virtual DbSet<DangBaoChe> DangBaoChes { get; set; }

    public virtual DbSet<DangKyCaKham> DangKyCaKhams { get; set; }

    public virtual DbSet<DangKyCaNhaThuoc> DangKyCaNhaThuocs { get; set; }

    public virtual DbSet<DanhMucHoatChatThuoc> DanhMucHoatChatThuocs { get; set; }

    public virtual DbSet<DanhMucThanhVienKiemDuyet> DanhMucThanhVienKiemDuyets { get; set; }

    public virtual DbSet<DanhMucThuocThau> DanhMucThuocThaus { get; set; }

    public virtual DbSet<DanhSachThuocBhyt> DanhSachThuocBhyts { get; set; }

    public virtual DbSet<DiaChi> DiaChis { get; set; }

    public virtual DbSet<DichVuDangGoi> DichVuDangGois { get; set; }

    public virtual DbSet<DichVuKham> DichVuKhams { get; set; }

    public virtual DbSet<DichVuMacDinh> DichVuMacDinhs { get; set; }

    public virtual DbSet<DichVuTheoChuyenMon> DichVuTheoChuyenMons { get; set; }

    public virtual DbSet<DichVuThongTu37> DichVuThongTu37s { get; set; }

    public virtual DbSet<DichVuThongTu43> DichVuThongTu43s { get; set; }

    public virtual DbSet<DoiTuong> DoiTuongs { get; set; }

    public virtual DbSet<DonVi> DonVis { get; set; }

    public virtual DbSet<DotKham> DotKhams { get; set; }

    public virtual DbSet<DuongDung> DuongDungs { get; set; }

    public virtual DbSet<GoiKham> GoiKhams { get; set; }

    public virtual DbSet<HangChoBenhNhan> HangChoBenhNhans { get; set; }

    public virtual DbSet<HangSanXuat> HangSanXuats { get; set; }

    public virtual DbSet<HoSoBenhAn> HoSoBenhAns { get; set; }

    public virtual DbSet<HoSoXuatNhapVien> HoSoXuatNhapViens { get; set; }

    public virtual DbSet<HoaDonDienTu> HoaDonDienTus { get; set; }

    public virtual DbSet<HoatChat> HoatChats { get; set; }

    public virtual DbSet<HopDongThau> HopDongThaus { get; set; }

    public virtual DbSet<HuongDan> HuongDans { get; set; }

    public virtual DbSet<Icd10> Icd10s { get; set; }

    public virtual DbSet<Icd10nhomBhyt> Icd10nhomBhyts { get; set; }

    public virtual DbSet<Icd9> Icd9s { get; set; }

    public virtual DbSet<Kho> Khos { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<KhoaBhyt> KhoaBhyts { get; set; }

    public virtual DbSet<Khoi> Khois { get; set; }

    public virtual DbSet<KhuVuc> KhuVucs { get; set; }

    public virtual DbSet<KieuKetQua> KieuKetQuas { get; set; }

    public virtual DbSet<LichHen> LichHens { get; set; }

    public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; }

    public virtual DbSet<LoaiDonVi> LoaiDonVis { get; set; }

    public virtual DbSet<LoaiIcd10> LoaiIcd10s { get; set; }

    public virtual DbSet<LoaiMauKetQua> LoaiMauKetQuas { get; set; }

    public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }

    public virtual DbSet<LoaiThietBi> LoaiThietBis { get; set; }

    public virtual DbSet<LuotSuIn> LuotSuIns { get; set; }

    public virtual DbSet<MauKetQua> MauKetQuas { get; set; }

    public virtual DbSet<MauThuoc> MauThuocs { get; set; }

    public virtual DbSet<MayTram> MayTrams { get; set; }

    public virtual DbSet<MeNghiConOm> MeNghiConOms { get; set; }

    public virtual DbSet<NgayLe> NgayLes { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NguonHenKham> NguonHenKhams { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhaThuoc> NhaThuocs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NhanVienKhoa> NhanVienKhoas { get; set; }

    public virtual DbSet<NhomBhyt> NhomBhyts { get; set; }

    public virtual DbSet<NhomDichVu> NhomDichVus { get; set; }

    public virtual DbSet<NhomDichVuChiPhi> NhomDichVuChiPhis { get; set; }

    public virtual DbSet<NhomDuocLy> NhomDuocLies { get; set; }

    public virtual DbSet<NhomIcd10> NhomIcd10s { get; set; }

    public virtual DbSet<NhomIcd9> NhomIcd9s { get; set; }

    public virtual DbSet<NhomNguoiDung> NhomNguoiDungs { get; set; }

    public virtual DbSet<NhomQuyen> NhomQuyens { get; set; }

    public virtual DbSet<NoiHen> NoiHens { get; set; }

    public virtual DbSet<PhanLoaiDoc> PhanLoaiDocs { get; set; }

    public virtual DbSet<PhanLoaiIcd9> PhanLoaiIcd9s { get; set; }

    public virtual DbSet<PhanLoaiPhauThuat> PhanLoaiPhauThuats { get; set; }

    public virtual DbSet<PhanLoaiThuoc> PhanLoaiThuocs { get; set; }

    public virtual DbSet<PhanQuyenNguoiDung> PhanQuyenNguoiDungs { get; set; }

    public virtual DbSet<PhanQuyenNhom> PhanQuyenNhoms { get; set; }

    public virtual DbSet<PhieuPhauThuatThuThuat> PhieuPhauThuatThuThuats { get; set; }

    public virtual DbSet<PhieuThanhToan> PhieuThanhToans { get; set; }

    public virtual DbSet<PhieuThanhToanTungPhan> PhieuThanhToanTungPhans { get; set; }

    public virtual DbSet<PhongKham> PhongKhams { get; set; }

    public virtual DbSet<PhuongXa> PhuongXas { get; set; }

    public virtual DbSet<PrismaMigration> PrismaMigrations { get; set; }

    public virtual DbSet<QuanHuyen> QuanHuyens { get; set; }

    public virtual DbSet<QuocGium> QuocGia { get; set; }

    public virtual DbSet<QuocTich> QuocTiches { get; set; }

    public virtual DbSet<Quyen> Quyens { get; set; }

    public virtual DbSet<TaiLieuDinhKem> TaiLieuDinhKems { get; set; }

    public virtual DbSet<ThietBi> ThietBis { get; set; }

    public virtual DbSet<ThongTinThau> ThongTinThaus { get; set; }

    public virtual DbSet<ThongTinThauThuocBhyt> ThongTinThauThuocBhyts { get; set; }

    public virtual DbSet<ThuocNguyenLieuYte> ThuocNguyenLieuYtes { get; set; }

    public virtual DbSet<TinhThanh> TinhThanhs { get; set; }

    public virtual DbSet<ToaThuoc> ToaThuocs { get; set; }

    public virtual DbSet<TuongTacThuoc> TuongTacThuocs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=CLS;Username=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BangCap>(entity =>
        {
            entity.HasKey(e => e.MaBangCap).HasName("BangCap_pkey");

            entity.ToTable("BangCap");

            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
        });

        modelBuilder.Entity<BenhNhan>(entity =>
        {
            entity.HasKey(e => e.MaSoBenhNhan).HasName("BenhNhan_pkey");

            entity.ToTable("BenhNhan");

            entity.HasIndex(e => e.MaBenhNhan, "BenhNhan_MaBenhNhan_key").IsUnique();

            entity.HasIndex(e => new { e.MaDanToc, e.MaQuocTich, e.DiaChiThuongTru, e.GioiTinh, e.LanKhamCuoi }, "BenhNhan_MaDanToc_MaQuocTich_DiaChiThuongTru_GioiTinh_LanKh_idx");

            entity.Property(e => e.HoTenBa).HasMaxLength(255);
            entity.Property(e => e.HoTenMe).HasMaxLength(255);
            entity.Property(e => e.LanKhamCuoi).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MaBenhNhan).HasMaxLength(100);
            entity.Property(e => e.MaPhatSinh).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgaySinh).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoDienThoaiBa).HasMaxLength(15);
            entity.Property(e => e.SoDienThoaiMe).HasMaxLength(15);
            entity.Property(e => e.TenBenhNhan).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<BenhNhanTrenHangCho>(entity =>
        {
            entity.HasKey(e => e.MaSoBenhNhanTrenHangCho).HasName("BenhNhanTrenHangCho_pkey");

            entity.ToTable("BenhNhanTrenHangCho");

            entity.Property(e => e.ThoiGianBatDau)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ThoiGianKetThuc).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(0);
        });

        modelBuilder.Entity<BenhVien>(entity =>
        {
            entity.HasKey(e => e.MaSoBenhVien).HasName("BenhVien_pkey");

            entity.ToTable("BenhVien");

            entity.HasIndex(e => e.MaBenhVienDayDu, "BenhVien_MaBenhVienDayDu_key").IsUnique();

            entity.HasIndex(e => e.MaBenhVien, "BenhVien_MaBenhVien_key").IsUnique();

            entity.Property(e => e.MaBenhVien).HasMaxLength(20);
            entity.Property(e => e.MaBenhVienDayDu).HasMaxLength(20);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenBenhVien).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TuyenChuyenMonKyThuat).HasMaxLength(255);
            entity.Property(e => e.XepHang).HasMaxLength(255);
        });

        modelBuilder.Entity<Bhyt>(entity =>
        {
            entity.HasKey(e => e.MaSoTheBhyt).HasName("BHYT_pkey");

            entity.ToTable("BHYT");

            entity.HasIndex(e => e.MaTheBhyt, "BHYT_MaTheBHYT_key").IsUnique();

            entity.HasIndex(e => e.NoiDangKyKhamChuaBenhBanDau, "BHYT_NoiDangKyKhamChuaBenhBanDau_idx");

            entity.Property(e => e.MaSoTheBhyt).HasColumnName("MaSoTheBHYT");
            entity.Property(e => e.Kct)
                .HasDefaultValue(false)
                .HasColumnName("KCT");
            entity.Property(e => e.KctdenNgay)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("KCTDenNgay");
            entity.Property(e => e.KcttuNgay)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("KCTTuNgay");
            entity.Property(e => e.MaTheBhyt)
                .HasMaxLength(15)
                .HasColumnName("MaTheBHYT");
            entity.Property(e => e.MaVachBhyt)
                .HasMaxLength(255)
                .HasColumnName("MaVachBHYT");
            entity.Property(e => e.NgayCap).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayHetHan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhomBhyt).HasColumnName("NhomBHYT");
            entity.Property(e => e.QuyenLoi).HasMaxLength(5);
            entity.Property(e => e.ThoiHanDu5NamBhyt)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("ThoiHanDu5NamBHYT");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<Ca>(entity =>
        {
            entity.HasKey(e => e.MaSoCa).HasName("Ca_pkey");

            entity.ToTable("Ca");

            entity.HasIndex(e => e.MaCa, "Ca_MaCa_key").IsUnique();

            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.MaCa).HasMaxLength(20);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.QuaNgay).HasDefaultValue(false);
            entity.Property(e => e.TenCa).HasMaxLength(255);
            entity.Property(e => e.TenNgan).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<CaTruc>(entity =>
        {
            entity.HasKey(e => e.MaCaTruc).HasName("CaTruc_pkey");

            entity.ToTable("CaTruc");

            entity.HasIndex(e => new { e.MaBacSi, e.MaKhuVuc, e.MaPhongKham, e.MaCa }, "CaTruc_MaBacSi_MaKhuVuc_MaPhongKham_MaCa_idx");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTruc).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ChiTietDichVuDangGoi>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietDangGoi).HasName("ChiTietDichVuDangGoi_pkey");

            entity.ToTable("ChiTietDichVuDangGoi");

            entity.HasIndex(e => e.MaChiTietDangGoi, "ChiTietDichVuDangGoi_MaChiTietDangGoi_key").IsUnique();

            entity.Property(e => e.GiaDichVuDangGoi).HasPrecision(65, 30);
            entity.Property(e => e.MaChiTietDangGoi).HasMaxLength(45);
        });

        modelBuilder.Entity<ChiTietDotKham>(entity =>
        {
            entity.HasKey(e => e.MaChiTietDotKham).HasName("ChiTietDotKham_pkey");

            entity.ToTable("ChiTietDotKham");

            entity.HasIndex(e => e.MaChiTietDotKham, "ChiTietDotKham_MaChiTietDotKham_key").IsUnique();

            entity.HasIndex(e => new { e.MaDotKham, e.MaBacSi, e.MaDichVu, e.MaCa, e.MaHangCho, e.NguoiTao, e.NguoiCapNhat }, "ChiTietDotKham_MaDotKham_MaBacSi_MaDichVu_MaCa_MaHangCho_Ng_idx");

            entity.Property(e => e.BaoHiemYte)
                .HasDefaultValue(false)
                .HasColumnName("BaoHiemYTe");
            entity.Property(e => e.DaIn).HasDefaultValue(false);
            entity.Property(e => e.DaTraTien).HasDefaultValue(false);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayIn).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ThoiGianTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThaiCls).HasColumnName("TrangThaiCLS");
        });

        modelBuilder.Entity<ChiTietGoiKham>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietGoiKham).HasName("ChiTietGoiKham_pkey");

            entity.ToTable("ChiTietGoiKham");

            entity.HasIndex(e => e.MaChiTietGoiKham, "ChiTietGoiKham_MaChiTietGoiKham_key").IsUnique();

            entity.Property(e => e.DichVuChinh).HasDefaultValue(true);
            entity.Property(e => e.GiaKham).HasPrecision(65, 30);
            entity.Property(e => e.MaChiTietGoiKham).HasMaxLength(50);
        });

        modelBuilder.Entity<ChiTietHoaDonDienTu>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietHoaDonDienTu).HasName("ChiTietHoaDonDienTu_pkey");

            entity.ToTable("ChiTietHoaDonDienTu");

            entity.HasIndex(e => e.MaChiTietHoaDonDienTu, "ChiTietHoaDonDienTu_MaChiTietHoaDonDienTu_key").IsUnique();

            entity.HasIndex(e => new { e.MaHoaDonDienTu, e.TrangThai, e.NguoiTao }, "ChiTietHoaDonDienTu_MaHoaDonDienTu_TrangThai_NguoiTao_idx");

            entity.Property(e => e.HuongDanBkav)
                .HasMaxLength(125)
                .HasColumnName("HuongDanBKAV");
            entity.Property(e => e.MaChiTietHoaDonDienTu).HasMaxLength(255);
            entity.Property(e => e.MauHoaDonDienTu).HasMaxLength(100);
            entity.Property(e => e.ThoiGianTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TongTien).HasPrecision(65, 30);
        });

        modelBuilder.Entity<ChiTietToaThuoc>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietToaThuoc).HasName("ChiTietToaThuoc_pkey");

            entity.ToTable("ChiTietToaThuoc");

            entity.Property(e => e.HuongDan).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ChonKetQua>(entity =>
        {
            entity.HasKey(e => e.MaSoChonKetQua).HasName("ChonKetQua_pkey");

            entity.ToTable("ChonKetQua");

            entity.Property(e => e.MaChonKetQua).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenChonKetQua).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ChuongIcd10>(entity =>
        {
            entity.HasKey(e => e.MaSoChuongIcd10).HasName("ChuongICD10_pkey");

            entity.ToTable("ChuongICD10");

            entity.HasIndex(e => e.MaChuongIcd10, "ChuongICD10_MaChuongICD10_key").IsUnique();

            entity.HasIndex(e => e.SoChuongIcd10, "ChuongICD10_SoChuongICD10_key").IsUnique();

            entity.Property(e => e.MaSoChuongIcd10).HasColumnName("MaSoChuongICD10");
            entity.Property(e => e.MaChuongIcd10)
                .HasMaxLength(45)
                .HasColumnName("MaChuongICD10");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoChuongIcd10)
                .HasMaxLength(5)
                .HasColumnName("SoChuongICD10");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ChuongIcd9>(entity =>
        {
            entity.HasKey(e => e.MaSoChuongIcd9).HasName("ChuongICD9_pkey");

            entity.ToTable("ChuongICD9");

            entity.HasIndex(e => e.MaChuongIcd9, "ChuongICD9_MaChuongICD9_key").IsUnique();

            entity.HasIndex(e => e.SoChuongIcd9, "ChuongICD9_SoChuongICD9_key").IsUnique();

            entity.Property(e => e.MaSoChuongIcd9).HasColumnName("MaSoChuongICD9");
            entity.Property(e => e.MaChuongIcd9)
                .HasMaxLength(45)
                .HasColumnName("MaChuongICD9");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoChuongIcd9)
                .HasMaxLength(5)
                .HasColumnName("SoChuongICD9");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ChuyenDoiDonVi>(entity =>
        {
            entity.HasKey(e => e.MaSoChuyenDoiDonVi).HasName("ChuyenDoiDonVi_pkey");

            entity.ToTable("ChuyenDoiDonVi");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PhepToanChuyenDoi).HasMaxLength(10);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TyLeChuyenDoi).HasPrecision(65, 30);
        });

        modelBuilder.Entity<ClsCaChup>(entity =>
        {
            entity.HasKey(e => e.MaSoCaChup).HasName("CLS_CaChup_pkey");

            entity.ToTable("CLS_CaChup");

            entity.HasIndex(e => e.MaCaChup, "CLS_CaChup_MaCaChup_key").IsUnique();

            entity.Property(e => e.MaAnhDicom)
                .HasMaxLength(50)
                .HasColumnName("MaAnhDICOM");
            entity.Property(e => e.MaCaChup).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayChup).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaChiTietCt>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuCt).HasName("CLS_CDHA_ChiTietCT_pkey");

            entity.ToTable("CLS_CDHA_ChiTietCT");

            entity.HasIndex(e => e.MaChiTietPhieuCt, "CLS_CDHA_ChiTietCT_MaChiTietPhieuCT_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoChiTietPhieuCt, e.MaChiTietPhieuCt }, "CLS_CDHA_ChiTietCT_MaSoChiTietPhieuCT_MaChiTietPhieuCT_idx");

            entity.Property(e => e.MaSoChiTietPhieuCt).HasColumnName("MaSoChiTietPhieuCT");
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsthucTap).HasColumnName("MaBSThucTap");
            entity.Property(e => e.MaChiTietPhieuCt)
                .HasMaxLength(50)
                .HasColumnName("MaChiTietPhieuCT");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaChiTietMri>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuMri).HasName("CLS_CDHA_ChiTietMRI_pkey");

            entity.ToTable("CLS_CDHA_ChiTietMRI");

            entity.HasIndex(e => e.MaChiTietPhieuMri, "CLS_CDHA_ChiTietMRI_MaChiTietPhieuMRI_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoChiTietPhieuMri, e.MaChiTietPhieuMri }, "CLS_CDHA_ChiTietMRI_MaSoChiTietPhieuMRI_MaChiTietPhieuMRI_idx");

            entity.Property(e => e.MaSoChiTietPhieuMri).HasColumnName("MaSoChiTietPhieuMRI");
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsthucTap).HasColumnName("MaBSThucTap");
            entity.Property(e => e.MaChiTietPhieuMri)
                .HasMaxLength(50)
                .HasColumnName("MaChiTietPhieuMRI");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaChiTietNoiSoi>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietNoiSoi).HasName("CLS_CDHA_ChiTietNoiSoi_pkey");

            entity.ToTable("CLS_CDHA_ChiTietNoiSoi");

            entity.Property(e => e.BsdocKetQua).HasColumnName("BSDocKetQua");
            entity.Property(e => e.Clotest).HasDefaultValue(false);
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.SinhThiet).HasDefaultValue(false);
        });

        modelBuilder.Entity<ClsCdhaChiTietPhieuDoApLucHmtt>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuDoApLucHmtt).HasName("CLS_CDHA_ChiTietPhieuDoApLucHMTT_pkey");

            entity.ToTable("CLS_CDHA_ChiTietPhieuDoApLucHMTT");

            entity.Property(e => e.MaSoPhieuDoApLucHmtt).HasColumnName("MaSoPhieuDoApLucHMTT");
            entity.Property(e => e.BacSiDocKq).HasColumnName("BacSiDocKQ");
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaPhieuDoApLucHmtt)
                .HasMaxLength(50)
                .HasColumnName("MaPhieuDoApLucHMTT");
            entity.Property(e => e.MaSoClsthuocCuaBn).HasColumnName("MaSoCLSThuocCuaBN");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaChiTietPhieuSieuAm>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuSieuAm).HasName("CLS_CDHA_ChiTietPhieuSieuAm_pkey");

            entity.ToTable("CLS_CDHA_ChiTietPhieuSieuAm");

            entity.Property(e => e.BacSiDocKq).HasColumnName("BacSiDocKQ");
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaChiTietPhieuSieuAm).HasMaxLength(50);
            entity.Property(e => e.MaSoThietBi).HasColumnName("MaSoTHietBi");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TaiGiuong).HasDefaultValue(false);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaChiTietPhieuSieuAmTim>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuSieuAmTim).HasName("CLS_CDHA_ChiTietPhieuSieuAmTim_pkey");

            entity.ToTable("CLS_CDHA_ChiTietPhieuSieuAmTim");

            entity.Property(e => e.BacSiDocKq).HasColumnName("BacSiDocKQ");
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaChiTietPhieuSieuAmTim).HasMaxLength(50);
            entity.Property(e => e.MaSoThietBi).HasColumnName("MaSoTHietBi");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TaiGiuong).HasDefaultValue(false);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaChiTietXquang>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuXq).HasName("CLS_CDHA_ChiTietXquang_pkey");

            entity.ToTable("CLS_CDHA_ChiTietXquang");

            entity.HasIndex(e => e.MaChiTietPhieuXq, "CLS_CDHA_ChiTietXquang_MaChiTietPhieuXQ_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoChiTietPhieuXq, e.MaChiTietPhieuXq }, "CLS_CDHA_ChiTietXquang_MaSoChiTietPhieuXQ_MaChiTietPhieuXQ_idx");

            entity.Property(e => e.MaSoChiTietPhieuXq).HasColumnName("MaSoChiTietPhieuXQ");
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsthucTap).HasColumnName("MaBSThucTap");
            entity.Property(e => e.MaChiTietPhieuXq)
                .HasMaxLength(50)
                .HasColumnName("MaChiTietPhieuXQ");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaSatDopplerDongQuaVanBaLa>(entity =>
        {
            entity.HasKey(e => e.MaSoDopplerDongQuaVanBaLa).HasName("CLS_CDHA_SAT_DopplerDongQuaVanBaLa_pkey");

            entity.ToTable("CLS_CDHA_SAT_DopplerDongQuaVanBaLa");

            entity.Property(e => e.MaSoDopplerDongQuaVanBaLa).HasDefaultValueSql("nextval('\"CLS_CDHA_SAT_DopplerDongQuaVanBaL_MaSoDopplerDongQuaVanBaLa_seq\"'::regclass)");
            entity.Property(e => e.HoVan).HasMaxLength(50);
            entity.Property(e => e.MaDopplerDongQuaVanBaLa).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Paps).HasColumnName("PAPs");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaSatDopplerDongQuaVanDongMachChu>(entity =>
        {
            entity.HasKey(e => e.MaSoDopplerDongQuaVanDongMachChu).HasName("CLS_CDHA_SAT_DopplerDongQuaVanDongMachChu_pkey");

            entity.ToTable("CLS_CDHA_SAT_DopplerDongQuaVanDongMachChu");

            entity.Property(e => e.MaSoDopplerDongQuaVanDongMachChu).HasDefaultValueSql("nextval('\"CLS_CDHA_SAT_DopplerDongQuaVa_MaSoDopplerDongQuaVanDongMac_seq1\"'::regclass)");
            entity.Property(e => e.DongBatThuongKhac).HasMaxLength(50);
            entity.Property(e => e.DongQuaVacgLienThat).HasMaxLength(50);
            entity.Property(e => e.DongQuaVachLienNhi).HasMaxLength(50);
            entity.Property(e => e.HepVanDmchu)
                .HasMaxLength(50)
                .HasColumnName("HepVanDMChu");
            entity.Property(e => e.HoHapDmchu)
                .HasMaxLength(50)
                .HasColumnName("HoHapDMChu");
            entity.Property(e => e.MaDopplerDongQuaVanDongMachChu).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaSatDopplerDongQuaVanDongMachPhoi>(entity =>
        {
            entity.HasKey(e => e.MaSoDopplerDongQuaVanDongMachPhoi).HasName("CLS_CDHA_SAT_DopplerDongQuaVanDongMachPhoi_pkey");

            entity.ToTable("CLS_CDHA_SAT_DopplerDongQuaVanDongMachPhoi");

            entity.Property(e => e.MaSoDopplerDongQuaVanDongMachPhoi).HasDefaultValueSql("nextval('\"CLS_CDHA_SAT_DopplerDongQuaVa_MaSoDopplerDongQuaVanDongMach_seq\"'::regclass)");
            entity.Property(e => e.MaDopplerDongQuaVanDongMachPhoi).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Papd).HasColumnName("PAPd");
            entity.Property(e => e.Papm).HasColumnName("PAPm");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaSatDopplerDongQuaVanHaiLa>(entity =>
        {
            entity.HasKey(e => e.MaSoDopplerDongQuaVanHaiLa).HasName("CLS_CDHA_SAT_DopplerDongQuaVanHaiLa_pkey");

            entity.ToTable("CLS_CDHA_SAT_DopplerDongQuaVanHaiLa");

            entity.Property(e => e.MaSoDopplerDongQuaVanHaiLa).HasDefaultValueSql("nextval('\"CLS_CDHA_SAT_DopplerDongQuaVanHa_MaSoDopplerDongQuaVanHaiLa_seq\"'::regclass)");
            entity.Property(e => e.Ea).HasColumnName("EA");
            entity.Property(e => e.MaDopplerDongQuaVanHaiLa).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaSatHaiD>(entity =>
        {
            entity.HasKey(e => e.MaSo2D).HasName("CLS_CDHA_SAT_HaiD_pkey");

            entity.ToTable("CLS_CDHA_SAT_HaiD");

            entity.Property(e => e.ChonIn2D).HasDefaultValue(true);
            entity.Property(e => e.Dmchu)
                .HasMaxLength(50)
                .HasColumnName("DMChu");
            entity.Property(e => e.Dmphoi)
                .HasMaxLength(50)
                .HasColumnName("DMPhoi");
            entity.Property(e => e.Dmvanh)
                .HasMaxLength(50)
                .HasColumnName("DMVanh");
            entity.Property(e => e.Ma2D).HasMaxLength(50);
            entity.Property(e => e.MangNgoaiTim).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhiPhai).HasMaxLength(50);
            entity.Property(e => e.NhiTrai).HasMaxLength(50);
            entity.Property(e => e.TinhMach).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TuTheTim).HasMaxLength(50);
            entity.Property(e => e.VanBaLa).HasMaxLength(50);
            entity.Property(e => e.VanDmc)
                .HasMaxLength(50)
                .HasColumnName("VanDMC");
            entity.Property(e => e.VanDmp)
                .HasMaxLength(50)
                .HasColumnName("VanDMP");
            entity.Property(e => e.VanHaiLa).HasMaxLength(50);
            entity.Property(e => e.XoangVanh).HasMaxLength(50);
        });

        modelBuilder.Entity<ClsCdhaSatMoTaHinhAnh>(entity =>
        {
            entity.HasKey(e => e.MaSoMoTaHinhAnh).HasName("CLS_CDHA_SAT_MoTaHinhAnh_pkey");

            entity.ToTable("CLS_CDHA_SAT_MoTaHinhAnh");

            entity.Property(e => e.MaMoTaHinhAnh).HasMaxLength(50);
            entity.Property(e => e.MaSoTm).HasColumnName("MaSoTM");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsCdhaSatTm>(entity =>
        {
            entity.HasKey(e => e.MaSoTm).HasName("CLS_CDHA_SAT_TM_pkey");

            entity.ToTable("CLS_CDHA_SAT_TM");

            entity.Property(e => e.MaSoTm).HasColumnName("MaSoTM");
            entity.Property(e => e.Dmchu).HasColumnName("DMChu");
            entity.Property(e => e.Ivsd).HasColumnName("IVSd");
            entity.Property(e => e.Ivss).HasColumnName("IVSs");
            entity.Property(e => e.Lvidd).HasColumnName("LVIDd");
            entity.Property(e => e.Lvids).HasColumnName("LVIDs");
            entity.Property(e => e.Lvpwd).HasColumnName("LVPWd");
            entity.Property(e => e.Lvpws).HasColumnName("LVPWs");
            entity.Property(e => e.MaTm)
                .HasMaxLength(50)
                .HasColumnName("MaTM");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Rvdd).HasColumnName("RVDd");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsChamThuThuat>(entity =>
        {
            entity.HasKey(e => e.MaSoChamThuThuat).HasName("CLS_ChamThuThuat_pkey");

            entity.ToTable("CLS_ChamThuThuat");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsChiTietGiaiPhauBenh>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietGiaiPhauBenh).HasName("CLS_ChiTietGiaiPhauBenh_pkey");

            entity.ToTable("CLS_ChiTietGiaiPhauBenh");

            entity.Property(e => e.GioNhanMau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTraKq)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("GioTraKQ");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsdocKetQua).HasColumnName("MaBSDocKetQua");
            entity.Property(e => e.MaChiTietGiaiPhauBenh).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhanXetDaiThe).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.ViTriLaySinhThiet).HasMaxLength(50);
        });

        modelBuilder.Entity<ClsChiTietThuocCuaBn>(entity =>
        {
            entity.HasKey(e => e.MaSoClschiTietThuoc).HasName("CLS_ChiTietThuocCuaBN_pkey");

            entity.ToTable("CLS_ChiTietThuocCuaBN");

            entity.Property(e => e.MaSoClschiTietThuoc).HasColumnName("MaSoCLSChiTietThuoc");
            entity.Property(e => e.MaClschiTietThuoc).HasColumnName("MaCLSChiTietThuoc");
            entity.Property(e => e.MaClsthuocCuaBn).HasColumnName("MaCLSThuocCuaBN");
            entity.Property(e => e.MaSoClsthuocVatTu).HasColumnName("MaSoCLSThuocVatTu");
        });

        modelBuilder.Entity<ClsChiTietTuyDo>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietTuyDoChiTietTuyDo).HasName("CLS_ChiTietTuyDo_pkey");

            entity.ToTable("CLS_ChiTietTuyDo");

            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsdocKetQua).HasColumnName("MaBSDocKetQua");
            entity.Property(e => e.MaChiTietTuyDo).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsDanhGium>(entity =>
        {
            entity.HasKey(e => e.MaSoDanhGia).HasName("CLS_DanhGia_pkey");

            entity.ToTable("CLS_DanhGia");

            entity.Property(e => e.MaDanhGia).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDanhGia).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsDichVuChamThem>(entity =>
        {
            entity.HasKey(e => e.MaSoDichVuChamThem).HasName("CLS_DichVuChamThem_pkey");

            entity.ToTable("CLS_DichVuChamThem");

            entity.Property(e => e.CoHieuLuc).HasDefaultValue(true);
            entity.Property(e => e.GiaDichVuChamThem).HasPrecision(65, 30);
            entity.Property(e => e.MaDichVuChamThem).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDichVuChamThem).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsGpbMauNhuom>(entity =>
        {
            entity.HasKey(e => e.MaSoMauNhuom).HasName("CLS_GPB_MauNhuom_pkey");

            entity.ToTable("CLS_GPB_MauNhuom");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenMauNhuom).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsKio>(entity =>
        {
            entity.HasKey(e => e.MaSoKios).HasName("CLS_Kios_pkey");

            entity.ToTable("CLS_Kios");

            entity.HasIndex(e => e.MaKios, "CLS_Kios_MaKios_key").IsUnique();

            entity.HasIndex(e => e.TenKios, "CLS_Kios_TenKios_key").IsUnique();

            entity.Property(e => e.MaKios).HasMaxLength(50);
            entity.Property(e => e.TenKios).HasMaxLength(250);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsLoaiPhieuChiDinh>(entity =>
        {
            entity.HasKey(e => e.MaSoLoaiPhieuChiDinh).HasName("CLS_LoaiPhieuChiDinh_pkey");

            entity.ToTable("CLS_LoaiPhieuChiDinh");

            entity.HasIndex(e => e.MaLoaiPhieuChiDinh, "CLS_LoaiPhieuChiDinh_MaLoaiPhieuChiDinh_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoLoaiPhieuChiDinh, e.MaLoaiPhieuChiDinh }, "CLS_LoaiPhieuChiDinh_MaSoLoaiPhieuChiDinh_MaLoaiPhieuChiDin_idx");

            entity.Property(e => e.MaLoaiPhieuChiDinh).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenLoai).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmBienBanHuy>(entity =>
        {
            entity.HasKey(e => e.MaSoBienBanHuy).HasName("CLS_NHM_BienBanHuy_pkey");

            entity.ToTable("CLS_NHM_BienBanHuy");

            entity.Property(e => e.ChuThich).HasMaxLength(255);
            entity.Property(e => e.GioDuyet)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioXacNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.HinhAnhBienBan).HasMaxLength(255);
            entity.Property(e => e.LyDo).HasMaxLength(255);
            entity.Property(e => e.MaBienBanHuy).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TrangThaiBbh).HasColumnName("TrangThaiBBH");
        });

        modelBuilder.Entity<ClsNhmChiTietLoMau>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietLoMau).HasName("CLS_NHM_ChiTietLoMau_pkey");

            entity.ToTable("CLS_NHM_ChiTietLoMau");

            entity.Property(e => e.Isbt128).HasColumnName("ISBT128");
            entity.Property(e => e.MaChiTietLoMau).HasMaxLength(50);
            entity.Property(e => e.NgayNhap).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenLoMau).HasMaxLength(150);
        });

        modelBuilder.Entity<ClsNhmChiTietPhieuDangKyMau>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuDangKyMau).HasName("CLS_NHM_ChiTietPhieuDangKyMau_pkey");

            entity.ToTable("CLS_NHM_ChiTietPhieuDangKyMau");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayDuTru).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmDanhMucMau>(entity =>
        {
            entity.HasKey(e => e.MaSoDanhMucMau).HasName("CLS_NHM_DanhMucMau_pkey");

            entity.ToTable("CLS_NHM_DanhMucMau");

            entity.Property(e => e.CoHieuLuc).HasDefaultValue(true);
            entity.Property(e => e.Gia).HasPrecision(65, 30);
            entity.Property(e => e.MaDanhMucMau).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDanhMucMau).HasMaxLength(255);
            entity.Property(e => e.TenVietTatDanhMucMau).HasMaxLength(255);
        });

        modelBuilder.Entity<ClsNhmKho>(entity =>
        {
            entity.HasKey(e => e.MaSoKho).HasName("CLS_NHM_Kho_pkey");

            entity.ToTable("CLS_NHM_Kho");

            entity.Property(e => e.MaKho).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenKho).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmLoMau>(entity =>
        {
            entity.HasKey(e => e.MaSoLoMau).HasName("CLS_NHM_LoMau_pkey");

            entity.ToTable("CLS_NHM_LoMau");

            entity.Property(e => e.MaLoMau).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoBienLai).HasMaxLength(50);
            entity.Property(e => e.TranhThaiHieuLuc).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmLoaiChePham>(entity =>
        {
            entity.HasKey(e => e.MaSoLoaiChePham).HasName("CLS_NHM_LoaiChePham_pkey");

            entity.ToTable("CLS_NHM_LoaiChePham");

            entity.Property(e => e.DichVuPuc).HasColumnName("DichVuPUC");
            entity.Property(e => e.DichVuPucboSung).HasColumnName("DichVuPUCBoSung");
            entity.Property(e => e.DinhNmbangGiay1).HasColumnName("DinhNMBangGiay1");
            entity.Property(e => e.DinhNmbangGiay2).HasColumnName("DinhNMBangGiay2");
            entity.Property(e => e.DuTruDvtheTich)
                .HasDefaultValue(true)
                .HasColumnName("DuTruDVTheTich");
            entity.Property(e => e.LoaiPucth).HasColumnName("LoaiPUCTH");
            entity.Property(e => e.MaLoaiChePham).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.OngAgh).HasColumnName("OngAGH");
            entity.Property(e => e.OngMtmuoi).HasColumnName("OngMTMuoi");
            entity.Property(e => e.PucmacDinh).HasColumnName("PUCMacDinh");
            entity.Property(e => e.TenLoaiChePham).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmLogDangKi>(entity =>
        {
            entity.HasKey(e => e.MaSoLogDangKi).HasName("CLS_NHM_LogDangKi_pkey");

            entity.ToTable("CLS_NHM_LogDangKi");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HanhDong).HasMaxLength(50);
            entity.Property(e => e.MaLogDangKi).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmLogMau>(entity =>
        {
            entity.HasKey(e => e.MaSoLogMau).HasName("CLS_NHM_LogMau_pkey");

            entity.ToTable("CLS_NHM_LogMau");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HanhDong).HasMaxLength(50);
            entity.Property(e => e.MaLogMau).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmLogThuThuat>(entity =>
        {
            entity.HasKey(e => e.MaSoLogThuThuat).HasName("CLS_NHM_LogThuThuat_pkey");

            entity.ToTable("CLS_NHM_LogThuThuat");

            entity.Property(e => e.HanhDong).HasMaxLength(50);
            entity.Property(e => e.MaLogThuThuat).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmLogTuiMau>(entity =>
        {
            entity.HasKey(e => e.MaSoLogTuiMau).HasName("CLS_NHM_LogTuiMau_pkey");

            entity.ToTable("CLS_NHM_LogTuiMau");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HanhDong).HasMaxLength(50);
            entity.Property(e => e.MaLogTuiMau).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmMaSanPhamIsbt>(entity =>
        {
            entity.HasKey(e => e.MaSoMaSanPhamIsbt).HasName("CLS_NHM_MaSanPhamISBT_pkey");

            entity.ToTable("CLS_NHM_MaSanPhamISBT");

            entity.Property(e => e.MaSoMaSanPhamIsbt).HasColumnName("MaSoMaSanPhamISBT");
            entity.Property(e => e.MaMaSanPhamIsbt)
                .HasMaxLength(50)
                .HasColumnName("MaMaSanPhamISBT");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenMaSanPhamIsbt)
                .HasMaxLength(50)
                .HasColumnName("TenMaSanPhamISBT");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmNhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaSoNhaCungCap).HasName("CLS_NHM_NhaCungCap_pkey");

            entity.ToTable("CLS_NHM_NhaCungCap");

            entity.Property(e => e.CoHieuLuc).HasDefaultValue(true);
            entity.Property(e => e.Isbt128)
                .HasDefaultValue(false)
                .HasColumnName("ISBT128");
            entity.Property(e => e.MaNhaCungCap).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(255);
            entity.Property(e => e.TuiMauCuaBenhNhan).HasDefaultValue(false);
        });

        modelBuilder.Entity<ClsNhmNhomMauTheoIsbt>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomMauTheoIsbt).HasName("CLS_NHM_NhomMauTheoISBT_pkey");

            entity.ToTable("CLS_NHM_NhomMauTheoISBT");

            entity.Property(e => e.MaSoNhomMauTheoIsbt).HasColumnName("MaSoNhomMauTheoISBT");
            entity.Property(e => e.MaNhomMauTheoIsbt)
                .HasMaxLength(50)
                .HasColumnName("MaNhomMauTheoISBT");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhomMauTheoIsbt)
                .HasMaxLength(50)
                .HasColumnName("TenNhomMauTheoISBT");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.YeuToRh).HasColumnName("YeuToRH");
        });

        modelBuilder.Entity<ClsNhmPhanLoaiChePham>(entity =>
        {
            entity.HasKey(e => e.MaSoPhanLoaiChePham).HasName("CLS_NHM_PhanLoaiChePham_pkey");

            entity.ToTable("CLS_NHM_PhanLoaiChePham");

            entity.Property(e => e.MaPhanLoaiChePham).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenPhanLoaiChePham).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmPhieuDangKyMau>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuDangKyMau).HasName("CLS_NHM_PhieuDangKyMau_pkey");

            entity.ToTable("CLS_NHM_PhieuDangKyMau");

            entity.Property(e => e.GioDangKy)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MaPhieuDangKyMau).HasMaxLength(50);
            entity.Property(e => e.MaSoChiTietXn).HasColumnName("MaSoChiTietXN");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhanVienXn).HasColumnName("NhanVienXN");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TrangThaiDkm).HasColumnName("TrangThaiDKM");
        });

        modelBuilder.Entity<ClsNhmPhieuHoanKho>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuHoanKho).HasName("CLS_NHM_PhieuHoanKho_pkey");

            entity.ToTable("CLS_NHM_PhieuHoanKho");

            entity.Property(e => e.GioHoanTra)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.LyDo).HasMaxLength(255);
            entity.Property(e => e.LyDoTra).HasMaxLength(255);
            entity.Property(e => e.MaPhieuHoanKho).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsNhmPhieuYeuCauLinh>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuYeuCauLinh).HasName("CLS_NHM_PhieuYeuCauLinh_pkey");

            entity.ToTable("CLS_NHM_PhieuYeuCauLinh");

            entity.Property(e => e.GioXuatKho).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MaXuatKho).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayYeuCau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TgPhatMau).HasColumnType("timestamp(3) without time zone");
        });

        modelBuilder.Entity<ClsNhmTuiMau>(entity =>
        {
            entity.HasKey(e => e.MaSoTuiMau).HasName("CLS_NHM_TuiMau_pkey");

            entity.ToTable("CLS_NHM_TuiMau");

            entity.Property(e => e.ChiTietXuat).HasDefaultValue(true);
            entity.Property(e => e.DangOkho).HasColumnName("DangOKho");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.GioNhap).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.HanDung).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MaSoNhomMauTheoIsbt).HasColumnName("MaSoNhomMauTheoISBT");
            entity.Property(e => e.MaTuiMau).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PhieuDangKi).HasDefaultValue(true);
            entity.Property(e => e.TenTuiMau).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsPhanLoaiNhomDichVu>(entity =>
        {
            entity.HasKey(e => e.MaSoPhanLoaiNhomDichVu).HasName("CLS_PhanLoaiNhomDichVu_pkey");

            entity.ToTable("CLS_PhanLoaiNhomDichVu");

            entity.Property(e => e.MaPhanLoaiNhomDichVu).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenPhanLoaiNhomDichVu).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsPhienLamViec>(entity =>
        {
            entity.HasKey(e => e.MaSoPhienLamViec).HasName("CLS_PhienLamViec_pkey");

            entity.ToTable("CLS_PhienLamViec");

            entity.Property(e => e.AmThanh).HasDefaultValue(true);
            entity.Property(e => e.DiaChiIp)
                .HasMaxLength(255)
                .HasColumnName("DiaChiIP");
            entity.Property(e => e.MaPhienLamViec).HasMaxLength(50);
            entity.Property(e => e.TenPhienLamViec).HasMaxLength(255);
            entity.Property(e => e.TuGoi).HasDefaultValue(false);
        });

        modelBuilder.Entity<ClsPhieuChiDinh>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuChiDinh).HasName("CLS_PhieuChiDinh_pkey");

            entity.ToTable("CLS_PhieuChiDinh");

            entity.HasIndex(e => e.MaPhieuChiDinh, "CLS_PhieuChiDinh_MaPhieuChiDinh_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoPhieuChiDinh, e.MaPhieuChiDinh }, "CLS_PhieuChiDinh_MaSoPhieuChiDinh_MaPhieuChiDinh_idx");

            entity.Property(e => e.ChanDoan).HasMaxLength(255);
            entity.Property(e => e.ChuThich).HasMaxLength(255);
            entity.Property(e => e.GioChiDinh).HasColumnType("timestamp without time zone");
            entity.Property(e => e.MaPhieuChiDinh).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
        });

        modelBuilder.Entity<ClsPhieuYeuCauChinhSua>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuYeuCauChinhSua).HasName("CLS_PhieuYeuCauChinhSua_pkey");

            entity.ToTable("CLS_PhieuYeuCauChinhSua");

            entity.Property(e => e.LyDoChinhSua).HasMaxLength(255);
            entity.Property(e => e.MaPhieuYeuCauChinhSua).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TrangThaiCs).HasColumnName("TrangThaiCS");
        });

        modelBuilder.Entity<ClsSoDaCap>(entity =>
        {
            entity.HasKey(e => e.MaSoDaCap).HasName("CLS_SoDaCap_pkey");

            entity.ToTable("CLS_SoDaCap");

            entity.Property(e => e.GioGoiSo).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioHenKetQua).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioLaySo)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTraKetQua).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Stt).HasColumnName("STT");
        });

        modelBuilder.Entity<ClsTag>(entity =>
        {
            entity.HasKey(e => e.MaSoTags).HasName("CLS_Tags_pkey");

            entity.ToTable("CLS_Tags");

            entity.HasIndex(e => e.MaTags, "CLS_Tags_MaTags_key").IsUnique();

            entity.Property(e => e.MaTags).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdKetQuaTuyDo>(entity =>
        {
            entity.HasKey(e => e.MaSoKetQuaTuyDo).HasName("CLS_TD_KetQuaTuyDo_pkey");

            entity.ToTable("CLS_TD_KetQuaTuyDo");

            entity.Property(e => e.ChatLuongMau).HasMaxLength(50);
            entity.Property(e => e.MaKetQuaTuyDo).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdMoTaTieuBanMauNgoaiVi>(entity =>
        {
            entity.HasKey(e => e.MaSoMoTaTieuBanMauNgoaiVi).HasName("CLS_TD_MoTaTieuBanMauNgoaiVi_pkey");

            entity.ToTable("CLS_TD_MoTaTieuBanMauNgoaiVi");

            entity.Property(e => e.BachCau).HasMaxLength(50);
            entity.Property(e => e.HongCau).HasMaxLength(50);
            entity.Property(e => e.MaMoTaTieuBanMauNgoaiVi).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TieuCau).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdcnChiTietDienCo>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuDienCo).HasName("CLS_TDCN_ChiTietDienCo_pkey");

            entity.ToTable("CLS_TDCN_ChiTietDienCo");

            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsdocKetQua).HasColumnName("MaBSDocKetQua");
            entity.Property(e => e.MaPhieuKetQua).HasMaxLength(50);
            entity.Property(e => e.MaSoClsthuocCuaBn).HasColumnName("MaSoCLSThuocCuaBN");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoCap).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdcnChiTietDienNao>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuDienNao).HasName("CLS_TDCN_ChiTietDienNao_pkey");

            entity.ToTable("CLS_TDCN_ChiTietDienNao");

            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsdocKetQua).HasColumnName("MaBSDocKetQua");
            entity.Property(e => e.MaPhieuKetQua).HasMaxLength(50);
            entity.Property(e => e.MaSoClsthuocCuaBn).HasColumnName("MaSoCLSThuocCuaBN");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoCap).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdcnChiTietDienTim>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietPhieuDienTim).HasName("CLS_TDCN_ChiTietDienTim_pkey");

            entity.ToTable("CLS_TDCN_ChiTietDienTim");

            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InLanDau).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaBsdocKetQua).HasColumnName("MaBSDocKetQua");
            entity.Property(e => e.MaPhieuKetQua).HasMaxLength(50);
            entity.Property(e => e.MaSoClsthuocCuaBn).HasColumnName("MaSoCLSThuocCuaBN");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoCap).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdcnChiTietDoCnhoHap>(entity =>
        {
            entity.HasKey(e => e.MaSoChiTietDoCnhoHap).HasName("CLS_TDCN_ChiTietDoCNHoHap_pkey");

            entity.ToTable("CLS_TDCN_ChiTietDoCNHoHap");

            entity.Property(e => e.MaSoChiTietDoCnhoHap).HasColumnName("MaSoChiTietDoCNHoHap");
            entity.Property(e => e.BsdocKetQua).HasColumnName("BSDocKetQua");
            entity.Property(e => e.GioThucHien).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GioTiepNhan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaChiTietDoCnhoHap)
                .HasMaxLength(50)
                .HasColumnName("MaChiTietDoCNHoHap");
            entity.Property(e => e.MaSoClsthuocCuaBn).HasColumnName("MaSoCLSThuocCuaBN");
        });

        modelBuilder.Entity<ClsTdcnDienCoKetQuaDienCoKim>(entity =>
        {
            entity.HasKey(e => e.MaSoKetQuaDienCoKim).HasName("CLS_TDCN_DienCo_KetQuaDienCoKim_pkey");

            entity.ToTable("CLS_TDCN_DienCo_KetQuaDienCoKim");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TuPhat).HasMaxLength(50);
        });

        modelBuilder.Entity<ClsTdcnDienCoKetQuaDttkcamGiac>(entity =>
        {
            entity.HasKey(e => e.MaSoKetQuaDttkcamGiac).HasName("CLS_TDCN_DienCo_KetQuaDTTKCamGiac_pkey");

            entity.ToTable("CLS_TDCN_DienCo_KetQuaDTTKCamGiac");

            entity.Property(e => e.MaSoKetQuaDttkcamGiac).HasColumnName("MaSoKetQuaDTTKCamGiac");
            entity.Property(e => e.BienDo).HasMaxLength(50);
            entity.Property(e => e.Dsl).HasColumnName("DSL");
            entity.Property(e => e.MaKetQuaDttkcamGiac).HasColumnName("MaKetQuaDTTKCamGiac");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Scv)
                .HasMaxLength(50)
                .HasColumnName("SCV");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdcnDienCoKetQuaDttkvanDong>(entity =>
        {
            entity.HasKey(e => e.MaSoKetQuaDttkvanDong).HasName("CLS_TDCN_DienCo_KetQuaDTTKVanDong_pkey");

            entity.ToTable("CLS_TDCN_DienCo_KetQuaDTTKVanDong");

            entity.Property(e => e.MaSoKetQuaDttkvanDong).HasColumnName("MaSoKetQuaDTTKVanDong");
            entity.Property(e => e.Dml).HasColumnName("DML");
            entity.Property(e => e.MaKetQuaDttkvanDong).HasColumnName("MaKetQuaDTTKVanDong");
            entity.Property(e => e.Mvc)
                .HasMaxLength(50)
                .HasColumnName("MVC");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SongFlatency)
                .HasMaxLength(50)
                .HasColumnName("SongFLatency");
            entity.Property(e => e.SongFratio)
                .HasMaxLength(50)
                .HasColumnName("SongFRatio");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsTdcnDienCoKetQuaHstgtiemCoTay>(entity =>
        {
            entity.HasKey(e => e.MaSoKetQuaHstgtiemCoTay).HasName("CLS_TDCN_DienCo_KetQuaHSTGTiemCoTay_pkey");

            entity.ToTable("CLS_TDCN_DienCo_KetQuaHSTGTiemCoTay");

            entity.Property(e => e.MaSoKetQuaHstgtiemCoTay).HasColumnName("MaSoKetQuaHSTGTiemCoTay");
            entity.Property(e => e.GiaTriSoSanh).HasMaxLength(50);
            entity.Property(e => e.MaKetQuaHstgtiemCoTay).HasColumnName("MaKetQuaHSTGTiemCoTay");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TayPhai).HasMaxLength(50);
            entity.Property(e => e.TayTrai).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ClsThuocCuaBn>(entity =>
        {
            entity.HasKey(e => e.MaSoClsthuocCuaBn).HasName("CLS_ThuocCuaBN_pkey");

            entity.ToTable("CLS_ThuocCuaBN");

            entity.Property(e => e.MaSoClsthuocCuaBn).HasColumnName("MaSoCLSThuocCuaBN");
            entity.Property(e => e.KtvthucHien).HasColumnName("KTVThucHien");
            entity.Property(e => e.MaClsthuocCuaBn)
                .HasMaxLength(255)
                .HasColumnName("MaCLSThuocCuaBN");
            entity.Property(e => e.NgayDung).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TongTien).HasPrecision(65, 30);
        });

        modelBuilder.Entity<ClsThuocVatTu>(entity =>
        {
            entity.HasKey(e => e.MaSoClsthuocVatTu).HasName("CLS_ThuocVatTu_pkey");

            entity.ToTable("CLS_ThuocVatTu");

            entity.Property(e => e.MaSoClsthuocVatTu).HasColumnName("MaSoCLSThuocVatTu");
            entity.Property(e => e.CoHieuLuc).HasDefaultValue(true);
            entity.Property(e => e.GiaTien).HasPrecision(65, 30);
            entity.Property(e => e.Hisid).HasColumnName("HISId");
            entity.Property(e => e.Hu).HasDefaultValue(false);
            entity.Property(e => e.In).HasDefaultValue(false);
            entity.Property(e => e.MaClsthuocVatTu).HasColumnName("MaCLSThuocVatTu");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoChan).HasDefaultValue(false);
            entity.Property(e => e.Test).HasDefaultValue(false);
        });

        modelBuilder.Entity<CoSo>(entity =>
        {
            entity.HasKey(e => e.MaSoCoSo).HasName("CoSo_pkey");

            entity.ToTable("CoSo");

            entity.Property(e => e.MaCoSo).HasMaxLength(50);
            entity.Property(e => e.MoTaTiengAnh).HasMaxLength(255);
            entity.Property(e => e.MoTaTiengViet).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TruSo).HasDefaultValue(0);
        });

        modelBuilder.Entity<CongTy>(entity =>
        {
            entity.HasKey(e => e.MaCongTy).HasName("CongTy_pkey");

            entity.ToTable("CongTy");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenCongTy).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DanToc>(entity =>
        {
            entity.HasKey(e => e.MaDanToc).HasName("DanToc_pkey");

            entity.ToTable("DanToc");

            entity.HasIndex(e => e.MaDanToc, "DanToc_MaDanToc_key").IsUnique();

            entity.Property(e => e.MaDanToc).ValueGeneratedNever();
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDanToc).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DangBaoChe>(entity =>
        {
            entity.HasKey(e => e.MaSoDangBaoChe).HasName("DangBaoChe_pkey");

            entity.ToTable("DangBaoChe");

            entity.Property(e => e.GhiChu).HasMaxLength(1024);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(1024);
            entity.Property(e => e.TenTiengViet).HasMaxLength(1024);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DangKyCaKham>(entity =>
        {
            entity.HasKey(e => e.MaDangKyCaKham).HasName("DangKyCaKham_pkey");

            entity.ToTable("DangKyCaKham");

            entity.HasIndex(e => new { e.MaCa, e.MaKhuVuc }, "DangKyCaKham_MaCa_MaKhuVuc_idx");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DangKyCaNhaThuoc>(entity =>
        {
            entity.HasKey(e => e.MaDangKyCaNhaThuoc).HasName("DangKyCaNhaThuoc_pkey");

            entity.ToTable("DangKyCaNhaThuoc");

            entity.HasIndex(e => new { e.MaCa, e.MaNhaThuoc }, "DangKyCaNhaThuoc_MaCa_MaNhaThuoc_idx");

            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DanhMucHoatChatThuoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DanhMucHoatChatThuoc");

            entity.HasIndex(e => e.MaChiTietHoatChatThuoc, "DanhMucHoatChatThuoc_MaChiTietHoatChatThuoc_key").IsUnique();

            entity.Property(e => e.HamLuong).HasMaxLength(255);
            entity.Property(e => e.HamLuongDonViTinhText).HasMaxLength(255);
            entity.Property(e => e.HamLuongGoc).HasMaxLength(255);
            entity.Property(e => e.MaChiTietHoatChatThuoc).ValueGeneratedOnAdd();
            entity.Property(e => e.MaThuoc).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenHoatChat).HasMaxLength(255);
            entity.Property(e => e.TenThuoc).HasMaxLength(255);
            entity.Property(e => e.TheTich).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DanhMucThanhVienKiemDuyet>(entity =>
        {
            entity.HasKey(e => e.MaSoThanhVienKiemDuyet).HasName("DanhMucThanhVienKiemDuyet_pkey");

            entity.ToTable("DanhMucThanhVienKiemDuyet");
        });

        modelBuilder.Entity<DanhMucThuocThau>(entity =>
        {
            entity.HasKey(e => e.MaSoDanhMucThuocThau).HasName("DanhMucThuocThau_pkey");

            entity.ToTable("DanhMucThuocThau");

            entity.Property(e => e.BhytnhaThau)
                .HasMaxLength(255)
                .HasColumnName("BHYTNhaThau");
            entity.Property(e => e.BhytsoDangKyQuyetDinh)
                .HasMaxLength(255)
                .HasColumnName("BHYTSoDangKyQuyetDinh");
            entity.Property(e => e.BhytsoLuong).HasColumnName("BHYTSoLuong");
            entity.Property(e => e.DonViTinh).HasMaxLength(255);
            entity.Property(e => e.GiaBhyt)
                .HasPrecision(65, 30)
                .HasColumnName("GiaBHYT");
            entity.Property(e => e.GiaNhapSauThue).HasPrecision(65, 30);
            entity.Property(e => e.GiaThanhToan).HasPrecision(65, 30);
            entity.Property(e => e.GoiThauBhyt)
                .HasMaxLength(255)
                .HasColumnName("GoiThauBHYT");
            entity.Property(e => e.HamLuong).HasMaxLength(255);
            entity.Property(e => e.HangSanXuat).HasMaxLength(255);
            entity.Property(e => e.MaDuongDung).HasMaxLength(255);
            entity.Property(e => e.MaThuocBh)
                .HasMaxLength(255)
                .HasColumnName("MaThuocBH");
            entity.Property(e => e.NgayApDung).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhomChiPhiBh)
                .HasMaxLength(255)
                .HasColumnName("NhomChiPhiBH");
            entity.Property(e => e.NhomThau).HasMaxLength(255);
            entity.Property(e => e.NuocSanXuat).HasMaxLength(255);
            entity.Property(e => e.PhanNhomBhyt)
                .HasMaxLength(255)
                .HasColumnName("PhanNhomBHYT");
            entity.Property(e => e.TenDocQuyen).HasMaxLength(255);
            entity.Property(e => e.TenThuocBh)
                .HasMaxLength(1024)
                .HasColumnName("TenThuocBH");
            entity.Property(e => e.TenThuocThuongMai).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TyLeThanhToan).HasMaxLength(255);
        });

        modelBuilder.Entity<DanhSachThuocBhyt>(entity =>
        {
            entity.HasKey(e => e.MaDanhSachThuocBhyt).HasName("DanhSachThuocBHYT_pkey");

            entity.ToTable("DanhSachThuocBHYT");

            entity.HasIndex(e => new { e.MaNhomBhyt, e.MaThuoc }, "DanhSachThuocBHYT_MaNhomBHYT_MaThuoc_idx");

            entity.Property(e => e.MaDanhSachThuocBhyt).HasColumnName("MaDanhSachThuocBHYT");
            entity.Property(e => e.MaNhomBhyt).HasColumnName("MaNhomBHYT");
        });

        modelBuilder.Entity<DiaChi>(entity =>
        {
            entity.HasKey(e => e.MaSoDiaChi).HasName("DiaChi_pkey");

            entity.ToTable("DiaChi");

            entity.HasIndex(e => new { e.MaTinh, e.MaQuanHuyen, e.MaPhuongXa }, "DiaChi_MaTinh_MaQuanHuyen_MaPhuongXa_idx");

            entity.Property(e => e.DiaChi1)
                .HasMaxLength(1024)
                .HasColumnName("DiaChi");
            entity.Property(e => e.DiaChiDayDu).HasMaxLength(1024);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DichVuDangGoi>(entity =>
        {
            entity.HasKey(e => e.MaSoDichVuDangGoi).HasName("DichVuDangGoi_pkey");

            entity.ToTable("DichVuDangGoi");

            entity.HasIndex(e => e.MaDichVuDangGoi, "DichVuDangGoi_MaDichVuDangGoi_key").IsUnique();

            entity.Property(e => e.MaDichVuDangGoi).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDichVuDangGoi).HasMaxLength(255);
        });

        modelBuilder.Entity<DichVuKham>(entity =>
        {
            entity.HasKey(e => e.MaSoDichVuBenhVien).HasName("DichVuKham_pkey");

            entity.ToTable("DichVuKham");

            entity.HasIndex(e => e.MaDichVuBenhVien, "DichVuKham_MaDichVuBenhVien_key").IsUnique();

            entity.Property(e => e.ApDungChoGioiTinh).HasDefaultValue(0);
            entity.Property(e => e.DoiLoaiPhuongThuc).HasDefaultValue(true);
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.GiaBhyttv)
                .HasPrecision(65, 30)
                .HasColumnName("GiaBHYTTV");
            entity.Property(e => e.GiaChatLuongCao).HasPrecision(65, 30);
            entity.Property(e => e.GiaChoBhyt)
                .HasPrecision(65, 30)
                .HasColumnName("GiaChoBHYT");
            entity.Property(e => e.GiaChuan).HasPrecision(65, 30);
            entity.Property(e => e.GiaCoDinh).HasDefaultValue(true);
            entity.Property(e => e.GiaKhac).HasPrecision(65, 30);
            entity.Property(e => e.GiaNgoaiGio).HasPrecision(65, 30);
            entity.Property(e => e.GiaToiDa).HasPrecision(65, 30);
            entity.Property(e => e.LoaiBaoHiem).HasDefaultValue(0);
            entity.Property(e => e.MaDichVuBenhVien).HasMaxLength(50);
            entity.Property(e => e.MoKhoa).HasDefaultValue(true);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDichVuBenhVien).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TuDongSanXuat).HasDefaultValue(true);
        });

        modelBuilder.Entity<DichVuMacDinh>(entity =>
        {
            entity.HasKey(e => e.MaSoDichVuMacDinh).HasName("DichVuMacDinh_pkey");

            entity.ToTable("DichVuMacDinh");

            entity.HasIndex(e => e.MaDichVu, "DichVuMacDinh_MaDichVu_idx");

            entity.HasIndex(e => e.MaKhuVuc, "DichVuMacDinh_MaKhuVuc_idx");
        });

        modelBuilder.Entity<DichVuTheoChuyenMon>(entity =>
        {
            entity.HasKey(e => e.MaSoDichVuTheoChuyenMon).HasName("DichVuTheoChuyenMon_pkey");

            entity.ToTable("DichVuTheoChuyenMon");

            entity.HasIndex(e => e.MaDichVuTheoChuyenMon, "DichVuTheoChuyenMon_MaDichVuTheoChuyenMon_key").IsUnique();

            entity.Property(e => e.MaDichVuTheoChuyenMon).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDichVuTheoChuyenMon).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DichVuThongTu37>(entity =>
        {
            entity.HasKey(e => e.MaSoDichVuThongTu37).HasName("DichVuThongTu37_pkey");

            entity.ToTable("DichVuThongTu37");

            entity.HasIndex(e => e.MaDichVuThongTu37, "DichVuThongTu37_MaDichVuThongTu37_key").IsUnique();

            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaDichVu).HasPrecision(65, 30);
            entity.Property(e => e.HieuLuc).HasDefaultValue(true);
            entity.Property(e => e.MaDichVuThongTu37).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayCongBo).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDichVu).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DichVuThongTu43>(entity =>
        {
            entity.HasKey(e => e.MaSoDichVuThongTu43).HasName("DichVuThongTu43_pkey");

            entity.ToTable("DichVuThongTu43");

            entity.HasIndex(e => e.MaDichVuThongTu43, "DichVuThongTu43_MaDichVuThongTu43_key").IsUnique();

            entity.Property(e => e.Chuong).HasMaxLength(50);
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.GiaCoDinh).HasDefaultValue(true);
            entity.Property(e => e.GiaDichVu).HasPrecision(65, 30);
            entity.Property(e => e.HieuLuc).HasDefaultValue(true);
            entity.Property(e => e.MaDichVuThongTu43).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayCongBo).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDichVu).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DoiTuong>(entity =>
        {
            entity.HasKey(e => e.MaSoDoiTuong).HasName("DoiTuong_pkey");

            entity.ToTable("DoiTuong");

            entity.Property(e => e.MaDoiTuong).HasMaxLength(3);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDoiTuong).HasMaxLength(55);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DonVi>(entity =>
        {
            entity.HasKey(e => e.MaSoDonVi).HasName("DonVi_pkey");

            entity.ToTable("DonVi");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDonVi).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DotKham>(entity =>
        {
            entity.HasKey(e => e.MaSoDotKham).HasName("DotKham_pkey");

            entity.ToTable("DotKham");

            entity.HasIndex(e => new { e.MaDotKham, e.MaKhoa, e.MaBenhNhan, e.TenDotKham, e.LoaiKhamBenh, e.LoaiBenhNhan }, "DotKham_MaDotKham_MaKhoa_MaBenhNhan_TenDotKham_LoaiKhamBenh_idx");

            entity.HasIndex(e => e.MaSoDotKham, "DotKham_MaSoDotKham_key").IsUnique();

            entity.Property(e => e.MaDotKham).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenDotKham).HasMaxLength(45);
            entity.Property(e => e.ThoiGianBatDau)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ThoiGianKetThuc).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ThoiGianTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<DuongDung>(entity =>
        {
            entity.HasKey(e => e.MaSoDuongDung).HasName("DuongDung_pkey");

            entity.ToTable("DuongDung");

            entity.HasIndex(e => e.MaDuongDung, "DuongDung_MaDuongDung_key").IsUnique();

            entity.Property(e => e.CachDung).HasMaxLength(1024);
            entity.Property(e => e.MaDuongDung).HasMaxLength(4);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<GoiKham>(entity =>
        {
            entity.HasKey(e => e.MaSoGoiKham).HasName("GoiKham_pkey");

            entity.ToTable("GoiKham");

            entity.HasIndex(e => e.MaGoiKham, "GoiKham_MaGoiKham_key").IsUnique();

            entity.Property(e => e.MaGoiKham).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenGoiKham).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(false);
            entity.Property(e => e.XacNhanSanSang).HasDefaultValue(false);
        });

        modelBuilder.Entity<HangChoBenhNhan>(entity =>
        {
            entity.HasKey(e => e.MaSoHangChoBenhNhan).HasName("HangChoBenhNhan_pkey");

            entity.ToTable("HangChoBenhNhan");

            entity.HasIndex(e => e.MaHangChoBenhNhan, "HangChoBenhNhan_MaHangChoBenhNhan_key").IsUnique();

            entity.Property(e => e.MaHangChoBenhNhan).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenHangChoBenhNhan).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<HangSanXuat>(entity =>
        {
            entity.HasKey(e => e.MaSoHangSanXuat).HasName("HangSanXuat_pkey");

            entity.ToTable("HangSanXuat");

            entity.HasIndex(e => e.MaHangSanXuat, "HangSanXuat_MaHangSanXuat_key").IsUnique();

            entity.HasIndex(e => e.MaQuocGia, "HangSanXuat_MaQuocGia_key").IsUnique();

            entity.Property(e => e.DiaChi).HasMaxLength(1024);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.MaHangSanXuat).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenHangSanXuat).HasMaxLength(255);
            entity.Property(e => e.TenQuocGiaTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.Website).HasMaxLength(255);
        });

        modelBuilder.Entity<HoSoBenhAn>(entity =>
        {
            entity.HasKey(e => e.MaHoSoBenhAn).HasName("HoSoBenhAn_pkey");

            entity.ToTable("HoSoBenhAn");

            entity.HasIndex(e => new { e.MaDotKham, e.NgayTao, e.TrangThai, e.HoSoXuatNhapVien }, "HoSoBenhAn_MaDotKham_NgayTao_TrangThai_HoSoXuatNhapVien_idx");

            entity.HasIndex(e => e.MaHoSoBenhAn, "HoSoBenhAn_MaHoSoBenhAn_key").IsUnique();

            entity.Property(e => e.BieuHienLamSang).HasMaxLength(255);
            entity.Property(e => e.CanNang).HasPrecision(65, 30);
            entity.Property(e => e.ChanDoan).HasMaxLength(255);
            entity.Property(e => e.ChiSoPa)
                .HasPrecision(65, 30)
                .HasColumnName("ChiSoPA");
            entity.Property(e => e.ChiSoPt)
                .HasPrecision(65, 30)
                .HasColumnName("ChiSoPT");
            entity.Property(e => e.ChiSoTa)
                .HasPrecision(65, 30)
                .HasColumnName("ChiSoTA");
            entity.Property(e => e.ChieuCao).HasPrecision(65, 30);
            entity.Property(e => e.HuyetAp).HasPrecision(65, 30);
            entity.Property(e => e.NhietDo).HasPrecision(65, 30);
            entity.Property(e => e.NhipTim).HasPrecision(65, 30);
            entity.Property(e => e.TrangThai).HasDefaultValue(false);
        });

        modelBuilder.Entity<HoSoXuatNhapVien>(entity =>
        {
            entity.HasKey(e => e.MaSoHoSoXuatNhapVien).HasName("HoSoXuatNhapVien_pkey");

            entity.ToTable("HoSoXuatNhapVien");

            entity.HasIndex(e => e.MaSoHoSoXuatNhapVien, "HoSoXuatNhapVien_MaSoHoSoXuatNhapVien_key").IsUnique();

            entity.Property(e => e.MaHoSoXuatNhapVien).HasMaxLength(50);
            entity.Property(e => e.NgayRa).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayVao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
        });

        modelBuilder.Entity<HoaDonDienTu>(entity =>
        {
            entity.HasKey(e => e.MaSoHoaDonDienTu).HasName("HoaDonDienTu_pkey");

            entity.ToTable("HoaDonDienTu");

            entity.HasIndex(e => new { e.MaBenhNhan, e.LoaiHoaDon, e.MaNhaThuoc }, "HoaDonDienTu_MaBenhNhan_LoaiHoaDon_MaNhaThuoc_idx");

            entity.HasIndex(e => e.MaKhoaHoaDon, "HoaDonDienTu_MaKhoaHoaDon_key").IsUnique();

            entity.Property(e => e.MaBenhNhan).HasMaxLength(17);
            entity.Property(e => e.MaKhoaHoaDon).HasMaxLength(255);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TongTien).HasPrecision(65, 30);
        });

        modelBuilder.Entity<HoatChat>(entity =>
        {
            entity.HasKey(e => e.MaSoHoatChatThuoc).HasName("HoatChat_pkey");

            entity.ToTable("HoatChat");

            entity.HasIndex(e => e.MaHoatChat, "HoatChat_MaHoatChat_key").IsUnique();

            entity.HasIndex(e => e.TenHoatChat, "HoatChat_TenHoatChat_key").IsUnique();

            entity.Property(e => e.ChiDinh).HasMaxLength(255);
            entity.Property(e => e.ChongChiDinh).HasMaxLength(255);
            entity.Property(e => e.DuocDongLuc).HasMaxLength(255);
            entity.Property(e => e.DuocLuc).HasMaxLength(255);
            entity.Property(e => e.HoatChatDacBiet).HasDefaultValue(false);
            entity.Property(e => e.KiemSoat).HasDefaultValue(false);
            entity.Property(e => e.MaHoatChat).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TacDung).HasMaxLength(255);
            entity.Property(e => e.TenHoatChat).HasMaxLength(255);
            entity.Property(e => e.ToiDa1LanSd).HasColumnName("ToiDa1LanSD");
            entity.Property(e => e.ToiDa1LanSdcanNang).HasColumnName("ToiDa1LanSDCanNang");
            entity.Property(e => e.ToiDa1NgaySd).HasColumnName("ToiDa1NgaySD");
            entity.Property(e => e.ToiDa1NgaySdcanNang).HasColumnName("ToiDa1NgaySDCanNang");
            entity.Property(e => e.ToiThieu1LanSdcanNang).HasColumnName("ToiThieu1LanSDCanNang");
            entity.Property(e => e.ToiThieu1NgaySdcanNang).HasColumnName("ToiThieu1NgaySDCanNang");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<HopDongThau>(entity =>
        {
            entity.HasKey(e => e.MaSoHopDongThau).HasName("HopDongThau_pkey");

            entity.ToTable("HopDongThau");

            entity.HasIndex(e => e.MaHopDongThau, "HopDongThau_MaHopDongThau_key").IsUnique();

            entity.Property(e => e.CodeNhaCungCap).HasMaxLength(100);
            entity.Property(e => e.FileUrl).HasMaxLength(255);
            entity.Property(e => e.MaHopDongThau).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayHetHan).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayHieuLuc).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayKy).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhomChiPhiBh).HasColumnName("NhomChiPhiBH");
            entity.Property(e => e.SoHopDongThau).HasMaxLength(100);
            entity.Property(e => e.SoQuyetDinhVanBan).HasMaxLength(255);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(255);
        });

        modelBuilder.Entity<HuongDan>(entity =>
        {
            entity.HasKey(e => e.MaSoHuongDan).HasName("HuongDan_pkey");

            entity.ToTable("HuongDan");

            entity.Property(e => e.CoHieuLuc).HasDefaultValue(true);
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.MaHuongDan).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TapTin).HasMaxLength(50);
            entity.Property(e => e.TenHuongDan).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<Icd10>(entity =>
        {
            entity.HasKey(e => e.MaSoIcd10).HasName("ICD10_pkey");

            entity.ToTable("ICD10");

            entity.HasIndex(e => e.MaIcd10, "ICD10_MaICD10_key").IsUnique();

            entity.HasIndex(e => e.TenTiengViet, "ICD10_TenTiengViet_idx");

            entity.Property(e => e.MaSoIcd10).HasColumnName("MaSoICD10");
            entity.Property(e => e.BenhManTinh).HasDefaultValue(2);
            entity.Property(e => e.BenhThuongGap).HasDefaultValue(2);
            entity.Property(e => e.CanhBao).HasDefaultValue(false);
            entity.Property(e => e.ChuyenKhoa).HasMaxLength(50);
            entity.Property(e => e.GioiTinh).HasDefaultValue(0);
            entity.Property(e => e.Icd10daiDien)
                .HasDefaultValue(false)
                .HasColumnName("ICD10DaiDien");
            entity.Property(e => e.MaIcd10)
                .HasMaxLength(45)
                .HasColumnName("MaICD10");
            entity.Property(e => e.MaLoaiIcd10).HasColumnName("MaLoaiICD10");
            entity.Property(e => e.MaNhomIcd10).HasColumnName("MaNhomICD10");
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgaySuDungThuoc).HasDefaultValue(0);
            entity.Property(e => e.NgaySuDungThuocNgoaiTru).HasDefaultValue(0);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgoaiDanhSach).HasDefaultValue(2);
            entity.Property(e => e.NhapVien).HasDefaultValue(true);
            entity.Property(e => e.TenThongTu).HasMaxLength(255);
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.ThuocBaoHiemYte)
                .HasDefaultValue(2)
                .HasColumnName("ThuocBaoHiemYTe");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<Icd10nhomBhyt>(entity =>
        {
            entity.HasKey(e => e.MaSoIcdnhomBhyt).HasName("ICD10NhomBHYT_pkey");

            entity.ToTable("ICD10NhomBHYT");

            entity.HasIndex(e => new { e.MaNhomBhyt, e.MaIcd10 }, "ICD10NhomBHYT_MaNhomBHYT_MaICD10_idx");

            entity.Property(e => e.MaSoIcdnhomBhyt).HasColumnName("MaSoICDNhomBHYT");
            entity.Property(e => e.MaIcd10).HasColumnName("MaICD10");
            entity.Property(e => e.MaNhomBhyt).HasColumnName("MaNhomBHYT");
        });

        modelBuilder.Entity<Icd9>(entity =>
        {
            entity.HasKey(e => e.MaSoIcd9).HasName("ICD9_pkey");

            entity.ToTable("ICD9");

            entity.HasIndex(e => e.MaIcd9, "ICD9_MaICD9_key").IsUnique();

            entity.HasIndex(e => e.TenTiengViet, "ICD9_TenTiengViet_idx");

            entity.Property(e => e.MaSoIcd9).HasColumnName("MaSoICD9");
            entity.Property(e => e.GioiTinh).HasDefaultValue(0);
            entity.Property(e => e.Icd9daiDien)
                .HasDefaultValue(false)
                .HasColumnName("ICD9DaiDien");
            entity.Property(e => e.MaIcd9)
                .HasMaxLength(45)
                .HasColumnName("MaICD9");
            entity.Property(e => e.MaNhomIcd9).HasColumnName("MaNhomICD9");
            entity.Property(e => e.MaPhanLoaiIcd9).HasColumnName("MaPhanLoaiICD9");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgoaiDanhSach).HasDefaultValue(2);
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.ThuocBaoHiemYte)
                .HasDefaultValue(2)
                .HasColumnName("ThuocBaoHiemYTe");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<Kho>(entity =>
        {
            entity.HasKey(e => e.MaSoKho).HasName("Kho_pkey");

            entity.ToTable("Kho");

            entity.Property(e => e.MaKho).HasMaxLength(255);
            entity.Property(e => e.MaLoaiThuocNguyenLieuYte).HasColumnName("MaLoaiThuocNguyenLieuYTe");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaSoKhoa).HasName("Khoa_pkey");

            entity.ToTable("Khoa");

            entity.HasIndex(e => e.MaKhoa, "Khoa_MaKhoa_key").IsUnique();

            entity.HasIndex(e => new { e.MaKhoi, e.MaKhoaBhyt, e.CoPhauThuat }, "Khoa_MaKhoi_MaKhoaBHYT_CoPhauThuat_idx");

            entity.Property(e => e.CoPhauThuat).HasDefaultValue(false);
            entity.Property(e => e.MaKhoa).HasMaxLength(15);
            entity.Property(e => e.MaKhoaBhyt).HasColumnName("MaKhoaBHYT");
            entity.Property(e => e.MoTaTiengAnh).HasMaxLength(255);
            entity.Property(e => e.MoTaTiengViet).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenKhoaTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenKhoaTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<KhoaBhyt>(entity =>
        {
            entity.HasKey(e => e.MaSoKhoaBhyt).HasName("KhoaBHYT_pkey");

            entity.ToTable("KhoaBHYT");

            entity.HasIndex(e => e.MaKhoaBhyt, "KhoaBHYT_MaKhoaBHYT_key").IsUnique();

            entity.Property(e => e.MaSoKhoaBhyt).HasColumnName("MaSoKhoaBHYT");
            entity.Property(e => e.MaKhoaBhyt)
                .HasMaxLength(15)
                .HasColumnName("MaKhoaBHYT");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<Khoi>(entity =>
        {
            entity.HasKey(e => e.MaKhoi).HasName("Khoi_pkey");

            entity.ToTable("Khoi");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenKhoi).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<KhuVuc>(entity =>
        {
            entity.HasKey(e => e.MaSoKhuVuc).HasName("KhuVuc_pkey");

            entity.ToTable("KhuVuc");

            entity.HasIndex(e => e.MaKhoa, "KhuVuc_MaKhoa_idx");

            entity.HasIndex(e => e.MaKhuVuc, "KhuVuc_MaKhuVuc_key").IsUnique();

            entity.Property(e => e.ChoPhepBhyt)
                .HasDefaultValue(false)
                .HasColumnName("ChoPhepBHYT");
            entity.Property(e => e.ChoPhepCa).HasDefaultValue(true);
            entity.Property(e => e.KhuVacXin).HasDefaultValue(false);
            entity.Property(e => e.LaKhuNhanBenh).HasDefaultValue(false);
            entity.Property(e => e.LoaiGiaTien).HasMaxLength(30);
            entity.Property(e => e.MaKhuVuc).HasMaxLength(30);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PhuongThucThanhToan).HasDefaultValue(0);
            entity.Property(e => e.Tang).HasMaxLength(30);
            entity.Property(e => e.TenKhuVuc).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.VanBan).HasMaxLength(255);
        });

        modelBuilder.Entity<KieuKetQua>(entity =>
        {
            entity.HasKey(e => e.MaSoKieuKetQua).HasName("KieuKetQua_pkey");

            entity.ToTable("KieuKetQua");

            entity.HasIndex(e => e.MaKieuKetQua, "KieuKetQua_MaKieuKetQua_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoKieuKetQua, e.MaKieuKetQua }, "KieuKetQua_MaSoKieuKetQua_MaKieuKetQua_idx");

            entity.Property(e => e.MaKieuKetQua).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenKieuKetQua).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LichHen>(entity =>
        {
            entity.HasKey(e => e.MaLichHen).HasName("LichHen_pkey");

            entity.ToTable("LichHen");

            entity.HasIndex(e => e.MaDotKham, "LichHen_MaDotKham_key").IsUnique();

            entity.HasIndex(e => new { e.TenBenhNhan, e.SdtDangKy, e.MaPhong }, "LichHen_TenBenhNhan_SdtDangKy_MaPhong_idx");

            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgaySinh).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenBenhNhan).HasMaxLength(255);
            entity.Property(e => e.ThoiGianKham).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LoaiDichVu>(entity =>
        {
            entity.HasKey(e => e.MaSoLoaiDichVu).HasName("LoaiDichVu_pkey");

            entity.ToTable("LoaiDichVu");

            entity.HasIndex(e => e.MaLoaiDichVu, "LoaiDichVu_MaLoaiDichVu_key").IsUnique();

            entity.Property(e => e.MaLoaiDichVu).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhomDichVuTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenNhomDichVuTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LoaiDonVi>(entity =>
        {
            entity.HasKey(e => e.MaSoLoaiDonVi).HasName("LoaiDonVi_pkey");

            entity.ToTable("LoaiDonVi");

            entity.Property(e => e.ChuThichLoaiDonVi).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenLoaiDonVi).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LoaiIcd10>(entity =>
        {
            entity.HasKey(e => e.MaSoLoaiIcd10).HasName("LoaiICD10_pkey");

            entity.ToTable("LoaiICD10");

            entity.HasIndex(e => e.MaLoaiIcd10, "LoaiICD10_MaLoaiICD10_key").IsUnique();

            entity.Property(e => e.MaSoLoaiIcd10).HasColumnName("MaSoLoaiICD10");
            entity.Property(e => e.MaLoaiIcd10)
                .HasMaxLength(45)
                .HasColumnName("MaLoaiICD10");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LoaiMauKetQua>(entity =>
        {
            entity.HasKey(e => e.MaSoLoaiMauKetQua).HasName("LoaiMauKetQua_pkey");

            entity.ToTable("LoaiMauKetQua");

            entity.HasIndex(e => e.MaLoaiMauKetQua, "LoaiMauKetQua_MaLoaiMauKetQua_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoLoaiMauKetQua, e.MaLoaiMauKetQua }, "LoaiMauKetQua_MaSoLoaiMauKetQua_MaLoaiMauKetQua_idx");

            entity.Property(e => e.MaLoaiMauKetQua).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenLoaiMauKetQua).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LoaiNhanVien>(entity =>
        {
            entity.HasKey(e => e.MaLoaiNhanVien).HasName("LoaiNhanVien_pkey");

            entity.ToTable("LoaiNhanVien");

            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
        });

        modelBuilder.Entity<LoaiThietBi>(entity =>
        {
            entity.HasKey(e => e.MaSoLoaiThietBi).HasName("LoaiThietBi_pkey");

            entity.ToTable("LoaiThietBi");

            entity.HasIndex(e => e.MaLoaiThietBi, "LoaiThietBi_MaLoaiThietBi_key").IsUnique();

            entity.Property(e => e.MaLoaiThietBi).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenLoaiThietBi).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LuotSuIn>(entity =>
        {
            entity.HasKey(e => e.MaSoLuotSuIn).HasName("LuotSuIn_pkey");

            entity.ToTable("LuotSuIn");

            entity.Property(e => e.MaLuotSuIn).HasMaxLength(50);
            entity.Property(e => e.MauThamChieu).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayIn).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<MauKetQua>(entity =>
        {
            entity.HasKey(e => e.MaSoMauKetQua).HasName("MauKetQua_pkey");

            entity.ToTable("MauKetQua");

            entity.HasIndex(e => e.MaMauKetQua, "MauKetQua_MaMauKetQua_key").IsUnique();

            entity.HasIndex(e => new { e.MaSoMauKetQua, e.MaMauKetQua }, "MauKetQua_MaSoMauKetQua_MaMauKetQua_idx");

            entity.Property(e => e.ApDungChoGt).HasColumnName("ApDungChoGT");
            entity.Property(e => e.DeNghi).HasMaxLength(255);
            entity.Property(e => e.KetLuan).HasMaxLength(255);
            entity.Property(e => e.MaMauKetQua).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenMau).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<MauThuoc>(entity =>
        {
            entity.HasKey(e => e.MaSoMauThuoc).HasName("MauThuoc_pkey");

            entity.ToTable("MauThuoc");

            entity.Property(e => e.CoHieuLuc).HasDefaultValue(true);
            entity.Property(e => e.MaMauThuoc).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenMauThuoc).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<MayTram>(entity =>
        {
            entity.HasKey(e => e.MaSoMayTram).HasName("MayTram_pkey");

            entity.ToTable("MayTram");

            entity.Property(e => e.Aetitle)
                .HasMaxLength(50)
                .HasColumnName("AETitle");
            entity.Property(e => e.DiaChiIp)
                .HasMaxLength(50)
                .HasColumnName("DiaChiIP");
            entity.Property(e => e.MayTram1)
                .HasMaxLength(50)
                .HasColumnName("MayTram");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenMay).HasMaxLength(50);
            entity.Property(e => e.TenMayTram).HasMaxLength(50);
        });

        modelBuilder.Entity<MeNghiConOm>(entity =>
        {
            entity.HasKey(e => e.MaGiayMeNghiConOm).HasName("MeNghiConOm_pkey");

            entity.ToTable("MeNghiConOm");

            entity.HasIndex(e => new { e.MaBhyt, e.MaCongTy, e.MaDotKham, e.MaBenhNhan }, "MeNghiConOm_MaBHYT_MaCongTy_MaDotKham_MaBenhNhan_idx");

            entity.Property(e => e.MaBhyt).HasColumnName("MaBHYT");
            entity.Property(e => e.NgayBatDau)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayKetThuc).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NgayLe>(entity =>
        {
            entity.HasKey(e => e.MaSoNgayLe).HasName("NgayLe_pkey");

            entity.ToTable("NgayLe");

            entity.Property(e => e.DenNgay).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MaNgayLe).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNgayLe).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TuNgay).HasColumnType("timestamp(3) without time zone");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.MaSoNguoiDung).HasName("NguoiDung_pkey");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.MaNhanVien, "NguoiDung_MaNhanVien_key").IsUnique();

            entity.HasIndex(e => e.TenDangNhap, "NguoiDung_TenDangNhap_key").IsUnique();

            entity.Property(e => e.MatKhau).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TaiKhoanCuaKhoa).HasDefaultValue(false);
            entity.Property(e => e.TenDangNhap).HasMaxLength(55);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NguonHenKham>(entity =>
        {
            entity.HasKey(e => e.MaSoNguonHenKham).HasName("NguonHenKham_pkey");

            entity.ToTable("NguonHenKham");

            entity.HasIndex(e => e.MaNguonHenKham, "NguonHenKham_MaNguonHenKham_key").IsUnique();

            entity.Property(e => e.KichHoat).HasDefaultValue(true);
            entity.Property(e => e.MaNguonHenKham).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNguonHenKham).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaSoNhaCungCap).HasName("NhaCungCap_pkey");

            entity.ToTable("NhaCungCap");

            entity.HasIndex(e => e.MaNhaCungCap, "NhaCungCap_MaNhaCungCap_key").IsUnique();

            entity.Property(e => e.CodeNhaCungCap).HasMaxLength(100);
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(15);
            entity.Property(e => e.KiHieuHoaDon).HasMaxLength(255);
            entity.Property(e => e.MaHoaDon).HasMaxLength(100);
            entity.Property(e => e.MaNhaCungCap).HasMaxLength(50);
            entity.Property(e => e.MaSoThue).HasMaxLength(100);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(255);
            entity.Property(e => e.TenQuocGiaTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.WebSite).HasMaxLength(100);
        });

        modelBuilder.Entity<NhaThuoc>(entity =>
        {
            entity.HasKey(e => e.MaSoNhaThuoc).HasName("NhaThuoc_pkey");

            entity.ToTable("NhaThuoc");

            entity.HasIndex(e => e.MaNhaThuoc, "NhaThuoc_MaNhaThuoc_key").IsUnique();

            entity.Property(e => e.MaNhaThuoc).HasMaxLength(100);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenNhaThuoc).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaSoNhanVien).HasName("NhanVien_pkey");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.HoVaTen, "NhanVien_HoVaTen_idx");

            entity.HasIndex(e => e.MaNhanVien, "NhanVien_MaNhanVien_key").IsUnique();

            entity.Property(e => e.BiDanh).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(45);
            entity.Property(e => e.HoVaTen).HasMaxLength(255);
            entity.Property(e => e.MaNhanVien).HasMaxLength(15);
            entity.Property(e => e.MaSoChungChiHanhNghe).HasMaxLength(255);
            entity.Property(e => e.MoTa).HasMaxLength(1024);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgaySinh).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhanVienKhoa>(entity =>
        {
            entity.HasKey(e => e.MaNhanVienKhoa).HasName("NhanVienKhoa_pkey");

            entity.ToTable("NhanVienKhoa");

            entity.HasIndex(e => new { e.MaKhoa, e.MaNhanVien }, "NhanVienKhoa_MaKhoa_MaNhanVien_idx");
        });

        modelBuilder.Entity<NhomBhyt>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomBhyt).HasName("NhomBHYT_pkey");

            entity.ToTable("NhomBHYT");

            entity.HasIndex(e => e.MaNhomBhyt, "NhomBHYT_MaNhomBHYT_key").IsUnique();

            entity.Property(e => e.MaSoNhomBhyt).HasColumnName("MaSoNhomBHYT");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.MaNhomBhyt)
                .HasMaxLength(50)
                .HasColumnName("MaNhomBHYT");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhomBhyt)
                .HasMaxLength(255)
                .HasColumnName("TenNhomBHYT");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhomDichVu>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomDichVu).HasName("NhomDichVu_pkey");

            entity.ToTable("NhomDichVu");

            entity.HasIndex(e => e.MaNhomDichVu, "NhomDichVu_MaNhomDichVu_key").IsUnique();

            entity.Property(e => e.MaNhomDichVu).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhomDichVuTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenNhomDichVuTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhomDichVuChiPhi>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomDichVuChiPhi).HasName("NhomDichVuChiPhi_pkey");

            entity.ToTable("NhomDichVuChiPhi");

            entity.HasIndex(e => e.MaNhomDichVuChiPhi, "NhomDichVuChiPhi_MaNhomDichVuChiPhi_key").IsUnique();

            entity.Property(e => e.MaNhomDichVuChiPhi).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhomDichVuTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenNhomDichVuTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhomDuocLy>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomDuocLy).HasName("NhomDuocLy_pkey");

            entity.ToTable("NhomDuocLy");

            entity.HasIndex(e => e.MaNhomDuocLy, "NhomDuocLy_MaNhomDuocLy_key").IsUnique();

            entity.Property(e => e.GhiChu).HasMaxLength(1024);
            entity.Property(e => e.MaNhomDuocLy).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhomIcd10>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomIcd10).HasName("NhomICD10_pkey");

            entity.ToTable("NhomICD10");

            entity.HasIndex(e => e.MaNhomIcd10, "NhomICD10_MaNhomICD10_key").IsUnique();

            entity.Property(e => e.MaSoNhomIcd10).HasColumnName("MaSoNhomICD10");
            entity.Property(e => e.MaChuongIcd10).HasColumnName("MaChuongICD10");
            entity.Property(e => e.MaNhomIcd10)
                .HasMaxLength(45)
                .HasColumnName("MaNhomICD10");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhapVien).HasDefaultValue(true);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhomIcd9>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomIcd9).HasName("NhomICD9_pkey");

            entity.ToTable("NhomICD9");

            entity.HasIndex(e => e.MaChuongIcd9, "NhomICD9_MaChuongICD9_idx");

            entity.HasIndex(e => e.MaNhomIcd9, "NhomICD9_MaNhomICD9_key").IsUnique();

            entity.Property(e => e.MaSoNhomIcd9).HasColumnName("MaSoNhomICD9");
            entity.Property(e => e.MaChuongIcd9).HasColumnName("MaChuongICD9");
            entity.Property(e => e.MaNhomIcd9)
                .HasMaxLength(45)
                .HasColumnName("MaNhomICD9");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NhapVien).HasDefaultValue(true);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhomNguoiDung>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomNguoiDung).HasName("NhomNguoiDung_pkey");

            entity.ToTable("NhomNguoiDung");

            entity.HasIndex(e => e.MaNhomNguoiDung, "NhomNguoiDung_MaNhomNguoiDung_key").IsUnique();

            entity.Property(e => e.MaNhomNguoiDung).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhomNguoiDung).HasMaxLength(512);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NhomQuyen>(entity =>
        {
            entity.HasKey(e => e.MaSoNhomQuyen).HasName("NhomQuyen_pkey");

            entity.ToTable("NhomQuyen");

            entity.HasIndex(e => e.MaNhomQuyen, "NhomQuyen_MaNhomQuyen_key").IsUnique();

            entity.Property(e => e.MaNhomQuyen).HasMaxLength(25);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNhomQuyen).HasMaxLength(512);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<NoiHen>(entity =>
        {
            entity.HasKey(e => e.MaSoNoiHen).HasName("NoiHen_pkey");

            entity.ToTable("NoiHen");

            entity.Property(e => e.MaNoiHen).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenNoiHen).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PhanLoaiDoc>(entity =>
        {
            entity.HasKey(e => e.MaSoPhanLoaiDoc).HasName("PhanLoaiDoc_pkey");

            entity.ToTable("PhanLoaiDoc");

            entity.HasIndex(e => e.MaPhanLoaiDoc, "PhanLoaiDoc_MaPhanLoaiDoc_key").IsUnique();

            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.MaPhanLoaiDoc).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.ThuocDoc).HasDefaultValue(false);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PhanLoaiIcd9>(entity =>
        {
            entity.HasKey(e => e.MaSoPhanLoaiIcd9).HasName("PhanLoaiICD9_pkey");

            entity.ToTable("PhanLoaiICD9");

            entity.HasIndex(e => e.MaPhanLoaiIcd9, "PhanLoaiICD9_MaPhanLoaiICD9_key").IsUnique();

            entity.Property(e => e.MaSoPhanLoaiIcd9).HasColumnName("MaSoPhanLoaiICD9");
            entity.Property(e => e.MaPhanLoaiIcd9)
                .HasMaxLength(15)
                .HasColumnName("MaPhanLoaiICD9");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PhanLoaiPhauThuat>(entity =>
        {
            entity.HasKey(e => e.MaSoPhanLoaiPhauThuat).HasName("PhanLoaiPhauThuat_pkey");

            entity.ToTable("PhanLoaiPhauThuat");

            entity.HasIndex(e => e.MaPhanLoaiPhauThuat, "PhanLoaiPhauThuat_MaPhanLoaiPhauThuat_key").IsUnique();

            entity.Property(e => e.MaPhanLoaiPhauThuat).HasMaxLength(45);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenPhanLoaiPhauThuat).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PhanLoaiThuoc>(entity =>
        {
            entity.HasKey(e => e.MaSoPhanLoaiThuoc).HasName("PhanLoaiThuoc_pkey");

            entity.ToTable("PhanLoaiThuoc");

            entity.HasIndex(e => e.MaPhanLoaiThuoc, "PhanLoaiThuoc_MaPhanLoaiThuoc_key").IsUnique();

            entity.Property(e => e.MaPhanLoaiThuoc).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenPhanLoai).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PhanQuyenNguoiDung>(entity =>
        {
            entity.HasKey(e => e.MaPhanQuyenNguoiDung).HasName("PhanQuyenNguoiDung_pkey");

            entity.ToTable("PhanQuyenNguoiDung");

            entity.HasIndex(e => new { e.MaNguoiDung, e.MaQuyen }, "PhanQuyenNguoiDung_MaNguoiDung_MaQuyen_idx");
        });

        modelBuilder.Entity<PhanQuyenNhom>(entity =>
        {
            entity.HasKey(e => e.MaSoPhanQuyenNhom).HasName("PhanQuyenNhom_pkey");

            entity.ToTable("PhanQuyenNhom");

            entity.HasIndex(e => new { e.MaNhomNguoiDung, e.MaQuyen }, "PhanQuyenNhom_MaNhomNguoiDung_MaQuyen_idx");
        });

        modelBuilder.Entity<PhieuPhauThuatThuThuat>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuPhauThuatThuThuat).HasName("PhieuPhauThuatThuThuat_pkey");

            entity.ToTable("PhieuPhauThuatThuThuat");

            entity.Property(e => e.LoaiPhauThuatThuThuat).HasMaxLength(50);
            entity.Property(e => e.MaPhieuPhauThuatThuThuat).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PpphauThuatThuThuat)
                .HasMaxLength(50)
                .HasColumnName("PPPhauThuatThuThuat");
            entity.Property(e => e.PpvoCam)
                .HasMaxLength(50)
                .HasColumnName("PPVoCam");
            entity.Property(e => e.SauPhauThuatThuThuat).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TruocPhauThuatThuThuat).HasMaxLength(50);
        });

        modelBuilder.Entity<PhieuThanhToan>(entity =>
        {
            entity.HasKey(e => e.MaPhieuThanhToan).HasName("PhieuThanhToan_pkey");

            entity.ToTable("PhieuThanhToan");

            entity.HasIndex(e => e.MaHoaDonThanhToan, "PhieuThanhToan_MaHoaDonThanhToan_key").IsUnique();

            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.HoanTienLai).HasDefaultValue(false);
            entity.Property(e => e.MaHoaDonThanhToan).HasMaxLength(11);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoHoaDon).HasMaxLength(100);
            entity.Property(e => e.ThongTinHoaDon).HasMaxLength(100);
            entity.Property(e => e.TongTien).HasPrecision(65, 30);
            entity.Property(e => e.Xoa).HasDefaultValue(false);
        });

        modelBuilder.Entity<PhieuThanhToanTungPhan>(entity =>
        {
            entity.HasKey(e => e.MaSoPhieuThanhToan).HasName("PhieuThanhToanTungPhan_pkey");

            entity.ToTable("PhieuThanhToanTungPhan");

            entity.HasIndex(e => new { e.MaDichVu, e.MaChiTietDotKham, e.MaBaoHiemYte }, "PhieuThanhToanTungPhan_MaDichVu_MaChiTietDotKham_MaBaoHiemY_idx");

            entity.Property(e => e.DonGia).HasPrecision(65, 30);
            entity.Property(e => e.MaBaoHiemYte).HasColumnName("MaBaoHiemYTe");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PhongKham>(entity =>
        {
            entity.HasKey(e => e.MaSoPhongKham).HasName("PhongKham_pkey");

            entity.ToTable("PhongKham");

            entity.HasIndex(e => new { e.MaKhuVuc, e.MaKhoa }, "PhongKham_MaKhuVuc_MaKhoa_idx");

            entity.HasIndex(e => e.MaPhongKham, "PhongKham_MaPhongKham_key").IsUnique();

            entity.Property(e => e.MaPhongKham).HasMaxLength(30);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenPhongKham).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PhuongXa>(entity =>
        {
            entity.HasKey(e => e.MaSoPhuongXa).HasName("PhuongXa_pkey");

            entity.ToTable("PhuongXa");

            entity.HasIndex(e => e.MaPhuongXaTuDongGoiY, "PhuongXa_MaPhuongXaTuDongGoiY_key").IsUnique();

            entity.HasIndex(e => e.MaPhuongXa, "PhuongXa_MaPhuongXa_key").IsUnique();

            entity.Property(e => e.MaPhuongXa).HasMaxLength(3);
            entity.Property(e => e.MaPhuongXaTuDongGoiY).HasMaxLength(45);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenPhuongXa).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<PrismaMigration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("_prisma_migrations_pkey");

            entity.ToTable("_prisma_migrations");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.AppliedStepsCount)
                .HasDefaultValue(0)
                .HasColumnName("applied_steps_count");
            entity.Property(e => e.Checksum)
                .HasMaxLength(64)
                .HasColumnName("checksum");
            entity.Property(e => e.FinishedAt).HasColumnName("finished_at");
            entity.Property(e => e.Logs).HasColumnName("logs");
            entity.Property(e => e.MigrationName)
                .HasMaxLength(255)
                .HasColumnName("migration_name");
            entity.Property(e => e.RolledBackAt).HasColumnName("rolled_back_at");
            entity.Property(e => e.StartedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("started_at");
        });

        modelBuilder.Entity<QuanHuyen>(entity =>
        {
            entity.HasKey(e => e.MaSoQuanHuyen).HasName("QuanHuyen_pkey");

            entity.ToTable("QuanHuyen");

            entity.HasIndex(e => e.MaQuanHuyen, "QuanHuyen_MaQuanHuyen_key").IsUnique();

            entity.Property(e => e.MaQuanHuyen).HasMaxLength(3);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenQuanHuyen).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<QuocGium>(entity =>
        {
            entity.HasKey(e => e.MaSoQuocGia).HasName("QuocGia_pkey");

            entity.HasIndex(e => e.MaQuocGia, "QuocGia_MaQuocGia_key").IsUnique();

            entity.HasIndex(e => e.MaSoQuocGia, "QuocGia_MaSoQuocGia_key").IsUnique();

            entity.Property(e => e.MaQuocGia).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(100);
            entity.Property(e => e.TenTiengViet).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<QuocTich>(entity =>
        {
            entity.HasKey(e => e.MaQuocTich).HasName("QuocTich_pkey");

            entity.ToTable("QuocTich");

            entity.HasIndex(e => e.MaQuocTich, "QuocTich_MaQuocTich_key").IsUnique();

            entity.Property(e => e.MaQuocTich).ValueGeneratedNever();
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTiengAnh).HasMaxLength(255);
            entity.Property(e => e.TenTiengViet).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<Quyen>(entity =>
        {
            entity.HasKey(e => e.MaQuyen).HasName("Quyen_pkey");

            entity.ToTable("Quyen");

            entity.Property(e => e.LoaiQuyen).HasMaxLength(25);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenQuyen).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<TaiLieuDinhKem>(entity =>
        {
            entity.HasKey(e => e.MaSoTaiLieuDinhKem).HasName("TaiLieuDinhKem_pkey");

            entity.ToTable("TaiLieuDinhKem");

            entity.Property(e => e.Checksum)
                .HasMaxLength(255)
                .HasColumnName("checksum");
            entity.Property(e => e.DungLuong).HasMaxLength(50);
            entity.Property(e => e.Loai).HasMaxLength(50);
            entity.Property(e => e.LoaiNoiDung).HasMaxLength(50);
            entity.Property(e => e.MaTaiLieuDinhKem).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenLuuTru).HasMaxLength(50);
            entity.Property(e => e.TenTaiLieu).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TrangThaiIn).HasDefaultValue(true);
        });

        modelBuilder.Entity<ThietBi>(entity =>
        {
            entity.HasKey(e => e.MaSoThietBi).HasName("ThietBi_pkey");

            entity.ToTable("ThietBi");

            entity.HasIndex(e => e.MaThietBi, "ThietBi_MaThietBi_key").IsUnique();

            entity.Property(e => e.MaThietBi).HasMaxLength(50);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Series).HasMaxLength(50);
            entity.Property(e => e.TenThietBi).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ThongTinThau>(entity =>
        {
            entity.HasKey(e => e.MaSoThongTinThau).HasName("ThongTinThau_pkey");

            entity.ToTable("ThongTinThau");

            entity.Property(e => e.BhytgiaTien)
                .HasPrecision(65, 30)
                .HasColumnName("BHYTGiaTien");
            entity.Property(e => e.HamLuong).HasMaxLength(1024);
            entity.Property(e => e.HoTroBhyt).HasColumnName("HoTroBHYT");
            entity.Property(e => e.MaDuongDung).HasMaxLength(50);
            entity.Property(e => e.MaGoiThau).HasMaxLength(100);
            entity.Property(e => e.MaHoatChat).HasMaxLength(50);
            entity.Property(e => e.MaNhomThau).HasMaxLength(100);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayCongBo).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoDangKyGpnk)
                .HasMaxLength(100)
                .HasColumnName("SoDangKyGPNK");
            entity.Property(e => e.SoLuongBhyt)
                .HasMaxLength(100)
                .HasColumnName("SoLuongBHYT");
            entity.Property(e => e.SoQuyetDinh).HasMaxLength(50);
            entity.Property(e => e.TenThuocBaoHiem).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.TyLeThanhToan).HasPrecision(65, 30);
        });

        modelBuilder.Entity<ThongTinThauThuocBhyt>(entity =>
        {
            entity.HasKey(e => e.MaSoBhytnhaThau).HasName("ThongTinThauThuocBHYT_pkey");

            entity.ToTable("ThongTinThauThuocBHYT");

            entity.HasIndex(e => e.MaBhytnhaThau, "ThongTinThauThuocBHYT_MaBHYTNhaThau_key").IsUnique();

            entity.Property(e => e.MaSoBhytnhaThau).HasColumnName("MaSoBHYTNhaThau");
            entity.Property(e => e.BenhVienApThau).HasMaxLength(50);
            entity.Property(e => e.BhytloaiThau).HasColumnName("BHYTLoaiThau");
            entity.Property(e => e.BhytnhaThau)
                .HasMaxLength(255)
                .HasColumnName("BHYTNhaThau");
            entity.Property(e => e.BhytnhaThauGoi)
                .HasMaxLength(255)
                .HasColumnName("BHYTNhaThauGoi");
            entity.Property(e => e.BhytsoDkgpnk).HasColumnName("BHYTSoDKGPNK");
            entity.Property(e => e.BhytsoLuong).HasColumnName("BHYTSoLuong");
            entity.Property(e => e.MaBhytnhaThau)
                .HasMaxLength(255)
                .HasColumnName("MaBHYTNhaThau");
            entity.Property(e => e.NgayCongBoHieuLuc).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayHetHanBhyt)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("NgayHetHanBHYT");
            entity.Property(e => e.SttDmt)
                .HasMaxLength(50)
                .HasColumnName("STT_DMT");
            entity.Property(e => e.SttTt)
                .HasMaxLength(50)
                .HasColumnName("STT_TT");
        });

        modelBuilder.Entity<ThuocNguyenLieuYte>(entity =>
        {
            entity.HasKey(e => e.MaSoThuoc).HasName("ThuocNguyenLieuYTe_pkey");

            entity.ToTable("ThuocNguyenLieuYTe");

            entity.HasIndex(e => e.MaThuocDqg, "ThuocNguyenLieuYTe_MaThuocDQG_key").IsUnique();

            entity.HasIndex(e => e.MaThuoc, "ThuocNguyenLieuYTe_MaThuoc_key").IsUnique();

            entity.Property(e => e.BhytquyetDinh)
                .HasMaxLength(255)
                .HasColumnName("BHYTQuyetDinh");
            entity.Property(e => e.CoHanDung).HasDefaultValue(true);
            entity.Property(e => e.DongGoi).HasMaxLength(255);
            entity.Property(e => e.GiaBan).HasPrecision(65, 30);
            entity.Property(e => e.GiaBhyt)
                .HasPrecision(65, 30)
                .HasColumnName("GiaBHYT");
            entity.Property(e => e.GiaNhaThuoc).HasPrecision(65, 30);
            entity.Property(e => e.GiaNhap).HasPrecision(65, 30);
            entity.Property(e => e.GiaNoiVien).HasPrecision(65, 30);
            entity.Property(e => e.HamLuong).HasMaxLength(1024);
            entity.Property(e => e.HangTonKho).HasDefaultValue(true);
            entity.Property(e => e.HuongDanSuDung).HasMaxLength(1024);
            entity.Property(e => e.MaAtc)
                .HasMaxLength(255)
                .HasColumnName("MaATC");
            entity.Property(e => e.MaBhyt)
                .HasMaxLength(50)
                .HasColumnName("MaBHYT");
            entity.Property(e => e.MaDonViSd).HasColumnName("MaDonViSD");
            entity.Property(e => e.MaThuoc).HasMaxLength(255);
            entity.Property(e => e.MaThuocDqg)
                .HasMaxLength(255)
                .HasColumnName("MaThuocDQG");
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SoDkgpnk)
                .HasMaxLength(255)
                .HasColumnName("SoDKGPNK");
            entity.Property(e => e.SoLuongQuyDoiSd).HasColumnName("SoLuongQuyDoiSD");
            entity.Property(e => e.TacDung).HasMaxLength(255);
            entity.Property(e => e.TacDungPhu).HasMaxLength(255);
            entity.Property(e => e.TenBhyt)
                .HasMaxLength(1024)
                .HasColumnName("TenBHYT");
            entity.Property(e => e.TenDocQuyen).HasMaxLength(1024);
            entity.Property(e => e.TenGoc).HasMaxLength(1024);
            entity.Property(e => e.TenThuocThuongMai).HasMaxLength(1024);
            entity.Property(e => e.ThanhPhan).HasMaxLength(1024);
            entity.Property(e => e.ThuocBanChan).HasDefaultValue(true);
            entity.Property(e => e.ThuocPhatNguyen).HasDefaultValue(true);
            entity.Property(e => e.ThuocRaLe).HasDefaultValue(true);
            entity.Property(e => e.ThuocUngThu).HasDefaultValue(true);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<TinhThanh>(entity =>
        {
            entity.HasKey(e => e.MaSoTinhThanh).HasName("TinhThanh_pkey");

            entity.ToTable("TinhThanh");

            entity.HasIndex(e => e.MaTinhThanh, "TinhThanh_MaTinhThanh_key").IsUnique();

            entity.Property(e => e.MaTinhThanh).HasMaxLength(3);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TenTinhThanh).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<ToaThuoc>(entity =>
        {
            entity.HasKey(e => e.MaSoToaThuoc).HasName("ToaThuoc_pkey");

            entity.ToTable("ToaThuoc");

            entity.Property(e => e.BieuHienLamSang).HasMaxLength(255);
            entity.Property(e => e.ChanDoan).HasMaxLength(1024);
            entity.Property(e => e.DaBan).HasDefaultValue(false);
            entity.Property(e => e.GhiChu).HasMaxLength(2048);
            entity.Property(e => e.KhamLai).HasMaxLength(100);
            entity.Property(e => e.Khoa).HasDefaultValue(false);
            entity.Property(e => e.MaIcd10).HasColumnName("MaICD10");
            entity.Property(e => e.NgayKhamLai).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ThoigianNhap)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TongTien).HasPrecision(65, 30);
        });

        modelBuilder.Entity<TuongTacThuoc>(entity =>
        {
            entity.HasKey(e => e.MaTuongTacThuoc).HasName("TuongTacThuoc_pkey");

            entity.ToTable("TuongTacThuoc");

            entity.Property(e => e.CoChe).HasMaxLength(255);
            entity.Property(e => e.GhiChu).HasMaxLength(1024);
            entity.Property(e => e.HauQua).HasMaxLength(255);
            entity.Property(e => e.NgayCapNhat).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
            entity.Property(e => e.XuLy).HasMaxLength(255);
        });

        modelBuilder.Entity<ClsText>(entity =>
        {
            entity.HasKey(e => e.MaSoClsText).HasName("CLS_TEXT_pkey");

            entity.ToTable("CLS_TEXT");

            entity.Property(e => e.MaClsText).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
