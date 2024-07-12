using DevExpress.CodeParser;
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
using ToolTestData.Presenters;
using ToolTestData.View.NhapLieu.BacSi;
using ToolTestData.View.NhapLieu.KhuVuc;
using ToolTestData.View.NhapLieu.LuotSuIn;
using ToolTestData.View.NhapLieu.Phong;
using ToolTestData.View.CrawData;
using ToolTestData.View.NhapLieu.LoMau;
using ToolTestData.View.NhapLieu.TuiMau;
using ToolTestData.View.NganHangMau.DanhMucMau;
using ToolTestData.View.NganHangMau.LoaiChePham;
using ToolTestData.View.NganHangMau.NhomMauISBT;
using ToolTestData.View.NganHangMau.MaSanPhamTheoISBT;
using ToolTestData.View.NganHangMau.NhaCungCap;
using ToolTestData.View.NganHangMau.Kho;

namespace ToolTestData.View.Menu
{
    public partial class RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm()
        {
            InitializeComponent();
        }
        void openchild(Type childType, int typecheck)
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
            switch (typecheck)
            {
                case 0:
                    if (form is LuotSuInForm luotSuInForm)
                    {
                        // Initialize the context and presenter if the form is LuotSuInForm
                        ClsContext context = new ClsContext();
                        new LuotSuInPresenter(luotSuInForm, context);
                    }
                    break;
                case 1:
                    if (form is BacSiForm bacSiForm)
                    {
                        // Initialize the context and presenter if the form is LuotSuInForm
                        ClsContext context = new ClsContext();
                        new BacSiPresenter(bacSiForm, context);
                    }
                    break;
                case 2:
                    if (form is KhuVucForm khuVucForm)
                    {
                        // Initialize the context and presenter if the form is LuotSuInForm
                        ClsContext context = new ClsContext();
                        new KhuVucPresenter(khuVucForm, context);
                    }
                    break;
                case 3:
                    if (form is PhongForm PhongForms)
                    {
                        // Initialize the context and presenter if the form is LuotSuInForm
                        ClsContext context = new ClsContext();
                        new PhongPresenter(PhongForms, context);
                    }
                    break;
                case 4:
                    if (form is LoMauForm loMauForms)
                    {
                        ClsContext context = new ClsContext();
                        new LoMauPresenter(loMauForms, context);
                    }
                    break;
                case 5:
                    if (form is CrawDataForm CrawDataForms)
                    {
                        ClsContext context = new ClsContext();
                        new CrawDataPresenter(CrawDataForms, context);
                    }
                    break;
                case 6:
                    if (form is TuiMau TuiMau)
                    {
                        ClsContext context = new ClsContext();
                        new TuiMauPresenter(TuiMau, context);
                    }
                    break;
                case 7:
                    if (form is DanhMucMauForm danhMucMauForm)
                    {
                        ClsContext context = new ClsContext();
                        new DanhMucMauPresenter(danhMucMauForm, context);
                    }
                    break;
                case 8:
                    if (form is LoaiChePhamForm LoaiChePhamForm)
                    {
                        ClsContext context = new ClsContext();
                        new LoaiChePhamPresenter(LoaiChePhamForm, context);
                    }
                    break;
                case 9:
                    if (form is NhomMauISBTForm NhomMauISBTForm)
                    {
                        ClsContext context = new ClsContext();
                        new NhomMauISBTPresenter(NhomMauISBTForm, context);
                    }
                    break;
                case 10:
                    if (form is MaSanPhamTheoISBTForm MaSanPhamTheoISBTForm)
                    {
                        ClsContext context = new ClsContext();
                        new MaSanPhamTheoISBTPresenter(MaSanPhamTheoISBTForm, context);
                    }
                    break;
                case 11:
                    if (form is NhaCungCapForm NhaCungCapForm)
                    {
                        ClsContext context = new ClsContext();
                        new NhaCungCapPresenter(NhaCungCapForm, context);
                    }
                    break;
                case 12:
                    if (form is CLSNHMKhoForm CLSNHMKhoForm)
                    {
                        ClsContext context = new ClsContext();
                        new CLSNHMKhoPresenter(CLSNHMKhoForm, context);
                    }
                    break;
            }

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
            openchild(typeof(LuotSuInForm), 0);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(BacSiForm), 1);
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(KhuVucForm), 2);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(PhongForm), 3);
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(CrawDataForm), 5);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(LoMauForm), 4);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(TuiMau), 6);
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(DanhMucMauForm), 7);
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(LoaiChePhamForm), 8);
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(NhomMauISBTForm), 9);
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(MaSanPhamTheoISBTForm), 10);
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(NhaCungCapForm), 11);
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(typeof(CLSNHMKhoForm),12);
        }
    }
}