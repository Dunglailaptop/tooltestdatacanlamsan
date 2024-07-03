using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdcnDienCoKetQuaHstgtiemCoTay
{
    public int MaSoKetQuaHstgtiemCoTay { get; set; }

    public int MaKetQuaHstgtiemCoTay { get; set; }

    public int MaSoChiTietPhieuDienCo { get; set; }

    public int CacThongSo { get; set; }

    public string TayPhai { get; set; } = null!;

    public string GiaTriSoSanh { get; set; } = null!;

    public string TayTrai { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
