using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsDichVuChamThem
{
    public int MaSoDichVuChamThem { get; set; }

    public string MaDichVuChamThem { get; set; } = null!;

    public string TenDichVuChamThem { get; set; } = null!;

    public int MaSoDichVuBenhVien { get; set; }

    public decimal GiaDichVuChamThem { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public int UuTien { get; set; }

    public bool CoHieuLuc { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
