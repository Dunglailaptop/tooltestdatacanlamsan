using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class TuongTacThuoc
{
    public int MaTuongTacThuoc { get; set; }

    public int? MaHoatChatThuNhat { get; set; }

    public int? MaHoatChatThuHai { get; set; }

    public int MucDo { get; set; }

    public string? HauQua { get; set; }

    public string? CoChe { get; set; }

    public string? XuLy { get; set; }

    public string? GhiChu { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
