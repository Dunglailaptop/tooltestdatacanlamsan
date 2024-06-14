using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhomIcd10
{
    public int MaSoNhomIcd10 { get; set; }

    public string MaNhomIcd10 { get; set; } = null!;

    public int MaChuongIcd10 { get; set; }

    public bool NhapVien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
