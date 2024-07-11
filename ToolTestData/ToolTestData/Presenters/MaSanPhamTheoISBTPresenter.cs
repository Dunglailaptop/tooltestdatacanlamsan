using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NganHangMau.MaSanPhamTheoISBT;
using ToolTestData.View.NhapLieu.KhuVuc;

namespace ToolTestData.Presenters
{
    public class MaSanPhamTheoISBTPresenter
    {
        private MaSanPhamTheoISBT view;
        private ClsContext repository;
        private BindingSource DataBindingSource;
        private IEnumerable<ClsNhmMaSanPhamIsbt> KhuVucList;

        public MaSanPhamTheoISBTPresenter(MaSanPhamTheoISBT view, ClsContext repository)
        {
            this.DataBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setBindingSource(DataBindingSource);

            loadAll();
        }

        private void loadAll()
        {
            KhuVucList = repository.ClsNhmMaSanPhamIsbts.ToList();
            DataBindingSource.DataSource = KhuVucList;
        }
    }
}
