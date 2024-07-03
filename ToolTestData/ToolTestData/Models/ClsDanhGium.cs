using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsDanhGium
{
    public int MaSoDanhGia { get; set; }

    public string MaDanhGia { get; set; } = null!;

    public string TenDanhGia { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
