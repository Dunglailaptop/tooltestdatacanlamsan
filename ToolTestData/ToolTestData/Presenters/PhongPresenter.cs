using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NhapLieu.KhuVuc;
using ToolTestData.View.NhapLieu.Phong;

namespace ToolTestData.Presenters
{
    public class PhongPresenter
    {
        private PhongView view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<PhongKham> PhongKhamList;

        public PhongPresenter(PhongView view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setPhongListDataBinding(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            PhongKhamList = repository.PhongKhams.ToList();
            DataBindingSource.DataSource = PhongKhamList;
        }
    }
}
