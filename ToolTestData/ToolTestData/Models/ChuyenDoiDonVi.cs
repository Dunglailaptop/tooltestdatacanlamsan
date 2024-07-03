using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChuyenDoiDonVi
{
    public int MaSoChuyenDoiDonVi { get; set; }

    public decimal TyLeChuyenDoi { get; set; }

    public string PhepToanChuyenDoi { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int MaDonViGoc { get; set; }

    public int MaDonViDich { get; set; }
}
