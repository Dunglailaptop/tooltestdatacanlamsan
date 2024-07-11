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

namespace ToolTestData.View.NganHangMau.NhaCungCap
{
    public partial class NhaCungCapForm : DevExpress.XtraEditors.XtraForm, NhaCungCapView
    {
        public NhaCungCapForm()
        {
            InitializeComponent();
        }

        public void setBindingDataSource(BindingSource NhaCungCapSource)
        {
           gridControl1.DataSource = NhaCungCapSource;
        }

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {

        }
    }
}