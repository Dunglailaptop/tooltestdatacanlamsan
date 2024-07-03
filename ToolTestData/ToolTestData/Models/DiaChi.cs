using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DiaChi
{
    public int MaSoDiaChi { get; set; }

    public string DiaChi1 { get; set; } = null!;

    public int MaTinh { get; set; }

    public int MaQuanHuyen { get; set; }

    public int MaPhuongXa { get; set; }

    public string DiaChiDayDu { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
