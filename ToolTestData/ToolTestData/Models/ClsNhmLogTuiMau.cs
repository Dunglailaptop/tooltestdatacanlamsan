using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmLogTuiMau
{
    public int MaSoLogTuiMau { get; set; }

    public int MaSoLoaiChePham { get; set; }

    public int MaSoPhieuYeuCauLinh { get; set; }

    public int NguoiDung { get; set; }

    public string HanhDong { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public DateTime NgayTao { get; set; }
}
