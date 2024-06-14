using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCaChup
{
    public int MaSoCaChup { get; set; }

    public string MaCaChup { get; set; } = null!;

    public string? MaAnhDicom { get; set; }

    public int HinhAnh { get; set; }

    public DateTime NgayChup { get; set; }

    public int TrangThaiCho { get; set; }

    public int MaSoTags { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
