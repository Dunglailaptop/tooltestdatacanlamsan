using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NhapLieu.BacSi;
using ToolTestData.View.NhapLieu.KhuVuc;

namespace ToolTestData.Presenters
{
    public class KhuVucPresenter
    {
        private KhuVucView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<KhuVuc> KhuVucList;

        public KhuVucPresenter(KhuVucView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setKhuVucDataBindingSource(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            KhuVucList = repository.KhuVucs.ToList();
            DataBindingSource.DataSource = KhuVucList;
        }
    }
}
