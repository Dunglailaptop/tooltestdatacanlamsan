using DevExpress.Xpo.DB.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.CrawData;
using ToolTestData.View.NhapLieu.LuotSuIn;

namespace ToolTestData.Presenters
{
    public class CrawDataPresenter
    {
       
        private CrawDataView view;
        private ClsContext repository;
        private BindingSource LuotSuInBindingSource;
        private IEnumerable<object> ListNameTable; 

        public CrawDataPresenter(CrawDataView view, ClsContext repository)
        {
            this.LuotSuInBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.setAllListTableBindingSource(LuotSuInBindingSource);

            loadAllLuotSuInList();
        }

        private void loadAllLuotSuInList()
        {
             ListNameTable = repository.Model.GetEntityTypes()
            .Select(t => new { Name = t.GetTableName() })
            .Distinct()
            .ToList();
            LuotSuInBindingSource.DataSource = ListNameTable;
        }
    }
}
