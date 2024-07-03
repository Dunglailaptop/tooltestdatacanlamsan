using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmPhieuYeuCauLinh
{
    public string MaXuatKho { get; set; } = null!;

    public int MaKho { get; set; }

    public int MaKhoa { get; set; }

    public int MaNguoiNhan { get; set; }

    public string TenKhac { get; set; } = null!;

    public DateTime NgayYeuCau { get; set; }

    public DateTime TgPhatMau { get; set; }

    public int MaSoPhieuDangKy { get; set; }

    public int MaNguoiXuat { get; set; }

    public DateTime GioXuatKho { get; set; }

    public int Loai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int MaSoPhieuYeuCauLinh { get; set; }

    public int MaSoTuiMau { get; set; }

    public bool TrangThai { get; set; }
}
