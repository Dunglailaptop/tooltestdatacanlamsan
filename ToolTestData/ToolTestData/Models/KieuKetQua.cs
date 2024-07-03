using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class KieuKetQua
{
    public int MaSoKieuKetQua { get; set; }

    public string MaKieuKetQua { get; set; } = null!;

    public string TenKieuKetQua { get; set; } = null!;

    public int LoaiKieuQuaKet { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
