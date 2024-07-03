using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmLogMau
{
    public int MaSoLogMau { get; set; }

    public int MaSoTuiMau { get; set; }

    public DateTime NgayTao { get; set; }

    public int NguoiDung { get; set; }

    public string HanhDong { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public string MaLogMau { get; set; } = null!;

    public DateTime NgayCapNhat { get; set; }

    public bool TrangThai { get; set; }
}
