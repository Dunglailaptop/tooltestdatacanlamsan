using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class TaiLieuDinhKem
{
    public int MaSoTaiLieuDinhKem { get; set; }

    public string MaTaiLieuDinhKem { get; set; } = null!;

    public string TenTaiLieu { get; set; } = null!;

    public string Checksum { get; set; } = null!;

    public string LoaiNoiDung { get; set; } = null!;

    public string DungLuong { get; set; } = null!;

    public string Loai { get; set; } = null!;

    public int? MaBacSi { get; set; }

    public string TenLuuTru { get; set; } = null!;

    public bool TrangThaiIn { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
