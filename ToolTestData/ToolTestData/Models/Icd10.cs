using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Icd10
{
    public int MaSoIcd10 { get; set; }

    public string MaIcd10 { get; set; } = null!;

    public int MaNhomIcd10 { get; set; }

    public int MaLoaiIcd10 { get; set; }

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public int BenhManTinh { get; set; }

    public int GioiTinh { get; set; }

    public int BenhThuongGap { get; set; }

    public int ThuocBaoHiemYte { get; set; }

    public int NgoaiDanhSach { get; set; }

    public bool Icd10daiDien { get; set; }

    public string MoTa { get; set; } = null!;

    public string ChuyenKhoa { get; set; } = null!;

    public bool CanhBao { get; set; }

    public string TenThongTu { get; set; } = null!;

    public bool NhapVien { get; set; }

    public int NgaySuDungThuoc { get; set; }

    public int NgaySuDungThuocNgoaiTru { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
