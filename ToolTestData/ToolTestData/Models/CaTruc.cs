using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class CaTruc
{
    public int MaCaTruc { get; set; }

    public DateTime NgayTruc { get; set; }

    public int MaBacSi { get; set; }

    public int MaKhuVuc { get; set; }

    public int MaPhongKham { get; set; }

    public int MaCa { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
