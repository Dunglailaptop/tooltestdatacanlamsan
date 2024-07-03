using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class LoaiDichVu
{
    public int MaSoLoaiDichVu { get; set; }

    public string MaLoaiDichVu { get; set; } = null!;

    public string TenNhomDichVuTiengViet { get; set; } = null!;

    public string TenNhomDichVuTiengAnh { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
