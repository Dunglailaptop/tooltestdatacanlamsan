using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class LoaiDonVi
{
    public int MaSoLoaiDonVi { get; set; }

    public string TenLoaiDonVi { get; set; } = null!;

    public string ChuThichLoaiDonVi { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
