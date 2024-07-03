using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmNhomMauTheoIsbt
{
    public int MaSoNhomMauTheoIsbt { get; set; }

    public string MaNhomMauTheoIsbt { get; set; } = null!;

    public string TenNhomMauTheoIsbt { get; set; } = null!;

    public int NhomMau { get; set; }

    public int YeuToRh { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
