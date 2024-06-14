using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DichVuThongTu37
{
    public int MaSoDichVuThongTu37 { get; set; }

    public string MaDichVuThongTu37 { get; set; } = null!;

    public string TenDichVu { get; set; } = null!;

    public decimal GiaDichVu { get; set; }

    public int QuyetDinh { get; set; }

    public DateTime NgayCongBo { get; set; }

    public string GhiChu { get; set; } = null!;

    public bool HieuLuc { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
