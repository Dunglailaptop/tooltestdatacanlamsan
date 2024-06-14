using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DanhMucHoatChatThuoc
{
    public int MaChiTietHoatChatThuoc { get; set; }

    public int MaSoThuoc { get; set; }

    public string MaThuoc { get; set; } = null!;

    public int MaHoatChat { get; set; }

    public string TenThuoc { get; set; } = null!;

    public string TenHoatChat { get; set; } = null!;

    public string HamLuong { get; set; } = null!;

    public string HamLuongDonViTinhText { get; set; } = null!;

    public string HamLuongGoc { get; set; } = null!;

    public string TheTich { get; set; } = null!;

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
