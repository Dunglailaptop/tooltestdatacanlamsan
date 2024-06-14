using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhomDichVu
{
    public int MaSoNhomDichVu { get; set; }

    public string MaNhomDichVu { get; set; } = null!;

    public string TenNhomDichVuTiengViet { get; set; } = null!;

    public string TenNhomDichVuTiengAnh { get; set; } = null!;

    public int MaSoNhomDichVuChiPhi { get; set; }

    public int SapXep { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
