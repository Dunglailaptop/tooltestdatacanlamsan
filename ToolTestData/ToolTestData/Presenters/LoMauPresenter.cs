using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolTestData.Models;
using ToolTestData.View.NhapLieu.LoMau;
using ToolTestData.View.NhapLieu.LuotSuIn;

namespace ToolTestData.Presenters
{
    public class LoMauPresenter
    {
        private LoMauView view;
        private ClsContext repository;
        private BindingSource DataBindingSourceLoMau;
        private BindingSource DataBindingSourceTuiMau;
        private IEnumerable<ClsNhmLoMau> ClsLoMauList;
        private IEnumerable<ClsNhmTuiMau> ClsTuiMauList;

        public LoMauPresenter(LoMauView view, ClsContext repository)
        {
            this.DataBindingSourceLoMau = new BindingSource();
            this.DataBindingSourceTuiMau = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SetBindingDataSourceLoMau(DataBindingSourceLoMau);
            this.view.SetBindingDataSourceTuiMau(DataBindingSourceTuiMau);
            loadAll();
        }
        public void AddDatabase()
        {

        }

        private void loadAll()
        {
            try
            {
                // Chỉ định các cột cần thiết

                List<string> loMauColumns = new List<string> { "STT","SoBienLai", "MaSoNhaCungCap", "TrangThaiHieuLuc","NgayTao" }; // Thay bằng tên các cột thực tế
                List<string> tuiMauColumns = new List<string> { "ColumnA", "ColumnB", "ColumnC" }; // Thay bằng tên các cột thực tế

             
                ClsLoMauList = repository.ClsNhmLoMaus.ToList();
                ClsTuiMauList = repository.ClsNhmTuiMaus.ToList();

          
                // Chuyển đổi danh sách thành DataTable chỉ với các cột cần thiết
                DataTable loMauTable = ConvertToDataTableWithSpecificColumns<ClsNhmLoMau>((IList<ClsNhmLoMau>)ClsLoMauList, loMauColumns);
                DataTable tuiMauTable = ConvertToDataTableWithSpecificColumns<ClsNhmTuiMau>((IList<ClsNhmTuiMau>)ClsTuiMauList, tuiMauColumns);
                DataBindingSourceLoMau.DataSource = loMauTable;
                DataBindingSourceTuiMau.DataSource = ClsTuiMauList;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        public DataTable ConvertToDataTableWithSpecificColumns<T>(IList<T> data, List<string> columnsToKeep)
        {
            DataTable table = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            // Thêm các cột cần thiết vào DataTable
            table.Columns.Add("STT", typeof(int)); // Thêm cột STT
            foreach (string column in columnsToKeep)
            {
                var prop = properties.Find(column, true);
                if (prop != null)
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
            }

            // Thêm các hàng vào DataTable
            int stt = 1; // Khởi tạo biến đếm STT
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                row["STT"] = stt++; // Gán giá trị cho cột STT
                foreach (string column in columnsToKeep)
                {
                    var prop = properties.Find(column, true);
                    if (prop != null)
                    {
                        row[column] = prop.GetValue(item) ?? DBNull.Value;
                    }
                }
                table.Rows.Add(row);
            }

            return table;
        }

    }
}
