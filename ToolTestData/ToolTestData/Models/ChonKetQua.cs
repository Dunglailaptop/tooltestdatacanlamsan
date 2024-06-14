using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChonKetQua
{
    public int MaSoChonKetQua { get; set; }

    public string MaChonKetQua { get; set; } = null!;

    public string TenChonKetQua { get; set; } = null!;

    public int UuTien { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
