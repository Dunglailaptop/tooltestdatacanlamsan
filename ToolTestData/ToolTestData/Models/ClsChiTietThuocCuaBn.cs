using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsChiTietThuocCuaBn
{
    public int MaSoClschiTietThuoc { get; set; }

    public int MaClsthuocCuaBn { get; set; }

    public string? MaClschiTietThuoc { get; set; }

    public int? MaSoClsthuocVatTu { get; set; }

    public double? SoLuongLan1 { get; set; }

    public double? SoLuongLan2 { get; set; }

    public string SoLo { get; set; } = null!;
}
