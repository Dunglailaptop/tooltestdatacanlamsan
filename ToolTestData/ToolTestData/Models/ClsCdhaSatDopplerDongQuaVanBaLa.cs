using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaSatDopplerDongQuaVanBaLa
{
    public int MaSoDopplerDongQuaVanBaLa { get; set; }

    public string MaDopplerDongQuaVanBaLa { get; set; } = null!;

    public double VanTocToiDa { get; set; }

    public string HoVan { get; set; } = null!;

    public double Paps { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
