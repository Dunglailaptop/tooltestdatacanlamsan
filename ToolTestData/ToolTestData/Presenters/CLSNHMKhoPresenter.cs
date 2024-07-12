using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NganHangMau.Kho;
using ToolTestData.View.NhapLieu.BacSi;

namespace ToolTestData.Presenters
{
    public class CLSNHMKhoPresenter
    {
        private CLSNHMKhoView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<ClsNhmKho> NhanVienList;

        public CLSNHMKhoPresenter(CLSNHMKhoView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBindingSource(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            NhanVienList = repository.ClsNhmKhos.ToList();
            DataBindingSource.DataSource = NhanVienList;
        }
    }
}
