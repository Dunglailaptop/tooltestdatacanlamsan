using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaSatDopplerDongQuaVanDongMachChu
{
    public int MaSoDopplerDongQuaVanDongMachChu { get; set; }

    public string MaDopplerDongQuaVanDongMachChu { get; set; } = null!;

    public double VanTocToiDa { get; set; }

    public string HoHapDmchu { get; set; } = null!;

    public string HepVanDmchu { get; set; } = null!;

    public string DongQuaVachLienNhi { get; set; } = null!;

    public string DongQuaVacgLienThat { get; set; } = null!;

    public string DongBatThuongKhac { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
