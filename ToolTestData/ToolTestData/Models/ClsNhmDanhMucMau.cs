using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmDanhMucMau
{
    public int MaSoDanhMucMau { get; set; }

    public string MaDanhMucMau { get; set; } = null!;

    public string TenDanhMucMau { get; set; } = null!;

    public string TenVietTatDanhMucMau { get; set; } = null!;

    public int LoaiMau { get; set; }

    public decimal Gia { get; set; }

    public double TheTich { get; set; }

    public double TheTichBaoCao { get; set; }

    public int DoUuTien { get; set; }

    public bool CoHieuLuc { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public DateTime NgayTao { get; set; }

    public int MaSoThuoc { get; set; }

    public int MaSoLoaiChePham { get; set; }
}
