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

namespace ToolTestData.View.NhapLieu.LuotSuIn
{
    public partial class LuotSuInForm : DevExpress.XtraEditors.XtraForm, LuotSuInView
    {

        public LuotSuInForm()
        {
            InitializeComponent();
            
        }

        public void SetListLuotSuInBindingSource(BindingSource LuotSuInList)
        {
            gridControl1.DataSource = LuotSuInList;
        }

        public void show()
        {
            throw new NotImplementedException();
        }

        private void LuotSuInForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}