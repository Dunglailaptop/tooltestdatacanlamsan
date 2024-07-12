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

namespace ToolTestData.View.NganHangMau.Kho
{
    public partial class CLSNHMKhoForm : DevExpress.XtraEditors.XtraForm, CLSNHMKhoView
    {
        public CLSNHMKhoForm()
        {
            InitializeComponent();
        }

        public void setBindingSource(BindingSource KhoMauList)
        {
            gridControl1.DataSource = KhoMauList;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}