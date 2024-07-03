using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DanhMucThuocThau
{
    public int MaSoDanhMucThuocThau { get; set; }

    public int MaThuocThau { get; set; }

    public int MaHopDongThau { get; set; }

    public string TenDocQuyen { get; set; } = null!;

    public string TenThuocThuongMai { get; set; } = null!;

    public string TenThuocBh { get; set; } = null!;

    public string MaThuocBh { get; set; } = null!;

    public string NhomThau { get; set; } = null!;

    public string BhytsoDangKyQuyetDinh { get; set; } = null!;

    public DateTime NgayApDung { get; set; }

    public string DonViTinh { get; set; } = null!;

    public int BhytsoLuong { get; set; }

    public decimal GiaBhyt { get; set; }

    public string MaDuongDung { get; set; } = null!;

    public string NhomChiPhiBh { get; set; } = null!;

    public string PhanNhomBhyt { get; set; } = null!;

    public string HamLuong { get; set; } = null!;

    public string HangSanXuat { get; set; } = null!;

    public string NuocSanXuat { get; set; } = null!;

    public string BhytnhaThau { get; set; } = null!;

    public string GoiThauBhyt { get; set; } = null!;

    public string TyLeThanhToan { get; set; } = null!;

    public decimal GiaThanhToan { get; set; }

    public decimal GiaNhapSauThue { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public int MaNguoiDungTao { get; set; }
}
