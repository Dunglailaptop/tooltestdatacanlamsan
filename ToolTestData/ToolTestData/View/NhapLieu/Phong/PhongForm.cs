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

namespace ToolTestData.View.NhapLieu.Phong
{
    public partial class PhongForm : DevExpress.XtraEditors.XtraForm, PhongView
    {
        public PhongForm()
        {
            InitializeComponent();
        }

        public void setPhongListDataBinding(BindingSource PhongList)
        {
            gridControl1.DataSource = PhongList;
        }

        private void PhongForm_Load(object sender, EventArgs e)
        {

        }
    }
}