using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class MayTram
{
    public int MaSoMayTram { get; set; }

    public string MayTram1 { get; set; } = null!;

    public string TenMay { get; set; } = null!;

    public string TenMayTram { get; set; } = null!;

    public string Aetitle { get; set; } = null!;

    public string DiaChiIp { get; set; } = null!;

    public int? MaThietBi { get; set; }

    public int? MaPhongKham { get; set; }

    public bool XacNhanCamera { get; set; }

    public bool TrangThaiHieuLuc { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
