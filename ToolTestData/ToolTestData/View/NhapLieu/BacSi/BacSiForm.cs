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

namespace ToolTestData.View.NhapLieu.BacSi
{
    public partial class BacSiForm : DevExpress.XtraEditors.XtraForm, BacSiView
    {
        public BacSiForm()
        {
            InitializeComponent();
        }

        public void setBacSiListDataBindingSource(BindingSource BacSiList)
        {
            gridControl1.DataSource = BacSiList;
        }

        private void BacSiForm_Load(object sender, EventArgs e)
        {

        }
    }
}