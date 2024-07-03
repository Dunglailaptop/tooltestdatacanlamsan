using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class CongTy
{
    public int MaCongTy { get; set; }

    public string TenCongTy { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
