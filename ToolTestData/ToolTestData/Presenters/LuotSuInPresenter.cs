using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.Presenters;
using ToolTestData.View.NhapLieu.LuotSuIn;

namespace ToolTestData.Presenters
{
    public class LuotSuInPresenter
    {
        private LuotSuInView view;
        private ClsContext repository;
        private BindingSource LuotSuInBindingSource;
        private IEnumerable<ClsNhmLoaiChePham> LuotSuInList;

        public LuotSuInPresenter(LuotSuInView view,ClsContext repository)
        {
            this.LuotSuInBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SetListLuotSuInBindingSource(LuotSuInBindingSource);

            loadAllLuotSuInList();
        }

        private void loadAllLuotSuInList()
        {
            LuotSuInList = repository.ClsNhmLoaiChePhams.ToList();
            LuotSuInBindingSource.DataSource = LuotSuInList;
        }
    }
}
