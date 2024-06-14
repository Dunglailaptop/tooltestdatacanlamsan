using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaSatMoTaHinhAnh
{
    public int MaSoMoTaHinhAnh { get; set; }

    public string MaMoTaHinhAnh { get; set; } = null!;

    public int MaSoHoSoKhamBenh { get; set; }

    public int MaSoTm { get; set; }

    public int MaSoDopplerDongQuaVanHaiLa { get; set; }

    public int MaSoDopplerDongQuaVanBaLa { get; set; }

    public int MaSoDopplerDongQuaVanDongMachPhoi { get; set; }

    public int MaSoDopplerDongQuaVanDongMachChu { get; set; }

    public int MaSo2D { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
