using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class QuocGium
{
    public int MaSoQuocGia { get; set; }

    public string? MaQuocGia { get; set; }

    public string? TenTiengViet { get; set; }

    public string? TenTiengAnh { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
