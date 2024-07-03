using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsSoDaCap
{
    public int MaSoDaCap { get; set; }

    public int Stt { get; set; }

    public int MaSoKios { get; set; }

    public DateTime GioLaySo { get; set; }

    public DateTime? GioGoiSo { get; set; }

    public DateTime? GioHenKetQua { get; set; }

    public DateTime? GioTraKetQua { get; set; }

    public int TrangThai { get; set; }
}
