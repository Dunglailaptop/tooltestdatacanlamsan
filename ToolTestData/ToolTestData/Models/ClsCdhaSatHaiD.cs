using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaSatHaiD
{
    public int MaSo2D { get; set; }

    public string Ma2D { get; set; } = null!;

    public string TuTheTim { get; set; } = null!;

    public string MangNgoaiTim { get; set; } = null!;

    public string NhiTrai { get; set; } = null!;

    public string NhiPhai { get; set; } = null!;

    public string TinhMach { get; set; } = null!;

    public string Dmchu { get; set; } = null!;

    public string Dmphoi { get; set; } = null!;

    public string Dmvanh { get; set; } = null!;

    public string XoangVanh { get; set; } = null!;

    public string VanHaiLa { get; set; } = null!;

    public string VanBaLa { get; set; } = null!;

    public string VanDmc { get; set; } = null!;

    public string VanDmp { get; set; } = null!;

    public bool ChonIn2D { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
