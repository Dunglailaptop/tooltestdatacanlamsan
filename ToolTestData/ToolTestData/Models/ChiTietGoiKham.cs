using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChiTietGoiKham
{
    public int MaSoChiTietGoiKham { get; set; }

    public string MaChiTietGoiKham { get; set; } = null!;

    public int DoiTuong { get; set; }

    public bool DichVuChinh { get; set; }

    public int MaDichVu { get; set; }

    public int MaGoiKham { get; set; }

    public decimal GiaKham { get; set; }
}
