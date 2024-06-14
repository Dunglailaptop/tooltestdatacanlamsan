using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChuongIcd9
{
    public int MaSoChuongIcd9 { get; set; }

    public string SoChuongIcd9 { get; set; } = null!;

    public string MaChuongIcd9 { get; set; } = null!;

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
