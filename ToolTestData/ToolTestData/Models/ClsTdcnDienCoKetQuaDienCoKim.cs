using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdcnDienCoKetQuaDienCoKim
{
    public int MaSoKetQuaDienCoKim { get; set; }

    public int MaKetQuaDienCoKim { get; set; }

    public int MaSoChiTietPhieuDienCo { get; set; }

    public int CoKhaoSat { get; set; }

    public int Ben { get; set; }

    public int DamKim { get; set; }

    public string TuPhat { get; set; } = null!;

    public int DonViVanDong { get; set; }

    public int KetTap { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
