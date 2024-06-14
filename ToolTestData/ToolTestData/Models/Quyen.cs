using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Quyen
{
    public int MaQuyen { get; set; }

    public string LoaiQuyen { get; set; } = null!;

    public string TenQuyen { get; set; } = null!;

    public int MaNhomQuyen { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
