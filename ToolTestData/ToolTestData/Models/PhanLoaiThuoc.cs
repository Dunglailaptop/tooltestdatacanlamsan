using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhanLoaiThuoc
{
    public int MaSoPhanLoaiThuoc { get; set; }

    public string MaPhanLoaiThuoc { get; set; } = null!;

    public string TenPhanLoai { get; set; } = null!;

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
