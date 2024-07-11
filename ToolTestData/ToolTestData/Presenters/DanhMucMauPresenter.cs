using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NganHangMau.DanhMucMau;
using ToolTestData.View.NhapLieu.KhuVuc;

namespace ToolTestData.Presenters
{
    public class DanhMucMauPresenter
    {
        private DanhMucMauView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<ClsNhmDanhMucMau> KhuVucList;

        public DanhMucMauPresenter(DanhMucMauView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBindingSourceData(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            KhuVucList = repository.ClsNhmDanhMucMaus.ToList();
            DataBindingSource.DataSource = KhuVucList;
        }
    }
}
