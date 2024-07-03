using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class GoiKham
{
    public int MaSoGoiKham { get; set; }

    public string MaGoiKham { get; set; } = null!;

    public string TenGoiKham { get; set; } = null!;

    public int DoiTuong { get; set; }

    public int SoBenhNhanToiDa { get; set; }

    public int LoaiThanhToan { get; set; }

    public bool TrangThai { get; set; }

    public bool XacNhanSanSang { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
