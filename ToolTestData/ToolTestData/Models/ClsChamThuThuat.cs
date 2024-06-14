using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsChamThuThuat
{
    public int MaSoChamThuThuat { get; set; }

    public int MaChamThuThuat { get; set; }

    public DateTime NgayThucHien { get; set; }

    public int NguoiThucHien { get; set; }

    public int DanhGia { get; set; }

    public int SoLuong { get; set; }

    public int PhanLoai { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
