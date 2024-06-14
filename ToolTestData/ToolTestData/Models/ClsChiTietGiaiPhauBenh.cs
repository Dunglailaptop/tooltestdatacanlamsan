using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsChiTietGiaiPhauBenh
{
    public int MaSoChiTietGiaiPhauBenh { get; set; }

    public string MaChiTietGiaiPhauBenh { get; set; } = null!;

    public int MaSoPhieuChiDinh { get; set; }

    public DateTime GioNhanMau { get; set; }

    public DateTime GioTraKq { get; set; }

    public DateTime InLanDau { get; set; }

    public string ViTriLaySinhThiet { get; set; } = null!;

    public string NhanXetDaiThe { get; set; } = null!;

    public string NhanXetViThe { get; set; } = null!;

    public bool PhuHop { get; set; }

    public int MaKhoaThucHien { get; set; }

    public int MaBsdocKetQua { get; set; }

    public int KtvthucHien { get; set; }

    public int MaSoMauNhuom { get; set; }

    public int MaSoMauKetQua { get; set; }

    public int MaSoThietBi { get; set; }

    public int MaSoTaiLieuDinhKem { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
