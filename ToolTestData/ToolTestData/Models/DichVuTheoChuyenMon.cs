using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DichVuTheoChuyenMon
{
    public int MaSoDichVuTheoChuyenMon { get; set; }

    public string MaDichVuTheoChuyenMon { get; set; } = null!;

    public string TenDichVuTheoChuyenMon { get; set; } = null!;

    public int ThuTuSapXep { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public bool TrangThai { get; set; }
}
