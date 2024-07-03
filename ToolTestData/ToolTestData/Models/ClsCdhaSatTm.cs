using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaSatTm
{
    public int MaSoTm { get; set; }

    public string MaTm { get; set; } = null!;

    public double Dmchu { get; set; }

    public double NhiTrai { get; set; }

    public double ThatPhai { get; set; }

    public double Ivsd { get; set; }

    public double Ivss { get; set; }

    public double Lvidd { get; set; }

    public double Lvids { get; set; }

    public double Lvpwd { get; set; }

    public double Lvpws { get; set; }

    public double Rvdd { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
