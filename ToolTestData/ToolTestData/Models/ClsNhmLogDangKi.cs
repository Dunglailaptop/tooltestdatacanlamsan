using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmLogDangKi
{
    public int MaSoLogDangKi { get; set; }

    public int MaSoPhieuYeuCauLinh { get; set; }

    public int NguoiDung { get; set; }

    public string HanhDong { get; set; } = null!;

    public DateTime NgayTao { get; set; }

    public string GhiChu { get; set; } = null!;
}
