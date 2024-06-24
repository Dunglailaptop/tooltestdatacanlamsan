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

namespace ToolTestData.View.NhapLieu.KhuVuc
{
    public partial class KhuVucForm : DevExpress.XtraEditors.XtraForm, KhuVucView
    {
        public KhuVucForm()
        {
            InitializeComponent();
        }

        public void setKhuVucDataBindingSource(BindingSource KhuVucList)
        {
            gridControl1.DataSource = KhuVucList;
        }

        private void KhuVucForm_Load(object sender, EventArgs e)
        {

        }
    }
}