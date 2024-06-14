using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaSatDopplerDongQuaVanHaiLa
{
    public int MaSoDopplerDongQuaVanHaiLa { get; set; }

    public string MaDopplerDongQuaVanHaiLa { get; set; } = null!;

    public double VanTocToiDa { get; set; }

    public double Ea { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
