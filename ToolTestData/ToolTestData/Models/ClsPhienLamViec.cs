using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsPhienLamViec
{
    public int MaSoPhienLamViec { get; set; }

    public string MaPhienLamViec { get; set; } = null!;

    public string TenPhienLamViec { get; set; } = null!;

    public int MaSoNguoiDung { get; set; }

    public int MaSoKhoa { get; set; }

    public int MaSoKios { get; set; }

    public int MaSoPhongKham { get; set; }

    public int MaSoCa { get; set; }

    public int SoChoGoi { get; set; }

    public int SoDaGoi { get; set; }

    public string DiaChiIp { get; set; } = null!;

    public bool TuGoi { get; set; }

    public bool AmThanh { get; set; }
}
