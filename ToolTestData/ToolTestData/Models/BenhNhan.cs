using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class BenhNhan
{
    public int MaSoBenhNhan { get; set; }

    public string MaBenhNhan { get; set; } = null!;

    public string MaPhatSinh { get; set; } = null!;

    public string TenBenhNhan { get; set; } = null!;

    public int GioiTinh { get; set; }

    public DateTime NgaySinh { get; set; }

    public int MaDanToc { get; set; }

    public int MaQuocTich { get; set; }

    public int? DiaChiThuongTru { get; set; }

    public int? DiaChiTamTru { get; set; }

    public string? HoTenBa { get; set; }

    public string? SoDienThoaiBa { get; set; }

    public string? HoTenMe { get; set; }

    public string? SoDienThoaiMe { get; set; }

    public DateTime? LanKhamCuoi { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
