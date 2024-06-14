using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhomNguoiDung
{
    public int MaSoNhomNguoiDung { get; set; }

    public string MaNhomNguoiDung { get; set; } = null!;

    public string TenNhomNguoiDung { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
