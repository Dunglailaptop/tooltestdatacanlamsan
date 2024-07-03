using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsThuocCuaBn
{
    public int MaSoClsthuocCuaBn { get; set; }

    public string MaClsthuocCuaBn { get; set; } = null!;

    public int? MaMauThuoc { get; set; }

    public DateTime NgayDung { get; set; }

    public int ViTriChup { get; set; }

    public int? KtvthucHien { get; set; }

    public decimal? TongTien { get; set; }
}
