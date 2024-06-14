using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class BenhNhanTrenHangCho
{
    public int MaSoBenhNhanTrenHangCho { get; set; }

    public DateTime ThoiGianBatDau { get; set; }

    public DateTime ThoiGianKetThuc { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public int MaSoBenhNhan { get; set; }

    public int MaSoHangChoBenhNhan { get; set; }

    public int TrangThai { get; set; }
}
