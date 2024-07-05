using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NhapLieu.Phong;
using ToolTestData.View.NhapLieu.TuiMau;

namespace ToolTestData.Presenters
{
    public class TuiMauPresenter
    {
        private TuiMauView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<ClsNhmTuiMau> TuiMauList;

        public TuiMauPresenter(TuiMauView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBindingDataSourceTuiMau(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            TuiMauList = repository.ClsNhmTuiMaus.ToList();
            DataBindingSource.DataSource = TuiMauList;
        }
    }
}
