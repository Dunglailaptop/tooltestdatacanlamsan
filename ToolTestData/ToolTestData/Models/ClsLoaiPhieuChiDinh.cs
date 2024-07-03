using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsLoaiPhieuChiDinh
{
    public int MaSoLoaiPhieuChiDinh { get; set; }

    public string MaLoaiPhieuChiDinh { get; set; } = null!;

    public string TenLoai { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
