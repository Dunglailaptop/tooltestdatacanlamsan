using DevExpress.XtraBars;
using DevExpress.XtraRichEdit.Commands.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTestData.Models;
using ToolTestData.View.NhapLieu.LuotSuIn;

namespace ToolTestData.View.Menu
{
    public partial class RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm()
        {
            InitializeComponent();
        }
        void openchild(Type childType)
        {
            // Check if the childType is a Form
            if (!typeof(Form).IsAssignableFrom(childType))
            {
                throw new ArgumentException("childType must be a type derived from System.Windows.Forms.Form", nameof(childType));
            }

            // Activate the form if it's already open
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == childType)
                {
                    frm.Activate();
                    return;
                }
            }

            // Create an instance of the form and show it
            Form form = (Form)Activator.CreateInstance(childType);
            form.MdiParent = this;
            form.Show();
        }



        private void RibbonForm_Load(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(LuotSuInForm));
        }
    }
}