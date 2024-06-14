using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DichVuKham
{
    public int MaSoDichVuBenhVien { get; set; }

    public string MaDichVuBenhVien { get; set; } = null!;

    public string TenDichVuBenhVien { get; set; } = null!;

    public bool MoKhoa { get; set; }

    public bool TuDongSanXuat { get; set; }

    public int ApDungChoGioiTinh { get; set; }

    public decimal GiaChuan { get; set; }

    public decimal GiaChoBhyt { get; set; }

    public decimal GiaToiDa { get; set; }

    public decimal GiaChatLuongCao { get; set; }

    public decimal GiaBhyttv { get; set; }

    public decimal GiaNgoaiGio { get; set; }

    public decimal GiaKhac { get; set; }

    public string GhiChu { get; set; } = null!;

    public bool GiaCoDinh { get; set; }

    public int LoaiBaoHiem { get; set; }

    public int MaSoDoiTuong { get; set; }

    public int MaSoNhomDichVu { get; set; }

    public int MaSoPhanLoaiPhauThuat { get; set; }

    public int MaSoKhoa { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public int MaSoDichVuThongTu37 { get; set; }

    public int MaSoDichVuThongTu43 { get; set; }

    public int MaSoDonVi { get; set; }

    public int MaSoDichVuChuyenKhoaCanLamSang { get; set; }

    public int MaSoPhongKham { get; set; }

    public bool TrangThai { get; set; }

    public int TinhTrangThucHien { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int NguoiTao { get; set; }

    public int NguoiCapNhat { get; set; }

    public bool DoiLoaiModality { get; set; }
}
