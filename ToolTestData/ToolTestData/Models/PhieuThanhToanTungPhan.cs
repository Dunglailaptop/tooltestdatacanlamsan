using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhieuThanhToanTungPhan
{
    public int MaSoPhieuThanhToan { get; set; }

    public int MaDichVu { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public int LoaiGia { get; set; }

    public int MaChiTietDotKham { get; set; }

    public int MaBaoHiemYte { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
