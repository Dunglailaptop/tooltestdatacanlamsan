using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DangKyCaKham
{
    public int MaDangKyCaKham { get; set; }

    public int MaCa { get; set; }

    public int MaKhuVuc { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
