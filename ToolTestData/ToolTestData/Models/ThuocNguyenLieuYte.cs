using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ThuocNguyenLieuYte
{
    public int MaSoThuoc { get; set; }

    public string MaThuoc { get; set; } = null!;

    public string MaThuocDqg { get; set; } = null!;

    public int MaHangSanXuat { get; set; }

    public int MaQuocGia { get; set; }

    public int MaPhanLoaiDocDuoc { get; set; }

    public int MaDuocLy { get; set; }

    public int PhanLoaiKhuDieuTri { get; set; }

    public int ThoiGianBaoQuan { get; set; }

    public int MaDangBaoChe { get; set; }

    public int MaDonVi { get; set; }

    public int MaCachDung { get; set; }

    public int TheTich { get; set; }

    public int MaDonViTheTich { get; set; }

    public int SoLuongQuyDoiSd { get; set; }

    public int MaDonViSd { get; set; }

    public int SoLuongQuyDoiLieuDung { get; set; }

    public int MaDonViTheoLieu { get; set; }

    public int MaSoPhanLoaiThuoc { get; set; }

    public int MaSoDuongDung { get; set; }

    public string TenThuocThuongMai { get; set; } = null!;

    public string TenGoc { get; set; } = null!;

    public string TenDocQuyen { get; set; } = null!;

    public string TenBhyt { get; set; } = null!;

    public string ThanhPhan { get; set; } = null!;

    public string MaAtc { get; set; } = null!;

    public string SoDkgpnk { get; set; } = null!;

    public bool? ThuocRaLe { get; set; }

    public decimal GiaBan { get; set; }

    public decimal GiaNhap { get; set; }

    public decimal GiaNoiVien { get; set; }

    public decimal GiaNhaThuoc { get; set; }

    public decimal GiaBhyt { get; set; }

    public string HuongDanSuDung { get; set; } = null!;

    public bool? ThuocUngThu { get; set; }

    public string DongGoi { get; set; } = null!;

    public string HamLuong { get; set; } = null!;

    public int LanDung { get; set; }

    public int LieuDung { get; set; }

    public string TacDung { get; set; } = null!;

    public string TacDungPhu { get; set; } = null!;

    public bool? ThuocPhatNguyen { get; set; }

    public bool? ThuocBanChan { get; set; }

    public bool? CoHanDung { get; set; }

    public bool? HangTonKho { get; set; }

    public int ThangTuoiChiDinh { get; set; }

    public int LoaiThuanHop { get; set; }

    public string MaBhyt { get; set; } = null!;

    public string BhytquyetDinh { get; set; } = null!;

    public int NhomVatTu { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
