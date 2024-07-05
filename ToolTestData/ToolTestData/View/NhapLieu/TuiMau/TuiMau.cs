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

namespace ToolTestData.View.NhapLieu.TuiMau
{
    public partial class TuiMau : DevExpress.XtraEditors.XtraForm, TuiMauView
    {
        public TuiMau()
        {
            InitializeComponent();
        }

        public void setBindingDataSourceTuiMau(BindingSource TuiMauList)
        {
            gridControl1.DataSource = TuiMauList;
        }

        private void TuiMau_Load(object sender, EventArgs e)
        {

        }
    }
}