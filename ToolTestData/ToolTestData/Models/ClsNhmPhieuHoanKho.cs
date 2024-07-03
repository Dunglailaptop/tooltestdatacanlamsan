using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmPhieuHoanKho
{
    public int MaSoPhieuHoanKho { get; set; }

    public string MaPhieuHoanKho { get; set; } = null!;

    public int MaSoPhieuYeuCauLinh { get; set; }

    public string LyDoTra { get; set; } = null!;

    public string LyDo { get; set; } = null!;

    public DateTime GioHoanTra { get; set; }

    public int MaNguoiHoanTra { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public DateTime NgayTao { get; set; }

    public bool TrangThai { get; set; }
}
