using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdMoTaTieuBanMauNgoaiVi
{
    public int MaSoMoTaTieuBanMauNgoaiVi { get; set; }

    public string MaMoTaTieuBanMauNgoaiVi { get; set; } = null!;

    public string HongCau { get; set; } = null!;

    public string BachCau { get; set; } = null!;

    public string TieuCau { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
