using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChiTietDichVuDangGoi
{
    public int MaSoChiTietDangGoi { get; set; }

    public string MaChiTietDangGoi { get; set; } = null!;

    public int SoLuong { get; set; }

    public int MaDichVuBenhVien { get; set; }

    public int MaDichVuDangGoi { get; set; }

    public decimal GiaDichVuDangGoi { get; set; }
}
