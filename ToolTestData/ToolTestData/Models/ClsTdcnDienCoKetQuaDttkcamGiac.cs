using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdcnDienCoKetQuaDttkcamGiac
{
    public int MaSoKetQuaDttkcamGiac { get; set; }

    public int MaKetQuaDttkcamGiac { get; set; }

    public int MaSoChiTietPhieuDienCo { get; set; }

    public int DayThanKinh { get; set; }

    public int Ben { get; set; }

    public int Dsl { get; set; }

    public string Scv { get; set; } = null!;

    public string BienDo { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
