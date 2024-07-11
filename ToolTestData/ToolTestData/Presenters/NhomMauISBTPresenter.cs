using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NganHangMau.NhomMauISBT;
using ToolTestData.View.NhapLieu.KhuVuc;

namespace ToolTestData.Presenters
{
    public class NhomMauISBTPresenter
    {
        private NhomMauISBT view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<ClsNhmNhomMauTheoIsbt> KhuVucList;

        public NhomMauISBTPresenter(NhomMauISBT view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBindingDataSource(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            KhuVucList = repository.ClsNhmNhomMauTheoIsbts.ToList();
            DataBindingSource.DataSource = KhuVucList;
        }
    }
}
