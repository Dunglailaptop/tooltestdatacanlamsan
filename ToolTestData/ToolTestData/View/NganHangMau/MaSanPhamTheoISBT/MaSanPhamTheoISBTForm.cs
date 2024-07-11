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

namespace ToolTestData.View.NganHangMau.MaSanPhamTheoISBT
{
    public partial class MaSanPhamTheoISBTForm : DevExpress.XtraEditors.XtraForm, MaSanPhamTheoISBT
    {
        public MaSanPhamTheoISBTForm()
        {
            InitializeComponent();
        }

        public void setBindingSource(BindingSource bindingSource)
        {
           gridControl1.DataSource = bindingSource;
        }

        private void MaSanPhamTheoISBTForm_Load(object sender, EventArgs e)
        {

        }
    }
}