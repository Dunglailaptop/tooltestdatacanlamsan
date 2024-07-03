using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DichVuDangGoi
{
    public int MaSoDichVuDangGoi { get; set; }

    public string MaDichVuDangGoi { get; set; } = null!;

    public string TenDichVuDangGoi { get; set; } = null!;

    public int DoiTuong { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int MaNhomDichVu { get; set; }
}
