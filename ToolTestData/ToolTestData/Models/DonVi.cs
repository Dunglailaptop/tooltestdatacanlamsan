using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DonVi
{
    public int MaSoDonVi { get; set; }

    public string TenDonVi { get; set; } = null!;

    public int MaSoLoaiDonVi { get; set; }

    public int SapXep { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
