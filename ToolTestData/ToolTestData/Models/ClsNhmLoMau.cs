using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmLoMau
{
    public int MaSoLoMau { get; set; }

    public string MaLoMau { get; set; } = null!;

    public string SoBienLai { get; set; } = null!;

    public int MaSoNhaCungCap { get; set; }

    public int MaNhanVien { get; set; }

    public bool TranhThaiHieuLuc { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
