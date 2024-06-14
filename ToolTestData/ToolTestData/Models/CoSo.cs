using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class CoSo
{
    public int MaSoCoSo { get; set; }

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public string MoTaTiengViet { get; set; } = null!;

    public string MoTaTiengAnh { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int? MaBenhVien { get; set; }

    public int TruSo { get; set; }

    public string MaCoSo { get; set; } = null!;
}
