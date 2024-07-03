using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmBienBanHuy
{
    public int MaSoBienBanHuy { get; set; }

    public string MaBienBanHuy { get; set; } = null!;

    public int TrangThaiBbh { get; set; }

    public string HinhAnhBienBan { get; set; } = null!;

    public string LyDo { get; set; } = null!;

    public DateTime GioTao { get; set; }

    public int NguoiTao { get; set; }

    public int NguoiDuyet { get; set; }

    public DateTime GioDuyet { get; set; }

    public DateTime GioXacNhan { get; set; }

    public int MaSoTuiMau { get; set; }

    public string ChuThich { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
