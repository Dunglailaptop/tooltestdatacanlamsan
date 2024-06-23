using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmChiTietLoMau
{
    public int MaSoChiTietLoMau { get; set; }

    public string MaChiTietLoMau { get; set; } = null!;

    public string TenLoMau { get; set; } = null!;

    public bool CoChiPhi { get; set; }

    public bool DuyetNhanh { get; set; }

    public bool Isbt128 { get; set; }

    public DateTime NgayNhap { get; set; }

    public int MaSoLoMau { get; set; }

    public int MaSoDanhMucMau { get; set; }

    public int MaSoTuiMau { get; set; }
}
