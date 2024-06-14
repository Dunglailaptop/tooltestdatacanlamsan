using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DuongDung
{
    public int MaSoDuongDung { get; set; }

    public string MaDuongDung { get; set; } = null!;

    public string CachDung { get; set; } = null!;

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
