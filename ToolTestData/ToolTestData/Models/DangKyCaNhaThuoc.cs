using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DangKyCaNhaThuoc
{
    public int MaDangKyCaNhaThuoc { get; set; }

    public int MaCa { get; set; }

    public int MaNhaThuoc { get; set; }

    public string GhiChu { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
