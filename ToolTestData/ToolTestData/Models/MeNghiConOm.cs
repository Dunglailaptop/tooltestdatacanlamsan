using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class MeNghiConOm
{
    public int MaGiayMeNghiConOm { get; set; }

    public int MaBenhNhan { get; set; }

    public int MaBhyt { get; set; }

    public int MaCongTy { get; set; }

    public int MaDotKham { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
