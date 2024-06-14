using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTag
{
    public int MaSoTags { get; set; }

    public string MaTags { get; set; } = null!;

    public int UuTien { get; set; }

    public int MaSoNguoiDung { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
