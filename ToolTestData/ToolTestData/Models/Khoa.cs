using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Khoa
{
    public int MaSoKhoa { get; set; }

    public string MaKhoa { get; set; } = null!;

    public string TenKhoaTiengViet { get; set; } = null!;

    public string TenKhoaTiengAnh { get; set; } = null!;

    public string MoTaTiengViet { get; set; } = null!;

    public string MoTaTiengAnh { get; set; } = null!;

    public int LoaiKhoa { get; set; }

    public int MaKhoi { get; set; }

    public int MaKhoaBhyt { get; set; }

    public int TruongKhoa { get; set; }

    public bool CoPhauThuat { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int? MaCoSo { get; set; }
}
