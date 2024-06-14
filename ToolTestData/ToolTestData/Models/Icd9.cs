using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Icd9
{
    public int MaSoIcd9 { get; set; }

    public string MaIcd9 { get; set; } = null!;

    public int MaNhomIcd9 { get; set; }

    public int MaPhanLoaiIcd9 { get; set; }

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public int GioiTinh { get; set; }

    public int ThuocBaoHiemYte { get; set; }

    public int NgoaiDanhSach { get; set; }

    public bool Icd9daiDien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
