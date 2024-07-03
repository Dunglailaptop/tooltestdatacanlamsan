using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class MauKetQua
{
    public int MaSoMauKetQua { get; set; }

    public string MaMauKetQua { get; set; } = null!;

    public string TenMau { get; set; } = null!;

    public int MaNhanVien { get; set; }

    public int UuTien { get; set; }

    public int ApDungChoGt { get; set; }

    public string KetLuan { get; set; } = null!;

    public string DeNghi { get; set; } = null!;

    public string MoTaKetQua { get; set; } = null!;

    public int MaSoDichVuBenhVien { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public int MaSoNhanVien { get; set; }

    public int MaSoLoaiMauKetQua { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
