using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhomQuyen
{
    public int MaSoNhomQuyen { get; set; }

    public string MaNhomQuyen { get; set; } = null!;

    public string TenNhomQuyen { get; set; } = null!;

    public int LoaiNhom { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
