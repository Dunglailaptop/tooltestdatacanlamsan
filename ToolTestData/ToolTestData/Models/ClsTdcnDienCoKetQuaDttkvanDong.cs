using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdcnDienCoKetQuaDttkvanDong
{
    public int MaSoKetQuaDttkvanDong { get; set; }

    public int MaKetQuaDttkvanDong { get; set; }

    public int MaSoChiTietPhieu { get; set; }

    public int DayThanKinh { get; set; }

    public int Ben { get; set; }

    public int Dml { get; set; }

    public string Mvc { get; set; } = null!;

    public string SongFlatency { get; set; } = null!;

    public string SongFratio { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
