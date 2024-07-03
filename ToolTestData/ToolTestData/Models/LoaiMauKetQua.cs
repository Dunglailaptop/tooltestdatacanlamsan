using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class LoaiMauKetQua
{
    public int MaSoLoaiMauKetQua { get; set; }

    public string MaLoaiMauKetQua { get; set; } = null!;

    public string TenLoaiMauKetQua { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
