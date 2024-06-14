using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class QuanHuyen
{
    public int MaSoQuanHuyen { get; set; }

    public string MaQuanHuyen { get; set; } = null!;

    public string TenQuanHuyen { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
