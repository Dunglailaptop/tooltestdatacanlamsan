using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmYeuCauLinh
{
    public int MaSoYeuCauLinh { get; set; }

    public string MaYeuCauLinh { get; set; } = null!;

    public int MaKho { get; set; }

    public int MaKhoa { get; set; }

    public int TheTich { get; set; }

    public int MaDonVi { get; set; }

    public DateTime NgayYeuCau { get; set; }

    public int Loai { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
