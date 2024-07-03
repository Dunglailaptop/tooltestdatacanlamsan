using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhomIcd9
{
    public int MaSoNhomIcd9 { get; set; }

    public string MaNhomIcd9 { get; set; } = null!;

    public int MaChuongIcd9 { get; set; }

    public bool NhapVien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
