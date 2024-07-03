using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmKho
{
    public int MaSoKho { get; set; }

    public string MaKho { get; set; } = null!;

    public string TenKho { get; set; } = null!;

    public int UuTien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
