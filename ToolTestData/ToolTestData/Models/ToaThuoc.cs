using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ToaThuoc
{
    public int MaSoToaThuoc { get; set; }

    public int MaHoSoBenhAn { get; set; }

    public int MaBacSi { get; set; }

    public DateOnly NgayTao { get; set; }

    public string GhiChu { get; set; } = null!;

    public string KhamLai { get; set; } = null!;

    public DateTime? NgayKhamLai { get; set; }

    public string ChanDoan { get; set; } = null!;

    public bool Khoa { get; set; }

    public bool DaBan { get; set; }

    public decimal TongTien { get; set; }

    public DateTime ThoigianNhap { get; set; }

    public int MaIcd10 { get; set; }

    public int TrangThaiHoaDonDienTu { get; set; }

    public int? MaHoaDonDienTu { get; set; }

    public string BieuHienLamSang { get; set; } = null!;

    public int MaCa { get; set; }

    public int MaHangCho { get; set; }

    public int MaKhuVuc { get; set; }
}
