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

namespace ToolTestData.View.NganHangMau.NhomMauISBT
{
    public partial class NhomMauISBTForm : DevExpress.XtraEditors.XtraForm, NhomMauISBT
    {
        public NhomMauISBTForm()
        {
            InitializeComponent();
        }

        public void setBindingDataSource(BindingSource NhomMauBindingSource)
        {
            gridControl1.DataSource = NhomMauBindingSource;
        }

        private void NhomMauISBTForm_Load(object sender, EventArgs e)
        {

        }
    }
}