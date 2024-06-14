using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChuongIcd10
{
    public int MaSoChuongIcd10 { get; set; }

    public string SoChuongIcd10 { get; set; } = null!;

    public string MaChuongIcd10 { get; set; } = null!;

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
