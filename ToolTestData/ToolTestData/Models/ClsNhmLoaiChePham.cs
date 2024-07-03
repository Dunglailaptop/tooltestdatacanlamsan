using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmLoaiChePham
{
    public int MaSoLoaiChePham { get; set; }

    public string? MaLoaiChePham { get; set; }

    public string? TenLoaiChePham { get; set; }

    public int? MaSoPhanLoaiChePham { get; set; }

    public int? UuTien { get; set; }

    public int DinhNhomMau { get; set; }

    public int DinhNmbangGiay1 { get; set; }

    public int DinhNmbangGiay2 { get; set; }

    public int DichVuPuc { get; set; }

    public int DichVuPucboSung { get; set; }

    public int LoaiPucth { get; set; }

    public int PucmacDinh { get; set; }

    public int OngAgh { get; set; }

    public int OngMtmuoi { get; set; }

    public bool DuTruDvtheTich { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
