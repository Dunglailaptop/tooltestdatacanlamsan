using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTestData.Models;

namespace ToolTestData.View.NganHangMau.DanhMucMau
{
    public partial class DanhMucMauForm : DevExpress.XtraEditors.XtraForm, DanhMucMauView
    {
        public DanhMucMauForm()
        {
            InitializeComponent();
            gridView1.PostEditor();
            gridView1.CellValueChanged += GridView1_CellValueChanged;

        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var entity = gridView1.GetRow(e.RowHandle) as ClsNhmDanhMucMau;
            if (entity != null)
            {
                using (var context = new ClsContext())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            // Thực hiện các hành động cập nhật dữ liệu ở đây
        }

        public void setBindingSourceData(BindingSource DanhMucMauList)
        {
            gridControl1.DataSource = DanhMucMauList;
        }

        private void DanhMucMauForm_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}