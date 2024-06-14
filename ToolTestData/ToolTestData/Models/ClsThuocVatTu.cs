using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsThuocVatTu
{
    public int MaSoClsthuocVatTu { get; set; }

    public string MaClsthuocVatTu { get; set; } = null!;

    public int MaSoThuoc { get; set; }

    public string Hisid { get; set; } = null!;

    public string TenThuoc { get; set; } = null!;

    public int Loai { get; set; }

    public int? LoaiBaoCao { get; set; }

    public string DonVi { get; set; } = null!;

    public bool SoChan { get; set; }

    public int ApDungCho { get; set; }

    public decimal GiaTien { get; set; }

    public int UuTien { get; set; }

    public bool CoHieuLuc { get; set; }

    public bool? In { get; set; }

    public string? TenIn { get; set; }

    public string ChuyenDoiIn { get; set; } = null!;

    public string? DonViIn { get; set; }

    public bool Hu { get; set; }

    public bool Test { get; set; }

    public int MaXuatKho { get; set; }

    public int TrangThai { get; set; }

    public string HanhDong { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public int NguoiNhap { get; set; }

    public DateTime NgayTao { get; set; }
}
