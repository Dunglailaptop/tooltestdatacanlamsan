﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTestData.View.NhapLieu.LoMau
{
    public partial class LoMauForm : DevExpress.XtraEditors.XtraForm, LoMauView
    {
        public LoMauForm()
        {
            InitializeComponent();
            gridView1.RowClick += GridView1_RowClick;
        }
        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            // Lấy đối tượng được click
            var view = sender as GridView;
            var clickedRow = view.GetRow(e.RowHandle);
            var columnRowCell = view.GetRowCellValue(e.RowHandle, view.Columns[1]);
            MessageBox.Show(columnRowCell.ToString());
             
        }
        public void SetBindingDataSourceLoMau(BindingSource LoMauSource)
        {

            gridControl1.DataSource = LoMauSource;

        }

        public void SetBindingDataSourceTuiMau(BindingSource TuiMauSource)
        {

            gridControl2.DataSource = TuiMauSource;

        }

        public void show()
        {
            throw new NotImplementedException();
        }

        private void LoMauForm_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}