using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NguonHenKham
{
    public int MaSoNguonHenKham { get; set; }

    public string MaNguonHenKham { get; set; } = null!;

    public string TenNguonHenKham { get; set; } = null!;

    public bool KichHoat { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
