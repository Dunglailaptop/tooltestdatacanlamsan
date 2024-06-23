using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmNhaCungCap
{
    public int MaSoNhaCungCap { get; set; }

    public string MaNhaCungCap { get; set; } = null!;

    public string TenNhaCungCap { get; set; } = null!;

    public int MaSoDanhMucMau { get; set; }

    public int UuTien { get; set; }

    public bool TuiMauCuaBenhNhan { get; set; }

    public bool Isbt128 { get; set; }

    public bool CoHieuLuc { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
