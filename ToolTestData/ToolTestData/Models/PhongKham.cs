using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhongKham
{
    public int MaSoPhongKham { get; set; }

    public string MaPhongKham { get; set; } = null!;

    public string TenPhongKham { get; set; } = null!;

    public int? Tang { get; set; }

    public int? MaKhuVuc { get; set; }

    public int? MaKhoa { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
