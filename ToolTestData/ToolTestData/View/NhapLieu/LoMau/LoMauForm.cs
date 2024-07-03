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

namespace ToolTestData.View.NhapLieu.LoMau
{
    public partial class LoMauForm : DevExpress.XtraEditors.XtraForm, LoMauView
    {
        public LoMauForm()
        {
            InitializeComponent();
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
    }
}