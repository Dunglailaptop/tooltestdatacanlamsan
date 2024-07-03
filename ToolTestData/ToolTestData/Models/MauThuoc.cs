using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class MauThuoc
{
    public int MaSoMauThuoc { get; set; }

    public string MaMauThuoc { get; set; } = null!;

    public string TenMauThuoc { get; set; } = null!;

    public int MaLoaiDichVu { get; set; }

    public int UuTien { get; set; }

    public bool CoHieuLuc { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
