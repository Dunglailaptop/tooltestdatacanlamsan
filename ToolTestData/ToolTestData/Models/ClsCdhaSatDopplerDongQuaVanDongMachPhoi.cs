using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaSatDopplerDongQuaVanDongMachPhoi
{
    public int MaSoDopplerDongQuaVanDongMachPhoi { get; set; }

    public string MaDopplerDongQuaVanDongMachPhoi { get; set; } = null!;

    public double VanTocToiDa { get; set; }

    public double Papm { get; set; }

    public double Papd { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
