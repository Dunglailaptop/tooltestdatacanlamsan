using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsPhanLoaiNhomDichVu
{
    public int MaSoPhanLoaiNhomDichVu { get; set; }

    public string MaPhanLoaiNhomDichVu { get; set; } = null!;

    public string TenPhanLoaiNhomDichVu { get; set; } = null!;

    public int MaSoLoaiDichVu { get; set; }

    public int MaSoDichVuBenhVien { get; set; }

    public int UuTien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
