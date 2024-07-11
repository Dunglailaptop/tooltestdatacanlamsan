using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NganHangMau.NhaCungCap;
using ToolTestData.View.NhapLieu.Phong;

namespace ToolTestData.Presenters
{
    public class NhaCungCapPresenter
    {
        private NhaCungCapView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<ClsNhmNhaCungCap> PhongKhamList;

        public NhaCungCapPresenter(NhaCungCapView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBindingDataSource(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            PhongKhamList = repository.ClsNhmNhaCungCaps.ToList();
            DataBindingSource.DataSource = PhongKhamList;
        }
    }
}
