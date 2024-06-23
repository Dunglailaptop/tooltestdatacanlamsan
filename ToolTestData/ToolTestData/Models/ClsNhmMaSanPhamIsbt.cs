using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmMaSanPhamIsbt
{
    public int MaSoMaSanPhamIsbt { get; set; }

    public string MaMaSanPhamIsbt { get; set; } = null!;

    public string TenMaSanPhamIsbt { get; set; } = null!;

    public int MaSoDanhMucMau { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
