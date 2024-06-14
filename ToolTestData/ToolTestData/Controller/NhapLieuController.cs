using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTestData.Models;

namespace ToolTestData.Controller
{
    public class NhapLieuController
    {
        private readonly ClsContext _clsContext;
        
        public NhapLieuController(ClsContext clsContext)
        {
            _clsContext = clsContext;
        }

        public async Task<List<ClsPhieuChiDinh>> GetDataPhieuChiDinhAsync()
        {
            List<ClsPhieuChiDinh> clsPhieuChiDinhs = new List<ClsPhieuChiDinh>();

            clsPhieuChiDinhs = _clsContext.ClsPhieuChiDinhs.ToList();

            return clsPhieuChiDinhs;
        }


    }
}
