using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTestData.View.CrawData
{
    public partial class CrawDataForm : DevExpress.XtraEditors.XtraForm, CrawDataView
    {
        private BarManager barManager;
        private Bar bar;
        private BarEditItem barEditItemComboBox;
        private RepositoryItemComboBox repositoryItemComboBox;
        public CrawDataForm()
        {
            InitializeComponent();
            gridView1.RowClick += GridView1_RowClick;
           
        }


      
        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            // Lấy đối tượng được click
            var view = sender as GridView;
            var clickedRow = view.GetRow(e.RowHandle);

            if (clickedRow != null)
            {
                string filePath = ((dynamic)clickedRow).FilePath;
                MessageBox.Show($"Bạn đã click vào file: {((dynamic)clickedRow).FileName}");
                LoadJsonContentToGridControl(filePath);
            }
        }
        private void LoadJsonContentToGridControl(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"File {filePath} không tồn tại. Vui lòng kiểm tra lại đường dẫn.");
                return;
            }

            // Xóa các cột hiện tại trong GridView của gridControl2
            gridView2.Columns.Clear();

            string jsonContent = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<List<object>>(jsonContent);

            if (data != null)
            {
                gridControl2.DataSource = data;

                // Tạo lại cột dựa trên dữ liệu mới
                gridView2.PopulateColumns();
            }
            else
            {
                MessageBox.Show("Không thể đọc dữ liệu từ file JSON.");
            }
        }

        private void CrawDataForm_Load(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Tạo đường dẫn tương đối tới thư mục chứa các file JSON
            string folderPath = Path.Combine(baseDirectory, @"..\..\..\..\ToolTestData\View\CrawData\Json");

            // Kiểm tra xem thư mục có tồn tại không
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show($"Thư mục {folderPath} không tồn tại. Vui lòng kiểm tra lại đường dẫn.");
                return;
            }
            var jsonFiles = Directory.GetFiles(folderPath, "*.json");

            // Tạo danh sách các đối tượng chứa thông tin file
            var fileInfos = jsonFiles.Select(file => new FileInfo(file)).Select(fi => new
            {
                FileName = fi.Name,
                FilePath = fi.FullName,
                FileSize = fi.Length,
                CreationTime = fi.CreationTime
            }).ToList();

            // Load danh sách file vào DataGridView
            gridControl1.DataSource = fileInfos;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

       

        public void show()
        {
            throw new NotImplementedException();
        }

       

        public void setAllListTableBindingSource(System.Windows.Forms.BindingSource TableListSource)
        {
           
            lookUpEdit1.Properties.DataSource = TableListSource;
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.ValueMember = "Name";

        }
    }
}