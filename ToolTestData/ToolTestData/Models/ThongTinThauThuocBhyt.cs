using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ThongTinThauThuocBhyt
{
    public int MaSoBhytnhaThau { get; set; }

    public string MaBhytnhaThau { get; set; } = null!;

    public DateTime NgayHetHanBhyt { get; set; }

    public DateTime NgayCongBoHieuLuc { get; set; }

    public int BhytloaiThau { get; set; }

    public string BhytnhaThau { get; set; } = null!;

    public string BhytnhaThauGoi { get; set; } = null!;

    public string BenhVienApThau { get; set; } = null!;

    public int BhytsoLuong { get; set; }

    public int BhytsoDkgpnk { get; set; }

    public string SttTt { get; set; } = null!;

    public string SttDmt { get; set; } = null!;

    public int MaThuoc { get; set; }
}
