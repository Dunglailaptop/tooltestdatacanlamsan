using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaChiTietPhieuDoApLucHmtt
{
    public int MaSoPhieuDoApLucHmtt { get; set; }

    public string MaPhieuDoApLucHmtt { get; set; } = null!;

    public DateTime GioTiepNhan { get; set; }

    public DateTime GioThucHien { get; set; }

    public int MaSoClsthuocCuaBn { get; set; }

    public int MaSoPhieu { get; set; }

    public int NoiThucHien { get; set; }

    public int BacSiDocKq { get; set; }

    public int KtvthucHien { get; set; }

    public int MaSoMauKetQua { get; set; }

    public int MaSoThietBi { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
