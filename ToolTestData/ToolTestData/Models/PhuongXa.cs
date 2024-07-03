using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhuongXa
{
    public int MaSoPhuongXa { get; set; }

    public string MaPhuongXa { get; set; } = null!;

    public string MaPhuongXaTuDongGoiY { get; set; } = null!;

    public string TenPhuongXa { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
