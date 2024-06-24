using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NhapLieu.BacSi;
using ToolTestData.View.NhapLieu.LuotSuIn;

namespace ToolTestData.Presenters
{
    public class BacSiPresenter
    {
        private BacSiView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<NhanVien> NhanVienList;

        public BacSiPresenter(BacSiView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBacSiListDataBindingSource(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            NhanVienList = repository.NhanViens.ToList();
            DataBindingSource.DataSource = NhanVienList;
        }
    }
}
