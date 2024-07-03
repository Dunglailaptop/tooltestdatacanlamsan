using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsGpbMauNhuom
{
    public int MaSoMauNhuom { get; set; }

    public int MaMauNhuom { get; set; }

    public string TenMauNhuom { get; set; } = null!;

    public int UuTien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
