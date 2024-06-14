using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NoiHen
{
    public int MaSoNoiHen { get; set; }

    public string MaNoiHen { get; set; } = null!;

    public string TenNoiHen { get; set; } = null!;

    public int MaSoLoaiDichVu { get; set; }

    public int MaSoKhoa { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
