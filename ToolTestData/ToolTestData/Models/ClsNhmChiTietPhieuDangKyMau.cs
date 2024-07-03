using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmChiTietPhieuDangKyMau
{
    public int MaSoChiTietPhieuDangKyMau { get; set; }

    public int MaSoPhieuDangKyMau { get; set; }

    public DateTime NgayDuTru { get; set; }

    public int NguoiNhap { get; set; }

    public int MaSoPhieuChiDinh { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
