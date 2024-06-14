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

        public async Task<List<MayTram>> GetDataMayTramAsync()
        {
            List<MayTram> clsPhieuChiDinhs = new List<MayTram>();

            clsPhieuChiDinhs = _clsContext.MayTrams.ToList();

            return clsPhieuChiDinhs;
        }


    }
}
