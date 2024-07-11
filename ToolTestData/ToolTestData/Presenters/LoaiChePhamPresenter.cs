using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NganHangMau.LoaiChePham;
using ToolTestData.View.NhapLieu.TuiMau;

namespace ToolTestData.Presenters
{
    public class LoaiChePhamPresenter
    {
        private LoaiChePhamView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<ClsNhmLoaiChePham> TuiMauList;

        public LoaiChePhamPresenter(LoaiChePhamView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBindingSourceData(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            TuiMauList = repository.ClsNhmLoaiChePhams.ToList();
            DataBindingSource.DataSource = TuiMauList;
        }
    }
}
