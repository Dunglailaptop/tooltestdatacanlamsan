using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTestData.View.NganHangMau.LoaiChePham
{
    public partial class LoaiChePhamForm : DevExpress.XtraEditors.XtraForm, LoaiChePhamView
    {
        public LoaiChePhamForm()
        {
            InitializeComponent();
        }

        public void setBindingSourceData(BindingSource LoaiChePhamSource)
        {
            gridControl1.DataSource = LoaiChePhamSource;
        }

        private void LoaiChePhamForm_Load(object sender, EventArgs e)
        {

        }
    }
}