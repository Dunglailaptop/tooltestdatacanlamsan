using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmLoMau
{
    public int MaSoLoMau { get; set; }

    public string SoBienLai { get; set; } = null!;

    public int MaSoNhaCungCap { get; set; }

    public int MaNhanVienTao { get; set; }

    public int MaNhanVienCapNhat { get; set; }

    public bool TranhThaiHieuLuc { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

  
}
