using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsKio
{
    public int MaSoKios { get; set; }

    public string MaKios { get; set; } = null!;

    public string TenKios { get; set; } = null!;

    public int MaSoKhoa { get; set; }

    public int MaSoNhanVien { get; set; }

    public bool TrangThai { get; set; }

    public int MaPhongKham { get; set; }
}
