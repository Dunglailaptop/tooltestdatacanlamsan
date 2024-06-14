using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Ca
{
    public int MaSoCa { get; set; }

    public string MaCa { get; set; } = null!;

    public string TenCa { get; set; } = null!;

    public TimeOnly ThoiGianBatDau { get; set; }

    public TimeOnly ThoiGianKetThuc { get; set; }

    public string TenNgan { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public bool QuaNgay { get; set; }

    public int UuTien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
