using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HoatChat
{
    public int MaSoHoatChatThuoc { get; set; }

    public string? MaHoatChat { get; set; }

    public string? TenHoatChat { get; set; }

    public string? ChongChiDinh { get; set; }

    public string? ChiDinh { get; set; }

    public string? DuocDongLuc { get; set; }

    public string? DuocLuc { get; set; }

    public string? TacDung { get; set; }

    public int? ToiDa1LanSd { get; set; }

    public int? ToiDa1NgaySd { get; set; }

    public int? ToiDa1LanSdcanNang { get; set; }

    public int? ToiThieu1LanSdcanNang { get; set; }

    public int? ToiDa1NgaySdcanNang { get; set; }

    public int? ToiThieu1NgaySdcanNang { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public bool? KiemSoat { get; set; }

    public bool? HoatChatDacBiet { get; set; }
}
