using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ToolTestData.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_prisma_migrations",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    checksum = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    finished_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    migration_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    logs = table.Column<string>(type: "text", nullable: true),
                    rolled_back_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    started_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    applied_steps_count = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("_prisma_migrations_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BangCap",
                columns: table => new
                {
                    MaBangCap = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BangCap_pkey", x => x.MaBangCap);
                });

            migrationBuilder.CreateTable(
                name: "BenhNhan",
                columns: table => new
                {
                    MaSoBenhNhan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaBenhNhan = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TenBenhNhan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GioiTinh = table.Column<int>(type: "integer", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaDanToc = table.Column<int>(type: "integer", nullable: false),
                    MaQuocTich = table.Column<int>(type: "integer", nullable: false),
                    DiaChiThuongTru = table.Column<int>(type: "integer", nullable: true),
                    DiaChiTamTru = table.Column<int>(type: "integer", nullable: true),
                    HoTenBa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SoDienThoaiBa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    HoTenMe = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SoDienThoaiMe = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    LanKhamCuoi = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaPhatSinh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BenhNhan_pkey", x => x.MaSoBenhNhan);
                });

            migrationBuilder.CreateTable(
                name: "BenhNhanTrenHangCho",
                columns: table => new
                {
                    MaSoBenhNhanTrenHangCho = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ThoiGianBatDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaSoBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    MaSoHangChoBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BenhNhanTrenHangCho_pkey", x => x.MaSoBenhNhanTrenHangCho);
                });

            migrationBuilder.CreateTable(
                name: "BenhVien",
                columns: table => new
                {
                    MaSoBenhVien = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaBenhVien = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    MaBenhVienDayDu = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    TenBenhVien = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DiaChi = table.Column<int>(type: "integer", nullable: false),
                    XepHang = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TuyenChuyenMonKyThuat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BenhVien_pkey", x => x.MaSoBenhVien);
                });

            migrationBuilder.CreateTable(
                name: "BHYT",
                columns: table => new
                {
                    MaSoTheBHYT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaTheBHYT = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    NhomBHYT = table.Column<int>(type: "integer", nullable: false),
                    MaVachBHYT = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaBenhVienChuyen = table.Column<int>(type: "integer", nullable: false),
                    QuyenLoi = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    NoiDangKyKhamChuaBenhBanDau = table.Column<int>(type: "integer", nullable: false),
                    NgayCap = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    KhuVuc = table.Column<string>(type: "text", nullable: true),
                    ThoiHanDu5NamBHYT = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    KCT = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    KCTTuNgay = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    KCTDenNgay = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BHYT_pkey", x => x.MaSoTheBHYT);
                });

            migrationBuilder.CreateTable(
                name: "Ca",
                columns: table => new
                {
                    MaSoCa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCa = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    TenCa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ThoiGianBatDau = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    ThoiGianKetThuc = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    TenNgan = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    QuaNgay = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Ca_pkey", x => x.MaSoCa);
                });

            migrationBuilder.CreateTable(
                name: "CaTruc",
                columns: table => new
                {
                    MaCaTruc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NgayTruc = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaBacSi = table.Column<int>(type: "integer", nullable: false),
                    MaKhuVuc = table.Column<int>(type: "integer", nullable: false),
                    MaPhongKham = table.Column<int>(type: "integer", nullable: false),
                    MaCa = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CaTruc_pkey", x => x.MaCaTruc);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDichVuDangGoi",
                columns: table => new
                {
                    MaSoChiTietDangGoi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietDangGoi = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    SoLuong = table.Column<int>(type: "integer", nullable: false),
                    MaDichVuBenhVien = table.Column<int>(type: "integer", nullable: false),
                    MaDichVuDangGoi = table.Column<int>(type: "integer", nullable: false),
                    GiaDichVuDangGoi = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChiTietDichVuDangGoi_pkey", x => x.MaSoChiTietDangGoi);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDotKham",
                columns: table => new
                {
                    MaChiTietDotKham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDotKham = table.Column<int>(type: "integer", nullable: false),
                    MaBacSi = table.Column<int>(type: "integer", nullable: false),
                    MaDichVu = table.Column<int>(type: "integer", nullable: false),
                    SoLuong = table.Column<int>(type: "integer", nullable: false),
                    DaIn = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    NgayIn = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    DaTraTien = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    GhiChu = table.Column<string>(type: "text", nullable: false),
                    Huy = table.Column<int>(type: "integer", nullable: false),
                    TrangThaiCLS = table.Column<int>(type: "integer", nullable: false),
                    MaCa = table.Column<int>(type: "integer", nullable: false),
                    MaHangCho = table.Column<int>(type: "integer", nullable: false),
                    LoaiGia = table.Column<int>(type: "integer", nullable: false),
                    BaoHiemYTe = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ThoiGianTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    NguoiCapNhat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChiTietDotKham_pkey", x => x.MaChiTietDotKham);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGoiKham",
                columns: table => new
                {
                    MaSoChiTietGoiKham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietGoiKham = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DoiTuong = table.Column<int>(type: "integer", nullable: false),
                    DichVuChinh = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    MaDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaGoiKham = table.Column<int>(type: "integer", nullable: false),
                    GiaKham = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChiTietGoiKham_pkey", x => x.MaSoChiTietGoiKham);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonDienTu",
                columns: table => new
                {
                    MaSoChiTietHoaDonDienTu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietHoaDonDienTu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaHoaDonDienTu = table.Column<int>(type: "integer", nullable: false),
                    HuongDanBKAV = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    TongTien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    LoaiHoaDon = table.Column<int>(type: "integer", nullable: false),
                    LoaiSanPham = table.Column<int>(type: "integer", nullable: false),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    MauHoaDonDienTu = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChiTietHoaDonDienTu_pkey", x => x.MaSoChiTietHoaDonDienTu);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietToaThuoc",
                columns: table => new
                {
                    MaSoChiTietToaThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaSoToaThuoc = table.Column<int>(type: "integer", nullable: false),
                    MaSoThuoc = table.Column<int>(type: "integer", nullable: false),
                    Sang = table.Column<double>(type: "double precision", nullable: false),
                    Trua = table.Column<double>(type: "double precision", nullable: false),
                    Chieu = table.Column<double>(type: "double precision", nullable: false),
                    Toi = table.Column<double>(type: "double precision", nullable: false),
                    DongGoi = table.Column<int>(type: "integer", nullable: false),
                    SoNgay = table.Column<int>(type: "integer", nullable: false),
                    SoLanNgay = table.Column<int>(type: "integer", nullable: false),
                    SoLuongMotLan = table.Column<int>(type: "integer", nullable: false),
                    TongCong = table.Column<int>(type: "integer", nullable: false),
                    HuongDan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    LieuDung = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChiTietToaThuoc_pkey", x => x.MaSoChiTietToaThuoc);
                });

            migrationBuilder.CreateTable(
                name: "ChonKetQua",
                columns: table => new
                {
                    MaSoChonKetQua = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChonKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenChonKetQua = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChonKetQua_pkey", x => x.MaSoChonKetQua);
                });

            migrationBuilder.CreateTable(
                name: "ChuongICD10",
                columns: table => new
                {
                    MaSoChuongICD10 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SoChuongICD10 = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    MaChuongICD10 = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChuongICD10_pkey", x => x.MaSoChuongICD10);
                });

            migrationBuilder.CreateTable(
                name: "ChuongICD9",
                columns: table => new
                {
                    MaSoChuongICD9 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SoChuongICD9 = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    MaChuongICD9 = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChuongICD9_pkey", x => x.MaSoChuongICD9);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenDoiDonVi",
                columns: table => new
                {
                    MaSoChuyenDoiDonVi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TyLeChuyenDoi = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    PhepToanChuyenDoi = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaDonViGoc = table.Column<int>(type: "integer", nullable: false),
                    MaDonViDich = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ChuyenDoiDonVi_pkey", x => x.MaSoChuyenDoiDonVi);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CaChup",
                columns: table => new
                {
                    MaSoCaChup = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCaChup = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaAnhDICOM = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    HinhAnh = table.Column<int>(type: "integer", nullable: false),
                    NgayChup = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    TrangThaiCho = table.Column<int>(type: "integer", nullable: false),
                    MaSoTags = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CaChup_pkey", x => x.MaSoCaChup);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_ChiTietCT",
                columns: table => new
                {
                    MaSoChiTietPhieuCT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietPhieuCT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "text", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaBacSiDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaBSThucTap = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoCaChup = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_ChiTietCT_pkey", x => x.MaSoChiTietPhieuCT);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_ChiTietMRI",
                columns: table => new
                {
                    MaSoChiTietPhieuMRI = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietPhieuMRI = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "text", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaBacSiDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaBSThucTap = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoCaChup = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_ChiTietMRI_pkey", x => x.MaSoChiTietPhieuMRI);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_ChiTietNoiSoi",
                columns: table => new
                {
                    MaSoChiTietNoiSoi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietNoiSoi = table.Column<string>(type: "text", nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    NoiThucHien = table.Column<int>(type: "integer", nullable: false),
                    BSDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaThietBi = table.Column<int>(type: "integer", nullable: false),
                    SinhThiet = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Clotest = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_ChiTietNoiSoi_pkey", x => x.MaSoChiTietNoiSoi);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_ChiTietPhieuDoApLucHMTT",
                columns: table => new
                {
                    MaSoPhieuDoApLucHMTT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhieuDoApLucHMTT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoCLSThuocCuaBN = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhieu = table.Column<int>(type: "integer", nullable: false),
                    NoiThucHien = table.Column<int>(type: "integer", nullable: false),
                    BacSiDocKQ = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaSoThietBi = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_ChiTietPhieuDoApLucHMTT_pkey", x => x.MaSoPhieuDoApLucHMTT);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_ChiTietPhieuSieuAm",
                columns: table => new
                {
                    MaSoChiTietPhieuSieuAm = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietPhieuSieuAm = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TaiGiuong = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoCaChup = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhieu = table.Column<int>(type: "integer", nullable: false),
                    NoiThucHien = table.Column<int>(type: "integer", nullable: false),
                    BacSiDocKQ = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaSoTHietBi = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_ChiTietPhieuSieuAm_pkey", x => x.MaSoChiTietPhieuSieuAm);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_ChiTietPhieuSieuAmTim",
                columns: table => new
                {
                    MaSoChiTietPhieuSieuAmTim = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietPhieuSieuAmTim = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TaiGiuong = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoCaChup = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhieu = table.Column<int>(type: "integer", nullable: false),
                    NoiThucHien = table.Column<int>(type: "integer", nullable: false),
                    BacSiDocKQ = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaSoTHietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoMoTaHinhAnh = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_ChiTietPhieuSieuAmTim_pkey", x => x.MaSoChiTietPhieuSieuAmTim);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_ChiTietXquang",
                columns: table => new
                {
                    MaSoChiTietPhieuXQ = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietPhieuXQ = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "text", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaNoiThucHien = table.Column<int>(type: "integer", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaBacSiDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaBSThucTap = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaSoCaChup = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_ChiTietXquang_pkey", x => x.MaSoChiTietPhieuXQ);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanBaLa",
                columns: table => new
                {
                    MaSoDopplerDongQuaVanBaLa = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"CLS_CDHA_SAT_DopplerDongQuaVanBaL_MaSoDopplerDongQuaVanBaLa_seq\"'::regclass)"),
                    MaDopplerDongQuaVanBaLa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanTocToiDa = table.Column<double>(type: "double precision", nullable: false),
                    HoVan = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PAPs = table.Column<double>(type: "double precision", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_SAT_DopplerDongQuaVanBaLa_pkey", x => x.MaSoDopplerDongQuaVanBaLa);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanDongMachChu",
                columns: table => new
                {
                    MaSoDopplerDongQuaVanDongMachChu = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"CLS_CDHA_SAT_DopplerDongQuaVa_MaSoDopplerDongQuaVanDongMac_seq1\"'::regclass)"),
                    MaDopplerDongQuaVanDongMachChu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanTocToiDa = table.Column<double>(type: "double precision", nullable: false),
                    HoHapDMChu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    HepVanDMChu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DongQuaVachLienNhi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DongQuaVacgLienThat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DongBatThuongKhac = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_SAT_DopplerDongQuaVanDongMachChu_pkey", x => x.MaSoDopplerDongQuaVanDongMachChu);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanDongMachPhoi",
                columns: table => new
                {
                    MaSoDopplerDongQuaVanDongMachPhoi = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"CLS_CDHA_SAT_DopplerDongQuaVa_MaSoDopplerDongQuaVanDongMach_seq\"'::regclass)"),
                    MaDopplerDongQuaVanDongMachPhoi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanTocToiDa = table.Column<double>(type: "double precision", nullable: false),
                    PAPm = table.Column<double>(type: "double precision", nullable: false),
                    PAPd = table.Column<double>(type: "double precision", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_SAT_DopplerDongQuaVanDongMachPhoi_pkey", x => x.MaSoDopplerDongQuaVanDongMachPhoi);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanHaiLa",
                columns: table => new
                {
                    MaSoDopplerDongQuaVanHaiLa = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"CLS_CDHA_SAT_DopplerDongQuaVanHa_MaSoDopplerDongQuaVanHaiLa_seq\"'::regclass)"),
                    MaDopplerDongQuaVanHaiLa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanTocToiDa = table.Column<double>(type: "double precision", nullable: false),
                    EA = table.Column<double>(type: "double precision", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_SAT_DopplerDongQuaVanHaiLa_pkey", x => x.MaSoDopplerDongQuaVanHaiLa);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_SAT_HaiD",
                columns: table => new
                {
                    MaSo2D = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma2D = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TuTheTim = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MangNgoaiTim = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NhiTrai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NhiPhai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TinhMach = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DMChu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DMPhoi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DMVanh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    XoangVanh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanHaiLa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanBaLa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanDMC = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    VanDMP = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ChonIn2D = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_SAT_HaiD_pkey", x => x.MaSo2D);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_SAT_MoTaHinhAnh",
                columns: table => new
                {
                    MaSoMoTaHinhAnh = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaMoTaHinhAnh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaSoHoSoKhamBenh = table.Column<int>(type: "integer", nullable: false),
                    MaSoTM = table.Column<int>(type: "integer", nullable: false),
                    MaSoDopplerDongQuaVanHaiLa = table.Column<int>(type: "integer", nullable: false),
                    MaSoDopplerDongQuaVanBaLa = table.Column<int>(type: "integer", nullable: false),
                    MaSoDopplerDongQuaVanDongMachPhoi = table.Column<int>(type: "integer", nullable: false),
                    MaSoDopplerDongQuaVanDongMachChu = table.Column<int>(type: "integer", nullable: false),
                    MaSo2D = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_SAT_MoTaHinhAnh_pkey", x => x.MaSoMoTaHinhAnh);
                });

            migrationBuilder.CreateTable(
                name: "CLS_CDHA_SAT_TM",
                columns: table => new
                {
                    MaSoTM = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaTM = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DMChu = table.Column<double>(type: "double precision", nullable: false),
                    NhiTrai = table.Column<double>(type: "double precision", nullable: false),
                    ThatPhai = table.Column<double>(type: "double precision", nullable: false),
                    IVSd = table.Column<double>(type: "double precision", nullable: false),
                    IVSs = table.Column<double>(type: "double precision", nullable: false),
                    LVIDd = table.Column<double>(type: "double precision", nullable: false),
                    LVIDs = table.Column<double>(type: "double precision", nullable: false),
                    LVPWd = table.Column<double>(type: "double precision", nullable: false),
                    LVPWs = table.Column<double>(type: "double precision", nullable: false),
                    RVDd = table.Column<double>(type: "double precision", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_CDHA_SAT_TM_pkey", x => x.MaSoTM);
                });

            migrationBuilder.CreateTable(
                name: "CLS_ChamThuThuat",
                columns: table => new
                {
                    MaSoChamThuThuat = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChamThuThuat = table.Column<int>(type: "integer", nullable: false),
                    NgayThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NguoiThucHien = table.Column<int>(type: "integer", nullable: false),
                    DanhGia = table.Column<int>(type: "integer", nullable: false),
                    SoLuong = table.Column<int>(type: "integer", nullable: false),
                    PhanLoai = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_ChamThuThuat_pkey", x => x.MaSoChamThuThuat);
                });

            migrationBuilder.CreateTable(
                name: "CLS_ChiTietGiaiPhauBenh",
                columns: table => new
                {
                    MaSoChiTietGiaiPhauBenh = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietGiaiPhauBenh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    GioNhanMau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioTraKQ = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    ViTriLaySinhThiet = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NhanXetDaiThe = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NhanXetViThe = table.Column<string>(type: "text", nullable: false),
                    PhuHop = table.Column<bool>(type: "boolean", nullable: false),
                    MaKhoaThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaBSDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauNhuom = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaSoThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoTaiLieuDinhKem = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_ChiTietGiaiPhauBenh_pkey", x => x.MaSoChiTietGiaiPhauBenh);
                });

            migrationBuilder.CreateTable(
                name: "CLS_ChiTietThuocCuaBN",
                columns: table => new
                {
                    MaSoCLSChiTietThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCLSThuocCuaBN = table.Column<int>(type: "integer", nullable: false),
                    MaCLSChiTietThuoc = table.Column<string>(type: "text", nullable: true),
                    MaSoCLSThuocVatTu = table.Column<int>(type: "integer", nullable: true),
                    SoLuongLan1 = table.Column<double>(type: "double precision", nullable: true),
                    SoLuongLan2 = table.Column<double>(type: "double precision", nullable: true),
                    SoLo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_ChiTietThuocCuaBN_pkey", x => x.MaSoCLSChiTietThuoc);
                });

            migrationBuilder.CreateTable(
                name: "CLS_ChiTietTuyDo",
                columns: table => new
                {
                    MaSoChiTietTuyDoChiTietTuyDo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietTuyDo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    MaSoTaiLieuDinhKem = table.Column<int>(type: "integer", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaKhoaThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaBSDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaSoThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhieuPhauThuatThuThuat = table.Column<int>(type: "integer", nullable: false),
                    MaSoKetQuaTuyDo = table.Column<int>(type: "integer", nullable: false),
                    MaSoMoTaTieuBanMauNgoaiVi = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_ChiTietTuyDo_pkey", x => x.MaSoChiTietTuyDoChiTietTuyDo);
                });

            migrationBuilder.CreateTable(
                name: "CLS_DanhGia",
                columns: table => new
                {
                    MaSoDanhGia = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDanhGia = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDanhGia = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_DanhGia_pkey", x => x.MaSoDanhGia);
                });

            migrationBuilder.CreateTable(
                name: "CLS_DichVuChamThem",
                columns: table => new
                {
                    MaSoDichVuChamThem = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDichVuChamThem = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDichVuChamThem = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoDichVuBenhVien = table.Column<int>(type: "integer", nullable: false),
                    GiaDichVuChamThem = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    CoHieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_DichVuChamThem_pkey", x => x.MaSoDichVuChamThem);
                });

            migrationBuilder.CreateTable(
                name: "CLS_GPB_MauNhuom",
                columns: table => new
                {
                    MaSoMauNhuom = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaMauNhuom = table.Column<int>(type: "integer", nullable: false),
                    TenMauNhuom = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_GPB_MauNhuom_pkey", x => x.MaSoMauNhuom);
                });

            migrationBuilder.CreateTable(
                name: "CLS_Kios",
                columns: table => new
                {
                    MaSoKios = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKios = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenKios = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    MaSoKhoa = table.Column<int>(type: "integer", nullable: false),
                    MaSoNhanVien = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    MaPhongKham = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_Kios_pkey", x => x.MaSoKios);
                });

            migrationBuilder.CreateTable(
                name: "CLS_LoaiPhieuChiDinh",
                columns: table => new
                {
                    MaSoLoaiPhieuChiDinh = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLoaiPhieuChiDinh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenLoai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_LoaiPhieuChiDinh_pkey", x => x.MaSoLoaiPhieuChiDinh);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_ChiTietLoMau",
                columns: table => new
                {
                    MaSoChiTietLoMau = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietLoMau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenLoMau = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CoChiPhi = table.Column<bool>(type: "boolean", nullable: false),
                    DuyetNhanh = table.Column<bool>(type: "boolean", nullable: false),
                    ISBT128 = table.Column<bool>(type: "boolean", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoLoMau = table.Column<int>(type: "integer", nullable: false),
                    MaSoDanhMucMau = table.Column<int>(type: "integer", nullable: false),
                    MaSoTuiMau = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_ChiTietLoMau_pkey", x => x.MaSoChiTietLoMau);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_DanhMucMau",
                columns: table => new
                {
                    MaSoDanhMucMau = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDanhMucMau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDanhMucMau = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenVietTatDanhMucMau = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    LoaiMau = table.Column<int>(type: "integer", nullable: false),
                    Gia = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    TheTich = table.Column<double>(type: "double precision", nullable: false),
                    TheTichBaoCao = table.Column<double>(type: "double precision", nullable: false),
                    DoUuTien = table.Column<int>(type: "integer", nullable: false),
                    CoHieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    MaSoThuoc = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiChePham = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_DanhMucMau_pkey", x => x.MaSoDanhMucMau);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_Kho",
                columns: table => new
                {
                    MaSoKho = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKho = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenKho = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_Kho_pkey", x => x.MaSoKho);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_LoaiChePham",
                columns: table => new
                {
                    MaSoLoaiChePham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLoaiChePham = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TenLoaiChePham = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    MaSoPhanLoaiChePham = table.Column<int>(type: "integer", nullable: true),
                    UuTien = table.Column<int>(type: "integer", nullable: true),
                    DinhNhomMau = table.Column<int>(type: "integer", nullable: false),
                    DinhNMBangGiay1 = table.Column<int>(type: "integer", nullable: false),
                    DinhNMBangGiay2 = table.Column<int>(type: "integer", nullable: false),
                    DichVuPUC = table.Column<int>(type: "integer", nullable: false),
                    DichVuPUCBoSung = table.Column<int>(type: "integer", nullable: false),
                    LoaiPUCTH = table.Column<int>(type: "integer", nullable: false),
                    PUCMacDinh = table.Column<int>(type: "integer", nullable: false),
                    OngAGH = table.Column<int>(type: "integer", nullable: false),
                    OngMTMuoi = table.Column<int>(type: "integer", nullable: false),
                    DuTruDVTheTich = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_LoaiChePham_pkey", x => x.MaSoLoaiChePham);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_LoMau",
                columns: table => new
                {
                    MaSoLoMau = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLoMau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SoBienLai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaSoNhaCungCap = table.Column<int>(type: "integer", nullable: false),
                    MaNhanVien = table.Column<int>(type: "integer", nullable: false),
                    TranhThaiHieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_LoMau_pkey", x => x.MaSoLoMau);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_MaSanPhamISBT",
                columns: table => new
                {
                    MaSoMaSanPhamISBT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaMaSanPhamISBT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenMaSanPhamISBT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaSoDanhMucMau = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_MaSanPhamISBT_pkey", x => x.MaSoMaSanPhamISBT);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_NhaCungCap",
                columns: table => new
                {
                    MaSoNhaCungCap = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhaCungCap = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoDanhMucMau = table.Column<int>(type: "integer", nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    TuiMauCuaBenhNhan = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ISBT128 = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    CoHieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_NhaCungCap_pkey", x => x.MaSoNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_NhomMauTheoISBT",
                columns: table => new
                {
                    MaSoNhomMauTheoISBT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomMauTheoISBT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNhomMauTheoISBT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NhomMau = table.Column<int>(type: "integer", nullable: false),
                    YeuToRH = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_NhomMauTheoISBT_pkey", x => x.MaSoNhomMauTheoISBT);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_PhanLoaiChePham",
                columns: table => new
                {
                    MaSoPhanLoaiChePham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhanLoaiChePham = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenPhanLoaiChePham = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_PhanLoaiChePham_pkey", x => x.MaSoPhanLoaiChePham);
                });

            migrationBuilder.CreateTable(
                name: "CLS_NHM_YeuCauLinh",
                columns: table => new
                {
                    MaSoYeuCauLinh = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaYeuCauLinh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaKho = table.Column<int>(type: "integer", nullable: false),
                    MaKhoa = table.Column<int>(type: "integer", nullable: false),
                    TheTich = table.Column<int>(type: "integer", nullable: false),
                    MaDonVi = table.Column<int>(type: "integer", nullable: false),
                    NgayYeuCau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    Loai = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_NHM_YeuCauLinh_pkey", x => x.MaSoYeuCauLinh);
                });

            migrationBuilder.CreateTable(
                name: "CLS_PhanLoaiNhomDichVu",
                columns: table => new
                {
                    MaSoPhanLoaiNhomDichVu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhanLoaiNhomDichVu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenPhanLoaiNhomDichVu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaSoDichVuBenhVien = table.Column<int>(type: "integer", nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_PhanLoaiNhomDichVu_pkey", x => x.MaSoPhanLoaiNhomDichVu);
                });

            migrationBuilder.CreateTable(
                name: "CLS_PhienLamViec",
                columns: table => new
                {
                    MaSoPhienLamViec = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhienLamViec = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenPhienLamViec = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoNguoiDung = table.Column<int>(type: "integer", nullable: false),
                    MaSoKhoa = table.Column<int>(type: "integer", nullable: false),
                    MaSoKios = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhongKham = table.Column<int>(type: "integer", nullable: false),
                    MaSoCa = table.Column<int>(type: "integer", nullable: false),
                    SoChoGoi = table.Column<int>(type: "integer", nullable: false),
                    SoDaGoi = table.Column<int>(type: "integer", nullable: false),
                    DiaChiIP = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TuGoi = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    AmThanh = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_PhienLamViec_pkey", x => x.MaSoPhienLamViec);
                });

            migrationBuilder.CreateTable(
                name: "CLS_PhieuChiDinh",
                columns: table => new
                {
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhieuChiDinh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ChanDoan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ChuThich = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoLoaiPhieu = table.Column<int>(type: "integer", nullable: false),
                    MucDoUuTien = table.Column<int>(type: "integer", nullable: false),
                    MaSoDaCap = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    MaKhoaChiDinh = table.Column<int>(type: "integer", nullable: false),
                    MaBacSiChiDinh = table.Column<int>(type: "integer", nullable: false),
                    MaSoDichVuBenhVien = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaSoBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    MaSoDotKham = table.Column<int>(type: "integer", nullable: false),
                    GioChiDinh = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaSoLoaiPhieuChiDinh = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_PhieuChiDinh_pkey", x => x.MaSoPhieuChiDinh);
                });

            migrationBuilder.CreateTable(
                name: "CLS_SoDaCap",
                columns: table => new
                {
                    MaSoDaCap = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    STT = table.Column<int>(type: "integer", nullable: false),
                    MaSoKios = table.Column<int>(type: "integer", nullable: false),
                    GioLaySo = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    GioGoiSo = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    GioHenKetQua = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    GioTraKetQua = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    TrangThai = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_SoDaCap_pkey", x => x.MaSoDaCap);
                });

            migrationBuilder.CreateTable(
                name: "CLS_Tags",
                columns: table => new
                {
                    MaSoTags = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaTags = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    MaSoNguoiDung = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_Tags_pkey", x => x.MaSoTags);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TD_KetQuaTuyDo",
                columns: table => new
                {
                    MaSoKetQuaTuyDo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKetQuaTuyDo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Myeloblast = table.Column<int>(type: "integer", nullable: false),
                    Promyelocyte = table.Column<int>(type: "integer", nullable: false),
                    NeutrophilSeries = table.Column<int>(type: "integer", nullable: false),
                    BandAndSegment = table.Column<int>(type: "integer", nullable: false),
                    EosinophileSeries = table.Column<int>(type: "integer", nullable: false),
                    BasophilSeries = table.Column<int>(type: "integer", nullable: false),
                    ChatLuongMau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ErythroidSeries = table.Column<int>(type: "integer", nullable: false),
                    Proerythroblast = table.Column<int>(type: "integer", nullable: false),
                    BasophilicErythroblast = table.Column<int>(type: "integer", nullable: false),
                    PolychromaticErythroblast = table.Column<int>(type: "integer", nullable: false),
                    OrthochromicErythroblast = table.Column<int>(type: "integer", nullable: false),
                    Lymphocytes = table.Column<int>(type: "integer", nullable: false),
                    PlasmaCells = table.Column<int>(type: "integer", nullable: false),
                    Monocytes = table.Column<int>(type: "integer", nullable: false),
                    Histiocytes = table.Column<int>(type: "integer", nullable: false),
                    Megakaryocytes = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TD_KetQuaTuyDo_pkey", x => x.MaSoKetQuaTuyDo);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TD_MoTaTieuBanMauNgoaiVi",
                columns: table => new
                {
                    MaSoMoTaTieuBanMauNgoaiVi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaMoTaTieuBanMauNgoaiVi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    HongCau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BachCau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TieuCau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TD_MoTaTieuBanMauNgoaiVi_pkey", x => x.MaSoMoTaTieuBanMauNgoaiVi);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_ChiTietDienCo",
                columns: table => new
                {
                    MaSoChiTietPhieuDienCo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhieuKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SoCap = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaKhoaThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaBSDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoCLSThuocCuaBN = table.Column<int>(type: "integer", nullable: false),
                    MaThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MoTaKetQua = table.Column<string>(type: "text", nullable: false),
                    KetLuan = table.Column<string>(type: "text", nullable: false),
                    DeNghi = table.Column<string>(type: "text", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_ChiTietDienCo_pkey", x => x.MaSoChiTietPhieuDienCo);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_ChiTietDienNao",
                columns: table => new
                {
                    MaSoChiTietPhieuDienNao = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhieuKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SoCap = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaKhoaThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaBSDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoCLSThuocCuaBN = table.Column<int>(type: "integer", nullable: false),
                    MaThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MoTaKetQua = table.Column<string>(type: "text", nullable: false),
                    KetLuan = table.Column<string>(type: "text", nullable: false),
                    DeNghi = table.Column<string>(type: "text", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_ChiTietDienNao_pkey", x => x.MaSoChiTietPhieuDienNao);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_ChiTietDienTim",
                columns: table => new
                {
                    MaSoChiTietPhieuDienTim = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhieuKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SoCap = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaKhoaThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaBSDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    MaSoCLSThuocCuaBN = table.Column<int>(type: "integer", nullable: false),
                    MaThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MoTaKetQua = table.Column<string>(type: "text", nullable: false),
                    KetLuan = table.Column<string>(type: "text", nullable: false),
                    DeNghi = table.Column<string>(type: "text", nullable: false),
                    InLanDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_ChiTietDienTim_pkey", x => x.MaSoChiTietPhieuDienTim);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_ChiTietDoCNHoHap",
                columns: table => new
                {
                    MaSoChiTietDoCNHoHap = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaChiTietDoCNHoHap = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    NoiThucHien = table.Column<int>(type: "integer", nullable: false),
                    BSDocKetQua = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: false),
                    GioTiepNhan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioThucHien = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MauKetQua = table.Column<int>(type: "integer", nullable: false),
                    MaThietBi = table.Column<int>(type: "integer", nullable: false),
                    MaSoCLSThuocCuaBN = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_ChiTietDoCNHoHap_pkey", x => x.MaSoChiTietDoCNHoHap);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_DienCo_KetQuaDienCoKim",
                columns: table => new
                {
                    MaSoKetQuaDienCoKim = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKetQuaDienCoKim = table.Column<int>(type: "integer", nullable: false),
                    MaSoChiTietPhieuDienCo = table.Column<int>(type: "integer", nullable: false),
                    CoKhaoSat = table.Column<int>(type: "integer", nullable: false),
                    Ben = table.Column<int>(type: "integer", nullable: false),
                    DamKim = table.Column<int>(type: "integer", nullable: false),
                    TuPhat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DonViVanDong = table.Column<int>(type: "integer", nullable: false),
                    KetTap = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_DienCo_KetQuaDienCoKim_pkey", x => x.MaSoKetQuaDienCoKim);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_DienCo_KetQuaDTTKCamGiac",
                columns: table => new
                {
                    MaSoKetQuaDTTKCamGiac = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKetQuaDTTKCamGiac = table.Column<int>(type: "integer", nullable: false),
                    MaSoChiTietPhieuDienCo = table.Column<int>(type: "integer", nullable: false),
                    DayThanKinh = table.Column<int>(type: "integer", nullable: false),
                    Ben = table.Column<int>(type: "integer", nullable: false),
                    DSL = table.Column<int>(type: "integer", nullable: false),
                    SCV = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BienDo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_DienCo_KetQuaDTTKCamGiac_pkey", x => x.MaSoKetQuaDTTKCamGiac);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_DienCo_KetQuaDTTKVanDong",
                columns: table => new
                {
                    MaSoKetQuaDTTKVanDong = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKetQuaDTTKVanDong = table.Column<int>(type: "integer", nullable: false),
                    MaSoChiTietPhieu = table.Column<int>(type: "integer", nullable: false),
                    DayThanKinh = table.Column<int>(type: "integer", nullable: false),
                    Ben = table.Column<int>(type: "integer", nullable: false),
                    DML = table.Column<int>(type: "integer", nullable: false),
                    MVC = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SongFLatency = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SongFRatio = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_DienCo_KetQuaDTTKVanDong_pkey", x => x.MaSoKetQuaDTTKVanDong);
                });

            migrationBuilder.CreateTable(
                name: "CLS_TDCN_DienCo_KetQuaHSTGTiemCoTay",
                columns: table => new
                {
                    MaSoKetQuaHSTGTiemCoTay = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKetQuaHSTGTiemCoTay = table.Column<int>(type: "integer", nullable: false),
                    MaSoChiTietPhieuDienCo = table.Column<int>(type: "integer", nullable: false),
                    CacThongSo = table.Column<int>(type: "integer", nullable: false),
                    TayPhai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GiaTriSoSanh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TayTrai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TDCN_DienCo_KetQuaHSTGTiemCoTay_pkey", x => x.MaSoKetQuaHSTGTiemCoTay);
                });

            migrationBuilder.CreateTable(
                name: "CLS_ThuocCuaBN",
                columns: table => new
                {
                    MaSoCLSThuocCuaBN = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCLSThuocCuaBN = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaMauThuoc = table.Column<int>(type: "integer", nullable: true),
                    NgayDung = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    ViTriChup = table.Column<int>(type: "integer", nullable: false),
                    KTVThucHien = table.Column<int>(type: "integer", nullable: true),
                    TongTien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_ThuocCuaBN_pkey", x => x.MaSoCLSThuocCuaBN);
                });

            migrationBuilder.CreateTable(
                name: "CLS_ThuocVatTu",
                columns: table => new
                {
                    MaSoCLSThuocVatTu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCLSThuocVatTu = table.Column<string>(type: "text", nullable: false),
                    MaSoThuoc = table.Column<int>(type: "integer", nullable: false),
                    HISId = table.Column<string>(type: "text", nullable: false),
                    TenThuoc = table.Column<string>(type: "text", nullable: false),
                    Loai = table.Column<int>(type: "integer", nullable: false),
                    LoaiBaoCao = table.Column<int>(type: "integer", nullable: true),
                    DonVi = table.Column<string>(type: "text", nullable: false),
                    SoChan = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ApDungCho = table.Column<int>(type: "integer", nullable: false),
                    GiaTien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    CoHieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    In = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false),
                    TenIn = table.Column<string>(type: "text", nullable: true),
                    ChuyenDoiIn = table.Column<string>(type: "text", nullable: false),
                    DonViIn = table.Column<string>(type: "text", nullable: true),
                    Hu = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Test = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    MaXuatKho = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    HanhDong = table.Column<string>(type: "text", nullable: false),
                    GhiChu = table.Column<string>(type: "text", nullable: false),
                    NguoiNhap = table.Column<int>(type: "integer", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_ThuocVatTu_pkey", x => x.MaSoCLSThuocVatTu);
                });

            migrationBuilder.CreateTable(
                name: "CongTy",
                columns: table => new
                {
                    MaCongTy = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenCongTy = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CongTy_pkey", x => x.MaCongTy);
                });

            migrationBuilder.CreateTable(
                name: "CoSo",
                columns: table => new
                {
                    MaSoCoSo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MoTaTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MoTaTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaBenhVien = table.Column<int>(type: "integer", nullable: true),
                    TruSo = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    MaCoSo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CoSo_pkey", x => x.MaSoCoSo);
                });

            migrationBuilder.CreateTable(
                name: "DangBaoChe",
                columns: table => new
                {
                    MaSoDangBaoChe = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenTiengViet = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DangBaoChe_pkey", x => x.MaSoDangBaoChe);
                });

            migrationBuilder.CreateTable(
                name: "DangKyCaKham",
                columns: table => new
                {
                    MaDangKyCaKham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCa = table.Column<int>(type: "integer", nullable: false),
                    MaKhuVuc = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DangKyCaKham_pkey", x => x.MaDangKyCaKham);
                });

            migrationBuilder.CreateTable(
                name: "DangKyCaNhaThuoc",
                columns: table => new
                {
                    MaDangKyCaNhaThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCa = table.Column<int>(type: "integer", nullable: false),
                    MaNhaThuoc = table.Column<int>(type: "integer", nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DangKyCaNhaThuoc_pkey", x => x.MaDangKyCaNhaThuoc);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucHoatChatThuoc",
                columns: table => new
                {
                    MaChiTietHoatChatThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaSoThuoc = table.Column<int>(type: "integer", nullable: false),
                    MaThuoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaHoatChat = table.Column<int>(type: "integer", nullable: false),
                    TenThuoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenHoatChat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HamLuong = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HamLuongDonViTinhText = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HamLuongGoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TheTich = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DanhMucThanhVienKiemDuyet",
                columns: table => new
                {
                    MaSoThanhVienKiemDuyet = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKho = table.Column<int>(type: "integer", nullable: false),
                    MaNhanVien = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DanhMucThanhVienKiemDuyet_pkey", x => x.MaSoThanhVienKiemDuyet);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucThuocThau",
                columns: table => new
                {
                    MaSoDanhMucThuocThau = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaThuocThau = table.Column<int>(type: "integer", nullable: false),
                    MaHopDongThau = table.Column<int>(type: "integer", nullable: false),
                    TenDocQuyen = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenThuocThuongMai = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenThuocBH = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    MaThuocBH = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NhomThau = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    BHYTSoDangKyQuyetDinh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    DonViTinh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    BHYTSoLuong = table.Column<int>(type: "integer", nullable: false),
                    GiaBHYT = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    MaDuongDung = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NhomChiPhiBH = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    PhanNhomBHYT = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HamLuong = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HangSanXuat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NuocSanXuat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    BHYTNhaThau = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GoiThauBHYT = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TyLeThanhToan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GiaThanhToan = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaNhapSauThue = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    MaNguoiDungTao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DanhMucThuocThau_pkey", x => x.MaSoDanhMucThuocThau);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachThuocBHYT",
                columns: table => new
                {
                    MaDanhSachThuocBHYT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaThuoc = table.Column<int>(type: "integer", nullable: false),
                    MaNhomBHYT = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DanhSachThuocBHYT_pkey", x => x.MaDanhSachThuocBHYT);
                });

            migrationBuilder.CreateTable(
                name: "DanToc",
                columns: table => new
                {
                    MaDanToc = table.Column<int>(type: "integer", nullable: false),
                    TenDanToc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DanToc_pkey", x => x.MaDanToc);
                });

            migrationBuilder.CreateTable(
                name: "DiaChi",
                columns: table => new
                {
                    MaSoDiaChi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DiaChi = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    MaTinh = table.Column<int>(type: "integer", nullable: false),
                    MaQuanHuyen = table.Column<int>(type: "integer", nullable: false),
                    MaPhuongXa = table.Column<int>(type: "integer", nullable: false),
                    DiaChiDayDu = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DiaChi_pkey", x => x.MaSoDiaChi);
                });

            migrationBuilder.CreateTable(
                name: "DichVuDangGoi",
                columns: table => new
                {
                    MaSoDichVuDangGoi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDichVuDangGoi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDichVuDangGoi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DoiTuong = table.Column<int>(type: "integer", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaNhomDichVu = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DichVuDangGoi_pkey", x => x.MaSoDichVuDangGoi);
                });

            migrationBuilder.CreateTable(
                name: "DichVuKham",
                columns: table => new
                {
                    MaSoDichVuBenhVien = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDichVuBenhVien = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDichVuBenhVien = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MoKhoa = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TuDongSanXuat = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    ApDungChoGioiTinh = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    GiaChuan = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaChoBHYT = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaToiDa = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaChatLuongCao = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaBHYTTV = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaNgoaiGio = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaKhac = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GiaCoDinh = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    LoaiBaoHiem = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    MaSoDoiTuong = table.Column<int>(type: "integer", nullable: false),
                    MaSoNhomDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhanLoaiPhauThuat = table.Column<int>(type: "integer", nullable: false),
                    MaSoKhoa = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaSoDichVuThongTu37 = table.Column<int>(type: "integer", nullable: false),
                    MaSoDichVuThongTu43 = table.Column<int>(type: "integer", nullable: false),
                    MaSoDonVi = table.Column<int>(type: "integer", nullable: false),
                    MaSoDichVuChuyenKhoaCanLamSang = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhongKham = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TinhTrangThucHien = table.Column<int>(type: "integer", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    NguoiCapNhat = table.Column<int>(type: "integer", nullable: false),
                    DoiLoaiPhuongThuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DichVuKham_pkey", x => x.MaSoDichVuBenhVien);
                });

            migrationBuilder.CreateTable(
                name: "DichVuMacDinh",
                columns: table => new
                {
                    MaSoDichVuMacDinh = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhuVuc = table.Column<int>(type: "integer", nullable: false),
                    MaDichVu = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DichVuMacDinh_pkey", x => x.MaSoDichVuMacDinh);
                });

            migrationBuilder.CreateTable(
                name: "DichVuTheoChuyenMon",
                columns: table => new
                {
                    MaSoDichVuTheoChuyenMon = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDichVuTheoChuyenMon = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDichVuTheoChuyenMon = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ThuTuSapXep = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DichVuTheoChuyenMon_pkey", x => x.MaSoDichVuTheoChuyenMon);
                });

            migrationBuilder.CreateTable(
                name: "DichVuThongTu37",
                columns: table => new
                {
                    MaSoDichVuThongTu37 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDichVuThongTu37 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDichVu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GiaDichVu = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    QuyetDinh = table.Column<int>(type: "integer", nullable: false),
                    NgayCongBo = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    HieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DichVuThongTu37_pkey", x => x.MaSoDichVuThongTu37);
                });

            migrationBuilder.CreateTable(
                name: "DichVuThongTu43",
                columns: table => new
                {
                    MaSoDichVuThongTu43 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDichVuThongTu43 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenDichVu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GiaDichVu = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    QuyetDinh = table.Column<int>(type: "integer", nullable: false),
                    NgayCongBo = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    Chuong = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TuyenA = table.Column<int>(type: "integer", nullable: false),
                    TuyenB = table.Column<int>(type: "integer", nullable: false),
                    TuyenC = table.Column<int>(type: "integer", nullable: false),
                    TuyenD = table.Column<int>(type: "integer", nullable: false),
                    HieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    GhiChu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GiaCoDinh = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    NguoiCapNhat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DichVuThongTu43_pkey", x => x.MaSoDichVuThongTu43);
                });

            migrationBuilder.CreateTable(
                name: "DoiTuong",
                columns: table => new
                {
                    MaSoDoiTuong = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDoiTuong = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    TenDoiTuong = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DoiTuong_pkey", x => x.MaSoDoiTuong);
                });

            migrationBuilder.CreateTable(
                name: "DonVi",
                columns: table => new
                {
                    MaSoDonVi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenDonVi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoLoaiDonVi = table.Column<int>(type: "integer", nullable: false),
                    SapXep = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DonVi_pkey", x => x.MaSoDonVi);
                });

            migrationBuilder.CreateTable(
                name: "DotKham",
                columns: table => new
                {
                    MaSoDotKham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDotKham = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaKhoa = table.Column<int>(type: "integer", nullable: false),
                    MaBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    TenDotKham = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    LoaiKhamBenh = table.Column<int>(type: "integer", nullable: false),
                    LoaiBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ThoiGianBatDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    NguoiCapNhat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DotKham_pkey", x => x.MaSoDotKham);
                });

            migrationBuilder.CreateTable(
                name: "DuongDung",
                columns: table => new
                {
                    MaSoDuongDung = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDuongDung = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    CachDung = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DuongDung_pkey", x => x.MaSoDuongDung);
                });

            migrationBuilder.CreateTable(
                name: "GoiKham",
                columns: table => new
                {
                    MaSoGoiKham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaGoiKham = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenGoiKham = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DoiTuong = table.Column<int>(type: "integer", nullable: false),
                    SoBenhNhanToiDa = table.Column<int>(type: "integer", nullable: false),
                    LoaiThanhToan = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    XacNhanSanSang = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("GoiKham_pkey", x => x.MaSoGoiKham);
                });

            migrationBuilder.CreateTable(
                name: "HangChoBenhNhan",
                columns: table => new
                {
                    MaSoHangChoBenhNhan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHangChoBenhNhan = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenHangChoBenhNhan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ThoiGianUocLuong = table.Column<int>(type: "integer", nullable: false),
                    SoBenhNhanToiDa = table.Column<int>(type: "integer", nullable: false),
                    SoLuongBenhNhanChuanBi = table.Column<int>(type: "integer", nullable: false),
                    ThuTuHienThi = table.Column<int>(type: "integer", nullable: false),
                    SoDaGoi = table.Column<int>(type: "integer", nullable: false),
                    SoLonNhat = table.Column<int>(type: "integer", nullable: false),
                    MaSoKhuVuc = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HangChoBenhNhan_pkey", x => x.MaSoHangChoBenhNhan);
                });

            migrationBuilder.CreateTable(
                name: "HangSanXuat",
                columns: table => new
                {
                    MaSoHangSanXuat = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHangSanXuat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenHangSanXuat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DienThoai = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    MaQuocGia = table.Column<int>(type: "integer", nullable: false),
                    TenQuocGiaTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Fax = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Website = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HangSanXuat_pkey", x => x.MaSoHangSanXuat);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonDienTu",
                columns: table => new
                {
                    MaSoHoaDonDienTu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhoaHoaDon = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaBenhNhan = table.Column<string>(type: "character varying(17)", maxLength: 17, nullable: false),
                    TongTien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LoaiHoaDon = table.Column<int>(type: "integer", nullable: false),
                    SoLanXuatHoaDon = table.Column<int>(type: "integer", nullable: false),
                    MaNhaThuoc = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HoaDonDienTu_pkey", x => x.MaSoHoaDonDienTu);
                });

            migrationBuilder.CreateTable(
                name: "HoatChat",
                columns: table => new
                {
                    MaSoHoatChatThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHoatChat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TenHoatChat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ChongChiDinh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ChiDinh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DuocDongLuc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DuocLuc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TacDung = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ToiDa1LanSD = table.Column<int>(type: "integer", nullable: true),
                    ToiDa1NgaySD = table.Column<int>(type: "integer", nullable: true),
                    ToiDa1LanSDCanNang = table.Column<int>(type: "integer", nullable: true),
                    ToiThieu1LanSDCanNang = table.Column<int>(type: "integer", nullable: true),
                    ToiDa1NgaySDCanNang = table.Column<int>(type: "integer", nullable: true),
                    ToiThieu1NgaySDCanNang = table.Column<int>(type: "integer", nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    KiemSoat = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false),
                    HoatChatDacBiet = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HoatChat_pkey", x => x.MaSoHoatChatThuoc);
                });

            migrationBuilder.CreateTable(
                name: "HopDongThau",
                columns: table => new
                {
                    MaSoHopDongThau = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHopDongThau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    MaNhaCungCap = table.Column<int>(type: "integer", nullable: false),
                    CodeNhaCungCap = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    SoHopDongThau = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    LoaiHopDongThau = table.Column<int>(type: "integer", nullable: false),
                    SoQuyetDinhVanBan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    NgayHieuLuc = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    NgayKy = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    NhomChiPhiBH = table.Column<int>(type: "integer", nullable: false),
                    FileUrl = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    MaNguoiTao = table.Column<int>(type: "integer", nullable: true),
                    MaNguoiCapNhat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HopDongThau_pkey", x => x.MaSoHopDongThau);
                });

            migrationBuilder.CreateTable(
                name: "HoSoBenhAn",
                columns: table => new
                {
                    MaHoSoBenhAn = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDotKham = table.Column<int>(type: "integer", nullable: false),
                    CanNang = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    ChieuCao = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    NhietDo = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    HuyetAp = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    NhipTim = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    ChiSoPA = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    ChiSoPT = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    ChiSoTA = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    NgayTao = table.Column<DateOnly>(type: "date", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    HoSoXuatNhapVien = table.Column<int>(type: "integer", nullable: true),
                    BieuHienLamSang = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ChanDoan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HoSoBenhAn_pkey", x => x.MaHoSoBenhAn);
                });

            migrationBuilder.CreateTable(
                name: "HoSoXuatNhapVien",
                columns: table => new
                {
                    MaSoHoSoXuatNhapVien = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHoSoXuatNhapVien = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    NgayVao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayRa = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaKhoaDauTien = table.Column<int>(type: "integer", nullable: false),
                    MaKhoaCuoiCung = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    MaBacSi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HoSoXuatNhapVien_pkey", x => x.MaSoHoSoXuatNhapVien);
                });

            migrationBuilder.CreateTable(
                name: "HuongDan",
                columns: table => new
                {
                    MaSoHuongDan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHuongDan = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenHuongDan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CoHieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TapTin = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HuongDan_pkey", x => x.MaSoHuongDan);
                });

            migrationBuilder.CreateTable(
                name: "ICD10",
                columns: table => new
                {
                    MaSoICD10 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaICD10 = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    MaNhomICD10 = table.Column<int>(type: "integer", nullable: false),
                    MaLoaiICD10 = table.Column<int>(type: "integer", nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    BenhManTinh = table.Column<int>(type: "integer", nullable: false, defaultValue: 2),
                    GioiTinh = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    BenhThuongGap = table.Column<int>(type: "integer", nullable: false, defaultValue: 2),
                    ThuocBaoHiemYTe = table.Column<int>(type: "integer", nullable: false, defaultValue: 2),
                    NgoaiDanhSach = table.Column<int>(type: "integer", nullable: false, defaultValue: 2),
                    ICD10DaiDien = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    MoTa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ChuyenKhoa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CanhBao = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    TenThongTu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NhapVien = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgaySuDungThuoc = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    NgaySuDungThuocNgoaiTru = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ICD10_pkey", x => x.MaSoICD10);
                });

            migrationBuilder.CreateTable(
                name: "ICD10NhomBHYT",
                columns: table => new
                {
                    MaSoICDNhomBHYT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomBHYT = table.Column<int>(type: "integer", nullable: false),
                    MaICD10 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ICD10NhomBHYT_pkey", x => x.MaSoICDNhomBHYT);
                });

            migrationBuilder.CreateTable(
                name: "ICD9",
                columns: table => new
                {
                    MaSoICD9 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaICD9 = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    MaNhomICD9 = table.Column<int>(type: "integer", nullable: false),
                    MaPhanLoaiICD9 = table.Column<int>(type: "integer", nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GioiTinh = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    ThuocBaoHiemYTe = table.Column<int>(type: "integer", nullable: false, defaultValue: 2),
                    NgoaiDanhSach = table.Column<int>(type: "integer", nullable: false, defaultValue: 2),
                    ICD9DaiDien = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ICD9_pkey", x => x.MaSoICD9);
                });

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    MaSoKho = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKho = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaPhongBan = table.Column<int>(type: "integer", nullable: false),
                    MaLoaiThuocNguyenLieuYTe = table.Column<int>(type: "integer", nullable: false),
                    CanhBaoHanDung = table.Column<int>(type: "integer", nullable: false),
                    CanhBaoTonToiThieu = table.Column<int>(type: "integer", nullable: false),
                    CapLe = table.Column<int>(type: "integer", nullable: false),
                    TienToPhieuNhap = table.Column<string>(type: "text", nullable: false),
                    TienToPhieuXuat = table.Column<string>(type: "text", nullable: false),
                    KeDonNoiVien = table.Column<int>(type: "integer", nullable: false),
                    SoLuongPhieuTra = table.Column<int>(type: "integer", nullable: false),
                    SoLuongPhieuXuat = table.Column<int>(type: "integer", nullable: false),
                    TenKho = table.Column<string>(type: "text", nullable: false),
                    ThanhVienKiemDuyet = table.Column<int>(type: "integer", nullable: false),
                    NgayCaiLai = table.Column<int>(type: "integer", nullable: false),
                    ThangCaiLai = table.Column<int>(type: "integer", nullable: false),
                    NamCaiLai = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Kho_pkey", x => x.MaSoKho);
                });

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    MaSoKhoa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    TenKhoaTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenKhoaTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MoTaTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MoTaTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    LoaiKhoa = table.Column<int>(type: "integer", nullable: false),
                    MaKhoi = table.Column<int>(type: "integer", nullable: false),
                    MaKhoaBHYT = table.Column<int>(type: "integer", nullable: false),
                    TruongKhoa = table.Column<int>(type: "integer", nullable: false),
                    CoPhauThuat = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaCoSo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Khoa_pkey", x => x.MaSoKhoa);
                });

            migrationBuilder.CreateTable(
                name: "KhoaBHYT",
                columns: table => new
                {
                    MaSoKhoaBHYT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhoaBHYT = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    NguoiSua = table.Column<int>(type: "integer", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("KhoaBHYT_pkey", x => x.MaSoKhoaBHYT);
                });

            migrationBuilder.CreateTable(
                name: "Khoi",
                columns: table => new
                {
                    MaKhoi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaCoSo = table.Column<int>(type: "integer", nullable: false),
                    TenKhoi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Khoi_pkey", x => x.MaKhoi);
                });

            migrationBuilder.CreateTable(
                name: "KhuVuc",
                columns: table => new
                {
                    MaSoKhuVuc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhuVuc = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    TenKhuVuc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ChoPhepCa = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    PhuongThucThanhToan = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    VanBan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Tang = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    ChoPhepBHYT = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    KhuVacXin = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LoaiGiaTien = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    MaKhoa = table.Column<int>(type: "integer", nullable: true),
                    LaKhuNhanBenh = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("KhuVuc_pkey", x => x.MaSoKhuVuc);
                });

            migrationBuilder.CreateTable(
                name: "KieuKetQua",
                columns: table => new
                {
                    MaSoKieuKetQua = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKieuKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenKieuKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LoaiKieuQuaKet = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("KieuKetQua_pkey", x => x.MaSoKieuKetQua);
                });

            migrationBuilder.CreateTable(
                name: "LichHen",
                columns: table => new
                {
                    MaLichHen = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenBenhNhan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    GioiTinh = table.Column<int>(type: "integer", nullable: false),
                    ThoiGianKham = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    SdtDangKy = table.Column<string>(type: "text", nullable: false),
                    MaPhong = table.Column<int>(type: "integer", nullable: false),
                    YeuCau = table.Column<string>(type: "text", nullable: true),
                    GhiChu = table.Column<string>(type: "text", nullable: true),
                    MaDotKham = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LichHen_pkey", x => x.MaLichHen);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLoaiDichVu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNhomDichVuTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenNhomDichVuTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LoaiDichVu_pkey", x => x.MaSoLoaiDichVu);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDonVi",
                columns: table => new
                {
                    MaSoLoaiDonVi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenLoaiDonVi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ChuThichLoaiDonVi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LoaiDonVi_pkey", x => x.MaSoLoaiDonVi);
                });

            migrationBuilder.CreateTable(
                name: "LoaiICD10",
                columns: table => new
                {
                    MaSoLoaiICD10 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLoaiICD10 = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LoaiICD10_pkey", x => x.MaSoLoaiICD10);
                });

            migrationBuilder.CreateTable(
                name: "LoaiMauKetQua",
                columns: table => new
                {
                    MaSoLoaiMauKetQua = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLoaiMauKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenLoaiMauKetQua = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LoaiMauKetQua_pkey", x => x.MaSoLoaiMauKetQua);
                });

            migrationBuilder.CreateTable(
                name: "LoaiNhanVien",
                columns: table => new
                {
                    MaLoaiNhanVien = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LoaiNhanVien_pkey", x => x.MaLoaiNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "LoaiThietBi",
                columns: table => new
                {
                    MaSoLoaiThietBi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLoaiThietBi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenLoaiThietBi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LoaiThietBi_pkey", x => x.MaSoLoaiThietBi);
                });

            migrationBuilder.CreateTable(
                name: "LuotSuIn",
                columns: table => new
                {
                    MaSoLuotSuIn = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaLuotSuIn = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NgayIn = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    MaThamChieu = table.Column<int>(type: "integer", nullable: false),
                    MauThamChieu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaSoPhieuChiDinh = table.Column<int>(type: "integer", nullable: false),
                    Logo = table.Column<bool>(type: "boolean", nullable: false),
                    SaoChep = table.Column<bool>(type: "boolean", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LuotSuIn_pkey", x => x.MaSoLuotSuIn);
                });

            migrationBuilder.CreateTable(
                name: "MauKetQua",
                columns: table => new
                {
                    MaSoMauKetQua = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaMauKetQua = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenMau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaNhanVien = table.Column<int>(type: "integer", nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    ApDungChoGT = table.Column<int>(type: "integer", nullable: false),
                    KetLuan = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DeNghi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MoTaKetQua = table.Column<string>(type: "text", nullable: false),
                    MaSoDichVuBenhVien = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaSoNhanVien = table.Column<int>(type: "integer", nullable: false),
                    MaSoLoaiMauKetQua = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MauKetQua_pkey", x => x.MaSoMauKetQua);
                });

            migrationBuilder.CreateTable(
                name: "MauThuoc",
                columns: table => new
                {
                    MaSoMauThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaMauThuoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenMauThuoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    CoHieuLuc = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MauThuoc_pkey", x => x.MaSoMauThuoc);
                });

            migrationBuilder.CreateTable(
                name: "MayTram",
                columns: table => new
                {
                    MaSoMayTram = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MayTram = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenMay = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenMayTram = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    AETitle = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DiaChiIP = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaThietBi = table.Column<int>(type: "integer", nullable: true),
                    MaPhongKham = table.Column<int>(type: "integer", nullable: true),
                    XacNhanCamera = table.Column<bool>(type: "boolean", nullable: false),
                    TrangThaiHieuLuc = table.Column<bool>(type: "boolean", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MayTram_pkey", x => x.MaSoMayTram);
                });

            migrationBuilder.CreateTable(
                name: "MeNghiConOm",
                columns: table => new
                {
                    MaGiayMeNghiConOm = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaBenhNhan = table.Column<int>(type: "integer", nullable: false),
                    MaBHYT = table.Column<int>(type: "integer", nullable: false),
                    MaCongTy = table.Column<int>(type: "integer", nullable: false),
                    MaDotKham = table.Column<int>(type: "integer", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayKetThuc = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MeNghiConOm_pkey", x => x.MaGiayMeNghiConOm);
                });

            migrationBuilder.CreateTable(
                name: "NgayLe",
                columns: table => new
                {
                    MaSoNgayLe = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNgayLe = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNgayLe = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    DenNgay = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NgayLe_pkey", x => x.MaSoNgayLe);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    MaSoNguoiDung = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenDangNhap = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    MatKhau = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaNhanVien = table.Column<int>(type: "integer", nullable: false),
                    TaiKhoanCuaKhoa = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    MaNhomNguoiDung = table.Column<int>(type: "integer", nullable: false),
                    HinhAnh = table.Column<string>(type: "text", nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    NguoiCapNhat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NguoiDung_pkey", x => x.MaSoNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "NguonHenKham",
                columns: table => new
                {
                    MaSoNguonHenKham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNguonHenKham = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNguonHenKham = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    KichHoat = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NguonHenKham_pkey", x => x.MaSoNguonHenKham);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaSoNhaCungCap = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhaCungCap = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CodeNhaCungCap = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoThue = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    MaHoaDon = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    KiHieuHoaDon = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DienThoai = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Fax = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    WebSite = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    MaQuocGia = table.Column<int>(type: "integer", nullable: false),
                    TenQuocGiaTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    MaNguoiTao = table.Column<int>(type: "integer", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhaCungCap_pkey", x => x.MaSoNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaSoNhanVien = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhanVien = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    HoVaTen = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    BiDanh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GioiTinh = table.Column<int>(type: "integer", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    MaDiaChi = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    SoDienThoai = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    MaLoaiNhanVien = table.Column<int>(type: "integer", nullable: false),
                    MaBangCap = table.Column<int>(type: "integer", nullable: false),
                    LoaiHopDong = table.Column<int>(type: "integer", nullable: false),
                    MoTa = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    MaSoChungChiHanhNghe = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhanVien_pkey", x => x.MaSoNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienKhoa",
                columns: table => new
                {
                    MaNhanVienKhoa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhoa = table.Column<int>(type: "integer", nullable: false),
                    MaNhanVien = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhanVienKhoa_pkey", x => x.MaNhanVienKhoa);
                });

            migrationBuilder.CreateTable(
                name: "NhaThuoc",
                columns: table => new
                {
                    MaSoNhaThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhaThuoc = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TenNhaThuoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    MaCoSo = table.Column<int>(type: "integer", nullable: false),
                    LoaiKhoLe = table.Column<int>(type: "integer", nullable: false),
                    LoaiKho = table.Column<int>(type: "integer", nullable: false),
                    MaKhuVuc = table.Column<int>(type: "integer", nullable: false),
                    Tang = table.Column<int>(type: "integer", nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhaThuoc_pkey", x => x.MaSoNhaThuoc);
                });

            migrationBuilder.CreateTable(
                name: "NhomBHYT",
                columns: table => new
                {
                    MaSoNhomBHYT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomBHYT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNhomBHYT = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    NguoiTao = table.Column<int>(type: "integer", nullable: false),
                    NguoiCapNhat = table.Column<int>(type: "integer", nullable: false),
                    DoUuTien = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomBHYT_pkey", x => x.MaSoNhomBHYT);
                });

            migrationBuilder.CreateTable(
                name: "NhomDichVu",
                columns: table => new
                {
                    MaSoNhomDichVu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomDichVu = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNhomDichVuTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenNhomDichVuTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoNhomDichVuChiPhi = table.Column<int>(type: "integer", nullable: false),
                    SapXep = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomDichVu_pkey", x => x.MaSoNhomDichVu);
                });

            migrationBuilder.CreateTable(
                name: "NhomDichVuChiPhi",
                columns: table => new
                {
                    MaSoNhomDichVuChiPhi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomDichVuChiPhi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNhomDichVuTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenNhomDichVuTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomDichVuChiPhi_pkey", x => x.MaSoNhomDichVuChiPhi);
                });

            migrationBuilder.CreateTable(
                name: "NhomDuocLy",
                columns: table => new
                {
                    MaSoNhomDuocLy = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomDuocLy = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Loai = table.Column<int>(type: "integer", nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomDuocLy_pkey", x => x.MaSoNhomDuocLy);
                });

            migrationBuilder.CreateTable(
                name: "NhomICD10",
                columns: table => new
                {
                    MaSoNhomICD10 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomICD10 = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    MaChuongICD10 = table.Column<int>(type: "integer", nullable: false),
                    NhapVien = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomICD10_pkey", x => x.MaSoNhomICD10);
                });

            migrationBuilder.CreateTable(
                name: "NhomICD9",
                columns: table => new
                {
                    MaSoNhomICD9 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomICD9 = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    MaChuongICD9 = table.Column<int>(type: "integer", nullable: false),
                    NhapVien = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomICD9_pkey", x => x.MaSoNhomICD9);
                });

            migrationBuilder.CreateTable(
                name: "NhomNguoiDung",
                columns: table => new
                {
                    MaSoNhomNguoiDung = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomNguoiDung = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenNhomNguoiDung = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomNguoiDung_pkey", x => x.MaSoNhomNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "NhomQuyen",
                columns: table => new
                {
                    MaSoNhomQuyen = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomQuyen = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    TenNhomQuyen = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    LoaiNhom = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NhomQuyen_pkey", x => x.MaSoNhomQuyen);
                });

            migrationBuilder.CreateTable(
                name: "NoiHen",
                columns: table => new
                {
                    MaSoNoiHen = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNoiHen = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenNoiHen = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoLoaiDichVu = table.Column<int>(type: "integer", nullable: false),
                    MaSoKhoa = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NoiHen_pkey", x => x.MaSoNoiHen);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiDoc",
                columns: table => new
                {
                    MaSoPhanLoaiDoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhanLoaiDoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Mau = table.Column<int>(type: "integer", nullable: false),
                    Loai = table.Column<int>(type: "integer", nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ThuocDoc = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhanLoaiDoc_pkey", x => x.MaSoPhanLoaiDoc);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiICD9",
                columns: table => new
                {
                    MaSoPhanLoaiICD9 = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhanLoaiICD9 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhanLoaiICD9_pkey", x => x.MaSoPhanLoaiICD9);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiPhauThuat",
                columns: table => new
                {
                    MaSoPhanLoaiPhauThuat = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhanLoaiPhauThuat = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    TenPhanLoaiPhauThuat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhanLoaiPhauThuat_pkey", x => x.MaSoPhanLoaiPhauThuat);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiThuoc",
                columns: table => new
                {
                    MaSoPhanLoaiThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhanLoaiThuoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenPhanLoai = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhanLoaiThuoc_pkey", x => x.MaSoPhanLoaiThuoc);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyenNguoiDung",
                columns: table => new
                {
                    MaPhanQuyenNguoiDung = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNguoiDung = table.Column<int>(type: "integer", nullable: false),
                    MaQuyen = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhanQuyenNguoiDung_pkey", x => x.MaPhanQuyenNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyenNhom",
                columns: table => new
                {
                    MaSoPhanQuyenNhom = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaNhomNguoiDung = table.Column<int>(type: "integer", nullable: false),
                    MaQuyen = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhanQuyenNhom_pkey", x => x.MaSoPhanQuyenNhom);
                });

            migrationBuilder.CreateTable(
                name: "PhieuPhauThuatThuThuat",
                columns: table => new
                {
                    MaSoPhieuPhauThuatThuThuat = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhieuPhauThuatThuThuat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TruocPhauThuatThuThuat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SauPhauThuatThuThuat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PPPhauThuatThuThuat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LoaiPhauThuatThuThuat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PPVoCam = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LuocDo = table.Column<string>(type: "text", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhieuPhauThuatThuThuat_pkey", x => x.MaSoPhieuPhauThuatThuThuat);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThanhToan",
                columns: table => new
                {
                    MaPhieuThanhToan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHoaDonThanhToan = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NguoiThuTien = table.Column<int>(type: "integer", nullable: false),
                    TongTien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaHoaDonDienTu = table.Column<int>(type: "integer", nullable: false),
                    HinhThucThanhToan = table.Column<int>(type: "integer", nullable: false),
                    LoaiHoaDon = table.Column<int>(type: "integer", nullable: false),
                    HoanTienLai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Xoa = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    SoHoaDon = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ThongTinHoaDon = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhieuThanhToan_pkey", x => x.MaPhieuThanhToan);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThanhToanTungPhan",
                columns: table => new
                {
                    MaSoPhieuThanhToan = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaDichVu = table.Column<int>(type: "integer", nullable: false),
                    SoLuong = table.Column<int>(type: "integer", nullable: false),
                    DonGia = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    LoaiGia = table.Column<int>(type: "integer", nullable: false),
                    MaChiTietDotKham = table.Column<int>(type: "integer", nullable: false),
                    MaBaoHiemYTe = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhieuThanhToanTungPhan_pkey", x => x.MaSoPhieuThanhToan);
                });

            migrationBuilder.CreateTable(
                name: "PhongKham",
                columns: table => new
                {
                    MaSoPhongKham = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhongKham = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    TenPhongKham = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Tang = table.Column<int>(type: "integer", nullable: true),
                    MaKhuVuc = table.Column<int>(type: "integer", nullable: true),
                    MaKhoa = table.Column<int>(type: "integer", nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhongKham_pkey", x => x.MaSoPhongKham);
                });

            migrationBuilder.CreateTable(
                name: "PhuongXa",
                columns: table => new
                {
                    MaSoPhuongXa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaPhuongXa = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    MaPhuongXaTuDongGoiY = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    TenPhuongXa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PhuongXa_pkey", x => x.MaSoPhuongXa);
                });

            migrationBuilder.CreateTable(
                name: "QuanHuyen",
                columns: table => new
                {
                    MaSoQuanHuyen = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaQuanHuyen = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    TenQuanHuyen = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("QuanHuyen_pkey", x => x.MaSoQuanHuyen);
                });

            migrationBuilder.CreateTable(
                name: "QuocGia",
                columns: table => new
                {
                    MaSoQuocGia = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaQuocGia = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TenTiengViet = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TenTiengAnh = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("QuocGia_pkey", x => x.MaSoQuocGia);
                });

            migrationBuilder.CreateTable(
                name: "QuocTich",
                columns: table => new
                {
                    MaQuocTich = table.Column<int>(type: "integer", nullable: false),
                    TenTiengViet = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TenTiengAnh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("QuocTich_pkey", x => x.MaQuocTich);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LoaiQuyen = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    TenQuyen = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaNhomQuyen = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Quyen_pkey", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "TaiLieuDinhKem",
                columns: table => new
                {
                    MaSoTaiLieuDinhKem = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaTaiLieuDinhKem = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenTaiLieu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    checksum = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    LoaiNoiDung = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DungLuong = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Loai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaBacSi = table.Column<int>(type: "integer", nullable: true),
                    TenLuuTru = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrangThaiIn = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TaiLieuDinhKem_pkey", x => x.MaSoTaiLieuDinhKem);
                });

            migrationBuilder.CreateTable(
                name: "ThietBi",
                columns: table => new
                {
                    MaSoThietBi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaThietBi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TenThietBi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaSoLoaiThietBi = table.Column<int>(type: "integer", nullable: false),
                    Series = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UuTien = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ThietBi_pkey", x => x.MaSoThietBi);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinThau",
                columns: table => new
                {
                    MaSoThongTinThau = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHopDongThau = table.Column<int>(type: "integer", nullable: false),
                    SoQuyetDinh = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    NgayCongBo = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    HoTroBHYT = table.Column<bool>(type: "boolean", nullable: true),
                    BHYTGiaTien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    TyLeThanhToan = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    MaHoatChat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    MaDuongDung = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TenThuocBaoHiem = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    HamLuong = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    MaGoiThau = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MaNhomThau = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NhaThau = table.Column<int>(type: "integer", nullable: true),
                    SoLuongBHYT = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SoDangKyGPNK = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    MaNguoiCapNhat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ThongTinThau_pkey", x => x.MaSoThongTinThau);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinThauThuocBHYT",
                columns: table => new
                {
                    MaSoBHYTNhaThau = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaBHYTNhaThau = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NgayHetHanBHYT = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    NgayCongBoHieuLuc = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false),
                    BHYTLoaiThau = table.Column<int>(type: "integer", nullable: false),
                    BHYTNhaThau = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    BHYTNhaThauGoi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    BenhVienApThau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BHYTSoLuong = table.Column<int>(type: "integer", nullable: false),
                    BHYTSoDKGPNK = table.Column<int>(type: "integer", nullable: false),
                    STT_TT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    STT_DMT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MaThuoc = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ThongTinThauThuocBHYT_pkey", x => x.MaSoBHYTNhaThau);
                });

            migrationBuilder.CreateTable(
                name: "ThuocNguyenLieuYTe",
                columns: table => new
                {
                    MaSoThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaThuoc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaThuocDQG = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaHangSanXuat = table.Column<int>(type: "integer", nullable: false),
                    MaQuocGia = table.Column<int>(type: "integer", nullable: false),
                    MaPhanLoaiDocDuoc = table.Column<int>(type: "integer", nullable: false),
                    MaDuocLy = table.Column<int>(type: "integer", nullable: false),
                    PhanLoaiKhuDieuTri = table.Column<int>(type: "integer", nullable: false),
                    ThoiGianBaoQuan = table.Column<int>(type: "integer", nullable: false),
                    MaDangBaoChe = table.Column<int>(type: "integer", nullable: false),
                    MaDonVi = table.Column<int>(type: "integer", nullable: false),
                    MaCachDung = table.Column<int>(type: "integer", nullable: false),
                    TheTich = table.Column<int>(type: "integer", nullable: false),
                    MaDonViTheTich = table.Column<int>(type: "integer", nullable: false),
                    SoLuongQuyDoiSD = table.Column<int>(type: "integer", nullable: false),
                    MaDonViSD = table.Column<int>(type: "integer", nullable: false),
                    SoLuongQuyDoiLieuDung = table.Column<int>(type: "integer", nullable: false),
                    MaDonViTheoLieu = table.Column<int>(type: "integer", nullable: false),
                    MaSoPhanLoaiThuoc = table.Column<int>(type: "integer", nullable: false),
                    MaSoDuongDung = table.Column<int>(type: "integer", nullable: false),
                    TenThuocThuongMai = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TenGoc = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TenDocQuyen = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TenBHYT = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ThanhPhan = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    MaATC = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    SoDKGPNK = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ThuocRaLe = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    GiaBan = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaNhap = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaNoiVien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaNhaThuoc = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    GiaBHYT = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    HuongDanSuDung = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ThuocUngThu = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    DongGoi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HamLuong = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    LanDung = table.Column<int>(type: "integer", nullable: false),
                    LieuDung = table.Column<int>(type: "integer", nullable: false),
                    TacDung = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TacDungPhu = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ThuocPhatNguyen = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    ThuocBanChan = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    CoHanDung = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    HangTonKho = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    ThangTuoiChiDinh = table.Column<int>(type: "integer", nullable: false),
                    LoaiThuanHop = table.Column<int>(type: "integer", nullable: false),
                    MaBHYT = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BHYTQuyetDinh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NhomVatTu = table.Column<int>(type: "integer", nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ThuocNguyenLieuYTe_pkey", x => x.MaSoThuoc);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanh",
                columns: table => new
                {
                    MaSoTinhThanh = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaTinhThanh = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    TenTinhThanh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TinhThanh_pkey", x => x.MaSoTinhThanh);
                });

            migrationBuilder.CreateTable(
                name: "ToaThuoc",
                columns: table => new
                {
                    MaSoToaThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHoSoBenhAn = table.Column<int>(type: "integer", nullable: false),
                    MaBacSi = table.Column<int>(type: "integer", nullable: false),
                    NgayTao = table.Column<DateOnly>(type: "date", nullable: false),
                    GhiChu = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    KhamLai = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NgayKhamLai = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true),
                    ChanDoan = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Khoa = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DaBan = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    TongTien = table.Column<decimal>(type: "numeric(65,30)", precision: 65, scale: 30, nullable: false),
                    ThoigianNhap = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    MaICD10 = table.Column<int>(type: "integer", nullable: false),
                    TrangThaiHoaDonDienTu = table.Column<int>(type: "integer", nullable: false),
                    MaHoaDonDienTu = table.Column<int>(type: "integer", nullable: true),
                    BieuHienLamSang = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MaCa = table.Column<int>(type: "integer", nullable: false),
                    MaHangCho = table.Column<int>(type: "integer", nullable: false),
                    MaKhuVuc = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ToaThuoc_pkey", x => x.MaSoToaThuoc);
                });

            migrationBuilder.CreateTable(
                name: "TuongTacThuoc",
                columns: table => new
                {
                    MaTuongTacThuoc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaHoatChatThuNhat = table.Column<int>(type: "integer", nullable: true),
                    MaHoatChatThuHai = table.Column<int>(type: "integer", nullable: true),
                    MucDo = table.Column<int>(type: "integer", nullable: false),
                    HauQua = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CoChe = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    XuLy = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    GhiChu = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    TrangThai = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    NgayTao = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    NgayCapNhat = table.Column<DateTime>(type: "timestamp(3) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TuongTacThuoc_pkey", x => x.MaTuongTacThuoc);
                });

            migrationBuilder.CreateIndex(
                name: "BenhNhan_MaBenhNhan_key",
                table: "BenhNhan",
                column: "MaBenhNhan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "BenhNhan_MaDanToc_MaQuocTich_DiaChiThuongTru_GioiTinh_LanKh_idx",
                table: "BenhNhan",
                columns: new[] { "MaDanToc", "MaQuocTich", "DiaChiThuongTru", "GioiTinh", "LanKhamCuoi" });

            migrationBuilder.CreateIndex(
                name: "BenhVien_MaBenhVien_key",
                table: "BenhVien",
                column: "MaBenhVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "BenhVien_MaBenhVienDayDu_key",
                table: "BenhVien",
                column: "MaBenhVienDayDu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "BHYT_MaTheBHYT_key",
                table: "BHYT",
                column: "MaTheBHYT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "BHYT_NoiDangKyKhamChuaBenhBanDau_idx",
                table: "BHYT",
                column: "NoiDangKyKhamChuaBenhBanDau");

            migrationBuilder.CreateIndex(
                name: "Ca_MaCa_key",
                table: "Ca",
                column: "MaCa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CaTruc_MaBacSi_MaKhuVuc_MaPhongKham_MaCa_idx",
                table: "CaTruc",
                columns: new[] { "MaBacSi", "MaKhuVuc", "MaPhongKham", "MaCa" });

            migrationBuilder.CreateIndex(
                name: "ChiTietDichVuDangGoi_MaChiTietDangGoi_key",
                table: "ChiTietDichVuDangGoi",
                column: "MaChiTietDangGoi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ChiTietDotKham_MaChiTietDotKham_key",
                table: "ChiTietDotKham",
                column: "MaChiTietDotKham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ChiTietDotKham_MaDotKham_MaBacSi_MaDichVu_MaCa_MaHangCho_Ng_idx",
                table: "ChiTietDotKham",
                columns: new[] { "MaDotKham", "MaBacSi", "MaDichVu", "MaCa", "MaHangCho", "NguoiTao", "NguoiCapNhat" });

            migrationBuilder.CreateIndex(
                name: "ChiTietGoiKham_MaChiTietGoiKham_key",
                table: "ChiTietGoiKham",
                column: "MaChiTietGoiKham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ChiTietHoaDonDienTu_MaChiTietHoaDonDienTu_key",
                table: "ChiTietHoaDonDienTu",
                column: "MaChiTietHoaDonDienTu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ChiTietHoaDonDienTu_MaHoaDonDienTu_TrangThai_NguoiTao_idx",
                table: "ChiTietHoaDonDienTu",
                columns: new[] { "MaHoaDonDienTu", "TrangThai", "NguoiTao" });

            migrationBuilder.CreateIndex(
                name: "ChuongICD10_MaChuongICD10_key",
                table: "ChuongICD10",
                column: "MaChuongICD10",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ChuongICD10_SoChuongICD10_key",
                table: "ChuongICD10",
                column: "SoChuongICD10",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ChuongICD9_MaChuongICD9_key",
                table: "ChuongICD9",
                column: "MaChuongICD9",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ChuongICD9_SoChuongICD9_key",
                table: "ChuongICD9",
                column: "SoChuongICD9",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_CaChup_MaCaChup_key",
                table: "CLS_CaChup",
                column: "MaCaChup",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_CDHA_ChiTietCT_MaChiTietPhieuCT_key",
                table: "CLS_CDHA_ChiTietCT",
                column: "MaChiTietPhieuCT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_CDHA_ChiTietCT_MaSoChiTietPhieuCT_MaChiTietPhieuCT_idx",
                table: "CLS_CDHA_ChiTietCT",
                columns: new[] { "MaSoChiTietPhieuCT", "MaChiTietPhieuCT" });

            migrationBuilder.CreateIndex(
                name: "CLS_CDHA_ChiTietMRI_MaChiTietPhieuMRI_key",
                table: "CLS_CDHA_ChiTietMRI",
                column: "MaChiTietPhieuMRI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_CDHA_ChiTietMRI_MaSoChiTietPhieuMRI_MaChiTietPhieuMRI_idx",
                table: "CLS_CDHA_ChiTietMRI",
                columns: new[] { "MaSoChiTietPhieuMRI", "MaChiTietPhieuMRI" });

            migrationBuilder.CreateIndex(
                name: "CLS_CDHA_ChiTietXquang_MaChiTietPhieuXQ_key",
                table: "CLS_CDHA_ChiTietXquang",
                column: "MaChiTietPhieuXQ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_CDHA_ChiTietXquang_MaSoChiTietPhieuXQ_MaChiTietPhieuXQ_idx",
                table: "CLS_CDHA_ChiTietXquang",
                columns: new[] { "MaSoChiTietPhieuXQ", "MaChiTietPhieuXQ" });

            migrationBuilder.CreateIndex(
                name: "CLS_Kios_MaKios_key",
                table: "CLS_Kios",
                column: "MaKios",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_Kios_TenKios_key",
                table: "CLS_Kios",
                column: "TenKios",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_LoaiPhieuChiDinh_MaLoaiPhieuChiDinh_key",
                table: "CLS_LoaiPhieuChiDinh",
                column: "MaLoaiPhieuChiDinh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_LoaiPhieuChiDinh_MaSoLoaiPhieuChiDinh_MaLoaiPhieuChiDin_idx",
                table: "CLS_LoaiPhieuChiDinh",
                columns: new[] { "MaSoLoaiPhieuChiDinh", "MaLoaiPhieuChiDinh" });

            migrationBuilder.CreateIndex(
                name: "CLS_PhieuChiDinh_MaPhieuChiDinh_key",
                table: "CLS_PhieuChiDinh",
                column: "MaPhieuChiDinh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CLS_PhieuChiDinh_MaSoPhieuChiDinh_MaPhieuChiDinh_idx",
                table: "CLS_PhieuChiDinh",
                columns: new[] { "MaSoPhieuChiDinh", "MaPhieuChiDinh" });

            migrationBuilder.CreateIndex(
                name: "CLS_Tags_MaTags_key",
                table: "CLS_Tags",
                column: "MaTags",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DangKyCaKham_MaCa_MaKhuVuc_idx",
                table: "DangKyCaKham",
                columns: new[] { "MaCa", "MaKhuVuc" });

            migrationBuilder.CreateIndex(
                name: "DangKyCaNhaThuoc_MaCa_MaNhaThuoc_idx",
                table: "DangKyCaNhaThuoc",
                columns: new[] { "MaCa", "MaNhaThuoc" });

            migrationBuilder.CreateIndex(
                name: "DanhMucHoatChatThuoc_MaChiTietHoatChatThuoc_key",
                table: "DanhMucHoatChatThuoc",
                column: "MaChiTietHoatChatThuoc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DanhSachThuocBHYT_MaNhomBHYT_MaThuoc_idx",
                table: "DanhSachThuocBHYT",
                columns: new[] { "MaNhomBHYT", "MaThuoc" });

            migrationBuilder.CreateIndex(
                name: "DanToc_MaDanToc_key",
                table: "DanToc",
                column: "MaDanToc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DiaChi_MaTinh_MaQuanHuyen_MaPhuongXa_idx",
                table: "DiaChi",
                columns: new[] { "MaTinh", "MaQuanHuyen", "MaPhuongXa" });

            migrationBuilder.CreateIndex(
                name: "DichVuDangGoi_MaDichVuDangGoi_key",
                table: "DichVuDangGoi",
                column: "MaDichVuDangGoi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DichVuKham_MaDichVuBenhVien_key",
                table: "DichVuKham",
                column: "MaDichVuBenhVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DichVuMacDinh_MaDichVu_idx",
                table: "DichVuMacDinh",
                column: "MaDichVu");

            migrationBuilder.CreateIndex(
                name: "DichVuMacDinh_MaKhuVuc_idx",
                table: "DichVuMacDinh",
                column: "MaKhuVuc");

            migrationBuilder.CreateIndex(
                name: "DichVuTheoChuyenMon_MaDichVuTheoChuyenMon_key",
                table: "DichVuTheoChuyenMon",
                column: "MaDichVuTheoChuyenMon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DichVuThongTu37_MaDichVuThongTu37_key",
                table: "DichVuThongTu37",
                column: "MaDichVuThongTu37",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DichVuThongTu43_MaDichVuThongTu43_key",
                table: "DichVuThongTu43",
                column: "MaDichVuThongTu43",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DotKham_MaDotKham_MaKhoa_MaBenhNhan_TenDotKham_LoaiKhamBenh_idx",
                table: "DotKham",
                columns: new[] { "MaDotKham", "MaKhoa", "MaBenhNhan", "TenDotKham", "LoaiKhamBenh", "LoaiBenhNhan" });

            migrationBuilder.CreateIndex(
                name: "DotKham_MaSoDotKham_key",
                table: "DotKham",
                column: "MaSoDotKham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DuongDung_MaDuongDung_key",
                table: "DuongDung",
                column: "MaDuongDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "GoiKham_MaGoiKham_key",
                table: "GoiKham",
                column: "MaGoiKham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HangChoBenhNhan_MaHangChoBenhNhan_key",
                table: "HangChoBenhNhan",
                column: "MaHangChoBenhNhan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HangSanXuat_MaHangSanXuat_key",
                table: "HangSanXuat",
                column: "MaHangSanXuat",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HangSanXuat_MaQuocGia_key",
                table: "HangSanXuat",
                column: "MaQuocGia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HoaDonDienTu_MaBenhNhan_LoaiHoaDon_MaNhaThuoc_idx",
                table: "HoaDonDienTu",
                columns: new[] { "MaBenhNhan", "LoaiHoaDon", "MaNhaThuoc" });

            migrationBuilder.CreateIndex(
                name: "HoaDonDienTu_MaKhoaHoaDon_key",
                table: "HoaDonDienTu",
                column: "MaKhoaHoaDon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HoatChat_MaHoatChat_key",
                table: "HoatChat",
                column: "MaHoatChat",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HoatChat_TenHoatChat_key",
                table: "HoatChat",
                column: "TenHoatChat",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HopDongThau_MaHopDongThau_key",
                table: "HopDongThau",
                column: "MaHopDongThau",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HoSoBenhAn_MaDotKham_NgayTao_TrangThai_HoSoXuatNhapVien_idx",
                table: "HoSoBenhAn",
                columns: new[] { "MaDotKham", "NgayTao", "TrangThai", "HoSoXuatNhapVien" });

            migrationBuilder.CreateIndex(
                name: "HoSoBenhAn_MaHoSoBenhAn_key",
                table: "HoSoBenhAn",
                column: "MaHoSoBenhAn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "HoSoXuatNhapVien_MaSoHoSoXuatNhapVien_key",
                table: "HoSoXuatNhapVien",
                column: "MaSoHoSoXuatNhapVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ICD10_MaICD10_key",
                table: "ICD10",
                column: "MaICD10",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ICD10_TenTiengViet_idx",
                table: "ICD10",
                column: "TenTiengViet");

            migrationBuilder.CreateIndex(
                name: "ICD10NhomBHYT_MaNhomBHYT_MaICD10_idx",
                table: "ICD10NhomBHYT",
                columns: new[] { "MaNhomBHYT", "MaICD10" });

            migrationBuilder.CreateIndex(
                name: "ICD9_MaICD9_key",
                table: "ICD9",
                column: "MaICD9",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ICD9_TenTiengViet_idx",
                table: "ICD9",
                column: "TenTiengViet");

            migrationBuilder.CreateIndex(
                name: "Khoa_MaKhoa_key",
                table: "Khoa",
                column: "MaKhoa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Khoa_MaKhoi_MaKhoaBHYT_CoPhauThuat_idx",
                table: "Khoa",
                columns: new[] { "MaKhoi", "MaKhoaBHYT", "CoPhauThuat" });

            migrationBuilder.CreateIndex(
                name: "KhoaBHYT_MaKhoaBHYT_key",
                table: "KhoaBHYT",
                column: "MaKhoaBHYT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "KhuVuc_MaKhoa_idx",
                table: "KhuVuc",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "KhuVuc_MaKhuVuc_key",
                table: "KhuVuc",
                column: "MaKhuVuc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "KieuKetQua_MaKieuKetQua_key",
                table: "KieuKetQua",
                column: "MaKieuKetQua",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "KieuKetQua_MaSoKieuKetQua_MaKieuKetQua_idx",
                table: "KieuKetQua",
                columns: new[] { "MaSoKieuKetQua", "MaKieuKetQua" });

            migrationBuilder.CreateIndex(
                name: "LichHen_MaDotKham_key",
                table: "LichHen",
                column: "MaDotKham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "LichHen_TenBenhNhan_SdtDangKy_MaPhong_idx",
                table: "LichHen",
                columns: new[] { "TenBenhNhan", "SdtDangKy", "MaPhong" });

            migrationBuilder.CreateIndex(
                name: "LoaiDichVu_MaLoaiDichVu_key",
                table: "LoaiDichVu",
                column: "MaLoaiDichVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "LoaiICD10_MaLoaiICD10_key",
                table: "LoaiICD10",
                column: "MaLoaiICD10",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "LoaiMauKetQua_MaLoaiMauKetQua_key",
                table: "LoaiMauKetQua",
                column: "MaLoaiMauKetQua",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "LoaiMauKetQua_MaSoLoaiMauKetQua_MaLoaiMauKetQua_idx",
                table: "LoaiMauKetQua",
                columns: new[] { "MaSoLoaiMauKetQua", "MaLoaiMauKetQua" });

            migrationBuilder.CreateIndex(
                name: "LoaiThietBi_MaLoaiThietBi_key",
                table: "LoaiThietBi",
                column: "MaLoaiThietBi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "MauKetQua_MaMauKetQua_key",
                table: "MauKetQua",
                column: "MaMauKetQua",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "MauKetQua_MaSoMauKetQua_MaMauKetQua_idx",
                table: "MauKetQua",
                columns: new[] { "MaSoMauKetQua", "MaMauKetQua" });

            migrationBuilder.CreateIndex(
                name: "MeNghiConOm_MaBHYT_MaCongTy_MaDotKham_MaBenhNhan_idx",
                table: "MeNghiConOm",
                columns: new[] { "MaBHYT", "MaCongTy", "MaDotKham", "MaBenhNhan" });

            migrationBuilder.CreateIndex(
                name: "NguoiDung_MaNhanVien_key",
                table: "NguoiDung",
                column: "MaNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NguoiDung_TenDangNhap_key",
                table: "NguoiDung",
                column: "TenDangNhap",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NguonHenKham_MaNguonHenKham_key",
                table: "NguonHenKham",
                column: "MaNguonHenKham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhaCungCap_MaNhaCungCap_key",
                table: "NhaCungCap",
                column: "MaNhaCungCap",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhanVien_HoVaTen_idx",
                table: "NhanVien",
                column: "HoVaTen");

            migrationBuilder.CreateIndex(
                name: "NhanVien_MaNhanVien_key",
                table: "NhanVien",
                column: "MaNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhanVienKhoa_MaKhoa_MaNhanVien_idx",
                table: "NhanVienKhoa",
                columns: new[] { "MaKhoa", "MaNhanVien" });

            migrationBuilder.CreateIndex(
                name: "NhaThuoc_MaNhaThuoc_key",
                table: "NhaThuoc",
                column: "MaNhaThuoc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomBHYT_MaNhomBHYT_key",
                table: "NhomBHYT",
                column: "MaNhomBHYT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomDichVu_MaNhomDichVu_key",
                table: "NhomDichVu",
                column: "MaNhomDichVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomDichVuChiPhi_MaNhomDichVuChiPhi_key",
                table: "NhomDichVuChiPhi",
                column: "MaNhomDichVuChiPhi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomDuocLy_MaNhomDuocLy_key",
                table: "NhomDuocLy",
                column: "MaNhomDuocLy",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomICD10_MaNhomICD10_key",
                table: "NhomICD10",
                column: "MaNhomICD10",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomICD9_MaChuongICD9_idx",
                table: "NhomICD9",
                column: "MaChuongICD9");

            migrationBuilder.CreateIndex(
                name: "NhomICD9_MaNhomICD9_key",
                table: "NhomICD9",
                column: "MaNhomICD9",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomNguoiDung_MaNhomNguoiDung_key",
                table: "NhomNguoiDung",
                column: "MaNhomNguoiDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NhomQuyen_MaNhomQuyen_key",
                table: "NhomQuyen",
                column: "MaNhomQuyen",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhanLoaiDoc_MaPhanLoaiDoc_key",
                table: "PhanLoaiDoc",
                column: "MaPhanLoaiDoc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhanLoaiICD9_MaPhanLoaiICD9_key",
                table: "PhanLoaiICD9",
                column: "MaPhanLoaiICD9",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhanLoaiPhauThuat_MaPhanLoaiPhauThuat_key",
                table: "PhanLoaiPhauThuat",
                column: "MaPhanLoaiPhauThuat",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhanLoaiThuoc_MaPhanLoaiThuoc_key",
                table: "PhanLoaiThuoc",
                column: "MaPhanLoaiThuoc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhanQuyenNguoiDung_MaNguoiDung_MaQuyen_idx",
                table: "PhanQuyenNguoiDung",
                columns: new[] { "MaNguoiDung", "MaQuyen" });

            migrationBuilder.CreateIndex(
                name: "PhanQuyenNhom_MaNhomNguoiDung_MaQuyen_idx",
                table: "PhanQuyenNhom",
                columns: new[] { "MaNhomNguoiDung", "MaQuyen" });

            migrationBuilder.CreateIndex(
                name: "PhieuThanhToan_MaHoaDonThanhToan_key",
                table: "PhieuThanhToan",
                column: "MaHoaDonThanhToan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhieuThanhToanTungPhan_MaDichVu_MaChiTietDotKham_MaBaoHiemY_idx",
                table: "PhieuThanhToanTungPhan",
                columns: new[] { "MaDichVu", "MaChiTietDotKham", "MaBaoHiemYTe" });

            migrationBuilder.CreateIndex(
                name: "PhongKham_MaKhuVuc_MaKhoa_idx",
                table: "PhongKham",
                columns: new[] { "MaKhuVuc", "MaKhoa" });

            migrationBuilder.CreateIndex(
                name: "PhongKham_MaPhongKham_key",
                table: "PhongKham",
                column: "MaPhongKham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhuongXa_MaPhuongXa_key",
                table: "PhuongXa",
                column: "MaPhuongXa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PhuongXa_MaPhuongXaTuDongGoiY_key",
                table: "PhuongXa",
                column: "MaPhuongXaTuDongGoiY",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "QuanHuyen_MaQuanHuyen_key",
                table: "QuanHuyen",
                column: "MaQuanHuyen",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "QuocGia_MaQuocGia_key",
                table: "QuocGia",
                column: "MaQuocGia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "QuocGia_MaSoQuocGia_key",
                table: "QuocGia",
                column: "MaSoQuocGia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "QuocTich_MaQuocTich_key",
                table: "QuocTich",
                column: "MaQuocTich",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ThietBi_MaThietBi_key",
                table: "ThietBi",
                column: "MaThietBi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ThongTinThauThuocBHYT_MaBHYTNhaThau_key",
                table: "ThongTinThauThuocBHYT",
                column: "MaBHYTNhaThau",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ThuocNguyenLieuYTe_MaThuoc_key",
                table: "ThuocNguyenLieuYTe",
                column: "MaThuoc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ThuocNguyenLieuYTe_MaThuocDQG_key",
                table: "ThuocNguyenLieuYTe",
                column: "MaThuocDQG",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "TinhThanh_MaTinhThanh_key",
                table: "TinhThanh",
                column: "MaTinhThanh",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_prisma_migrations");

            migrationBuilder.DropTable(
                name: "BangCap");

            migrationBuilder.DropTable(
                name: "BenhNhan");

            migrationBuilder.DropTable(
                name: "BenhNhanTrenHangCho");

            migrationBuilder.DropTable(
                name: "BenhVien");

            migrationBuilder.DropTable(
                name: "BHYT");

            migrationBuilder.DropTable(
                name: "Ca");

            migrationBuilder.DropTable(
                name: "CaTruc");

            migrationBuilder.DropTable(
                name: "ChiTietDichVuDangGoi");

            migrationBuilder.DropTable(
                name: "ChiTietDotKham");

            migrationBuilder.DropTable(
                name: "ChiTietGoiKham");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonDienTu");

            migrationBuilder.DropTable(
                name: "ChiTietToaThuoc");

            migrationBuilder.DropTable(
                name: "ChonKetQua");

            migrationBuilder.DropTable(
                name: "ChuongICD10");

            migrationBuilder.DropTable(
                name: "ChuongICD9");

            migrationBuilder.DropTable(
                name: "ChuyenDoiDonVi");

            migrationBuilder.DropTable(
                name: "CLS_CaChup");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_ChiTietCT");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_ChiTietMRI");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_ChiTietNoiSoi");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_ChiTietPhieuDoApLucHMTT");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_ChiTietPhieuSieuAm");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_ChiTietPhieuSieuAmTim");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_ChiTietXquang");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanBaLa");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanDongMachChu");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanDongMachPhoi");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_SAT_DopplerDongQuaVanHaiLa");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_SAT_HaiD");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_SAT_MoTaHinhAnh");

            migrationBuilder.DropTable(
                name: "CLS_CDHA_SAT_TM");

            migrationBuilder.DropTable(
                name: "CLS_ChamThuThuat");

            migrationBuilder.DropTable(
                name: "CLS_ChiTietGiaiPhauBenh");

            migrationBuilder.DropTable(
                name: "CLS_ChiTietThuocCuaBN");

            migrationBuilder.DropTable(
                name: "CLS_ChiTietTuyDo");

            migrationBuilder.DropTable(
                name: "CLS_DanhGia");

            migrationBuilder.DropTable(
                name: "CLS_DichVuChamThem");

            migrationBuilder.DropTable(
                name: "CLS_GPB_MauNhuom");

            migrationBuilder.DropTable(
                name: "CLS_Kios");

            migrationBuilder.DropTable(
                name: "CLS_LoaiPhieuChiDinh");

            migrationBuilder.DropTable(
                name: "CLS_NHM_ChiTietLoMau");

            migrationBuilder.DropTable(
                name: "CLS_NHM_DanhMucMau");

            migrationBuilder.DropTable(
                name: "CLS_NHM_Kho");

            migrationBuilder.DropTable(
                name: "CLS_NHM_LoaiChePham");

            migrationBuilder.DropTable(
                name: "CLS_NHM_LoMau");

            migrationBuilder.DropTable(
                name: "CLS_NHM_MaSanPhamISBT");

            migrationBuilder.DropTable(
                name: "CLS_NHM_NhaCungCap");

            migrationBuilder.DropTable(
                name: "CLS_NHM_NhomMauTheoISBT");

            migrationBuilder.DropTable(
                name: "CLS_NHM_PhanLoaiChePham");

            migrationBuilder.DropTable(
                name: "CLS_NHM_YeuCauLinh");

            migrationBuilder.DropTable(
                name: "CLS_PhanLoaiNhomDichVu");

            migrationBuilder.DropTable(
                name: "CLS_PhienLamViec");

            migrationBuilder.DropTable(
                name: "CLS_PhieuChiDinh");

            migrationBuilder.DropTable(
                name: "CLS_SoDaCap");

            migrationBuilder.DropTable(
                name: "CLS_Tags");

            migrationBuilder.DropTable(
                name: "CLS_TD_KetQuaTuyDo");

            migrationBuilder.DropTable(
                name: "CLS_TD_MoTaTieuBanMauNgoaiVi");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_ChiTietDienCo");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_ChiTietDienNao");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_ChiTietDienTim");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_ChiTietDoCNHoHap");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_DienCo_KetQuaDienCoKim");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_DienCo_KetQuaDTTKCamGiac");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_DienCo_KetQuaDTTKVanDong");

            migrationBuilder.DropTable(
                name: "CLS_TDCN_DienCo_KetQuaHSTGTiemCoTay");

            migrationBuilder.DropTable(
                name: "CLS_ThuocCuaBN");

            migrationBuilder.DropTable(
                name: "CLS_ThuocVatTu");

            migrationBuilder.DropTable(
                name: "CongTy");

            migrationBuilder.DropTable(
                name: "CoSo");

            migrationBuilder.DropTable(
                name: "DangBaoChe");

            migrationBuilder.DropTable(
                name: "DangKyCaKham");

            migrationBuilder.DropTable(
                name: "DangKyCaNhaThuoc");

            migrationBuilder.DropTable(
                name: "DanhMucHoatChatThuoc");

            migrationBuilder.DropTable(
                name: "DanhMucThanhVienKiemDuyet");

            migrationBuilder.DropTable(
                name: "DanhMucThuocThau");

            migrationBuilder.DropTable(
                name: "DanhSachThuocBHYT");

            migrationBuilder.DropTable(
                name: "DanToc");

            migrationBuilder.DropTable(
                name: "DiaChi");

            migrationBuilder.DropTable(
                name: "DichVuDangGoi");

            migrationBuilder.DropTable(
                name: "DichVuKham");

            migrationBuilder.DropTable(
                name: "DichVuMacDinh");

            migrationBuilder.DropTable(
                name: "DichVuTheoChuyenMon");

            migrationBuilder.DropTable(
                name: "DichVuThongTu37");

            migrationBuilder.DropTable(
                name: "DichVuThongTu43");

            migrationBuilder.DropTable(
                name: "DoiTuong");

            migrationBuilder.DropTable(
                name: "DonVi");

            migrationBuilder.DropTable(
                name: "DotKham");

            migrationBuilder.DropTable(
                name: "DuongDung");

            migrationBuilder.DropTable(
                name: "GoiKham");

            migrationBuilder.DropTable(
                name: "HangChoBenhNhan");

            migrationBuilder.DropTable(
                name: "HangSanXuat");

            migrationBuilder.DropTable(
                name: "HoaDonDienTu");

            migrationBuilder.DropTable(
                name: "HoatChat");

            migrationBuilder.DropTable(
                name: "HopDongThau");

            migrationBuilder.DropTable(
                name: "HoSoBenhAn");

            migrationBuilder.DropTable(
                name: "HoSoXuatNhapVien");

            migrationBuilder.DropTable(
                name: "HuongDan");

            migrationBuilder.DropTable(
                name: "ICD10");

            migrationBuilder.DropTable(
                name: "ICD10NhomBHYT");

            migrationBuilder.DropTable(
                name: "ICD9");

            migrationBuilder.DropTable(
                name: "Kho");

            migrationBuilder.DropTable(
                name: "Khoa");

            migrationBuilder.DropTable(
                name: "KhoaBHYT");

            migrationBuilder.DropTable(
                name: "Khoi");

            migrationBuilder.DropTable(
                name: "KhuVuc");

            migrationBuilder.DropTable(
                name: "KieuKetQua");

            migrationBuilder.DropTable(
                name: "LichHen");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");

            migrationBuilder.DropTable(
                name: "LoaiDonVi");

            migrationBuilder.DropTable(
                name: "LoaiICD10");

            migrationBuilder.DropTable(
                name: "LoaiMauKetQua");

            migrationBuilder.DropTable(
                name: "LoaiNhanVien");

            migrationBuilder.DropTable(
                name: "LoaiThietBi");

            migrationBuilder.DropTable(
                name: "LuotSuIn");

            migrationBuilder.DropTable(
                name: "MauKetQua");

            migrationBuilder.DropTable(
                name: "MauThuoc");

            migrationBuilder.DropTable(
                name: "MayTram");

            migrationBuilder.DropTable(
                name: "MeNghiConOm");

            migrationBuilder.DropTable(
                name: "NgayLe");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "NguonHenKham");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "NhanVienKhoa");

            migrationBuilder.DropTable(
                name: "NhaThuoc");

            migrationBuilder.DropTable(
                name: "NhomBHYT");

            migrationBuilder.DropTable(
                name: "NhomDichVu");

            migrationBuilder.DropTable(
                name: "NhomDichVuChiPhi");

            migrationBuilder.DropTable(
                name: "NhomDuocLy");

            migrationBuilder.DropTable(
                name: "NhomICD10");

            migrationBuilder.DropTable(
                name: "NhomICD9");

            migrationBuilder.DropTable(
                name: "NhomNguoiDung");

            migrationBuilder.DropTable(
                name: "NhomQuyen");

            migrationBuilder.DropTable(
                name: "NoiHen");

            migrationBuilder.DropTable(
                name: "PhanLoaiDoc");

            migrationBuilder.DropTable(
                name: "PhanLoaiICD9");

            migrationBuilder.DropTable(
                name: "PhanLoaiPhauThuat");

            migrationBuilder.DropTable(
                name: "PhanLoaiThuoc");

            migrationBuilder.DropTable(
                name: "PhanQuyenNguoiDung");

            migrationBuilder.DropTable(
                name: "PhanQuyenNhom");

            migrationBuilder.DropTable(
                name: "PhieuPhauThuatThuThuat");

            migrationBuilder.DropTable(
                name: "PhieuThanhToan");

            migrationBuilder.DropTable(
                name: "PhieuThanhToanTungPhan");

            migrationBuilder.DropTable(
                name: "PhongKham");

            migrationBuilder.DropTable(
                name: "PhuongXa");

            migrationBuilder.DropTable(
                name: "QuanHuyen");

            migrationBuilder.DropTable(
                name: "QuocGia");

            migrationBuilder.DropTable(
                name: "QuocTich");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "TaiLieuDinhKem");

            migrationBuilder.DropTable(
                name: "ThietBi");

            migrationBuilder.DropTable(
                name: "ThongTinThau");

            migrationBuilder.DropTable(
                name: "ThongTinThauThuocBHYT");

            migrationBuilder.DropTable(
                name: "ThuocNguyenLieuYTe");

            migrationBuilder.DropTable(
                name: "TinhThanh");

            migrationBuilder.DropTable(
                name: "ToaThuoc");

            migrationBuilder.DropTable(
                name: "TuongTacThuoc");
        }
    }
}
