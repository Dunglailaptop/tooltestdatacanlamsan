using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhaThuoc
{
    public int MaSoNhaThuoc { get; set; }

    public string MaNhaThuoc { get; set; } = null!;

    public string TenNhaThuoc { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public int MaCoSo { get; set; }

    public int LoaiKhoLe { get; set; }

    public int LoaiKho { get; set; }

    public int MaKhuVuc { get; set; }

    public int? Tang { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
