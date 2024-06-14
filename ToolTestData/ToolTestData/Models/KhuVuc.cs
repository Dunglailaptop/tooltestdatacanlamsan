using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class KhuVuc
{
    public int MaSoKhuVuc { get; set; }

    public string MaKhuVuc { get; set; } = null!;

    public string TenKhuVuc { get; set; } = null!;

    public bool ChoPhepCa { get; set; }

    public int PhuongThucThanhToan { get; set; }

    public string VanBan { get; set; } = null!;

    public string? Tang { get; set; }

    public bool ChoPhepBhyt { get; set; }

    public bool KhuVacXin { get; set; }

    public string LoaiGiaTien { get; set; } = null!;

    public int? MaKhoa { get; set; }

    public bool LaKhuNhanBenh { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
