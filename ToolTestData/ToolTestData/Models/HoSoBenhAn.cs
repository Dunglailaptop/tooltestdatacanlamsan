using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HoSoBenhAn
{
    public int MaHoSoBenhAn { get; set; }

    public int MaDotKham { get; set; }

    public decimal CanNang { get; set; }

    public decimal ChieuCao { get; set; }

    public decimal NhietDo { get; set; }

    public decimal HuyetAp { get; set; }

    public decimal NhipTim { get; set; }

    public decimal ChiSoPa { get; set; }

    public decimal ChiSoPt { get; set; }

    public decimal ChiSoTa { get; set; }

    public DateOnly NgayTao { get; set; }

    public bool TrangThai { get; set; }

    public int? HoSoXuatNhapVien { get; set; }

    public string BieuHienLamSang { get; set; } = null!;

    public string ChanDoan { get; set; } = null!;
}
