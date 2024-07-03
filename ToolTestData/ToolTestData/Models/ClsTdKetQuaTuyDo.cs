using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdKetQuaTuyDo
{
    public int MaSoKetQuaTuyDo { get; set; }

    public string MaKetQuaTuyDo { get; set; } = null!;

    public int Myeloblast { get; set; }

    public int Promyelocyte { get; set; }

    public int NeutrophilSeries { get; set; }

    public int BandAndSegment { get; set; }

    public int EosinophileSeries { get; set; }

    public int BasophilSeries { get; set; }

    public string ChatLuongMau { get; set; } = null!;

    public int ErythroidSeries { get; set; }

    public int Proerythroblast { get; set; }

    public int BasophilicErythroblast { get; set; }

    public int PolychromaticErythroblast { get; set; }

    public int OrthochromicErythroblast { get; set; }

    public int Lymphocytes { get; set; }

    public int PlasmaCells { get; set; }

    public int Monocytes { get; set; }

    public int Histiocytes { get; set; }

    public int Megakaryocytes { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
