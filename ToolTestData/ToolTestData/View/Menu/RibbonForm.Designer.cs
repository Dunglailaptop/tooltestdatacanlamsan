namespace ToolTestData.View.Menu
{
    partial class RibbonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, barButtonItem7, barButtonItem8, barButtonItem9, barButtonItem10, barButtonItem11, barButtonItem12, barButtonItem13, barButtonItem14, barButtonItem15, barButtonItem16, barButtonItem17 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 18;
            ribbon.Name = "ribbon";
            ribbon.PageHeaderItemLinks.Add(barButtonItem14);
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage3, ribbonPage2, ribbonPage4 });
            ribbon.Size = new Size(1032, 144);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Click += ribbon_Click;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Lượt Sử In";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Khoa";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.Image = (Image)resources.GetObject("barButtonItem2.ImageOptions.Image");
            barButtonItem2.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem2.ImageOptions.LargeImage");
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Phòng";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.Image = (Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Chi Nhánh";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.Image = (Image)resources.GetObject("barButtonItem4.ImageOptions.Image");
            barButtonItem4.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem4.ImageOptions.LargeImage");
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Bác Sĩ";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.Image = (Image)resources.GetObject("barButtonItem5.ImageOptions.Image");
            barButtonItem5.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Lô Máu";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem6.ImageOptions.SvgImage");
            barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "Túi Máu";
            barButtonItem7.Id = 7;
            barButtonItem7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem7.ImageOptions.SvgImage");
            barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "Đăng Ký Máu";
            barButtonItem8.Id = 8;
            barButtonItem8.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem8.ImageOptions.SvgImage");
            barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            barButtonItem9.ActAsDropDown = true;
            barButtonItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            barButtonItem9.Caption = "Cấu Hình";
            barButtonItem9.DropDownControl = popupMenu1;
            barButtonItem9.Id = 9;
            barButtonItem9.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem9.ImageOptions.SvgImage");
            barButtonItem9.Name = "barButtonItem9";
            // 
            // popupMenu1
            // 
            popupMenu1.Name = "popupMenu1";
            popupMenu1.Ribbon = ribbon;
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "XQuang";
            barButtonItem10.Id = 10;
            barButtonItem10.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem10.ImageOptions.SvgImage");
            barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            barButtonItem11.Caption = "CT";
            barButtonItem11.Id = 11;
            barButtonItem11.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem11.ImageOptions.SvgImage");
            barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            barButtonItem12.Caption = "MRI";
            barButtonItem12.Id = 12;
            barButtonItem12.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem12.ImageOptions.SvgImage");
            barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            barButtonItem13.Caption = "Báo Cáo";
            barButtonItem13.Id = 13;
            barButtonItem13.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem13.ImageOptions.SvgImage");
            barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            barButtonItem14.Caption = "Craw Data";
            barButtonItem14.Id = 14;
            barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            barButtonItem15.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barButtonItem15.Caption = "CRAWDATA";
            barButtonItem15.Id = 15;
            barButtonItem15.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem15.ImageOptions.SvgImage");
            barButtonItem15.Name = "barButtonItem15";
            barButtonItem15.ItemClick += barButtonItem15_ItemClick;
            // 
            // barButtonItem16
            // 
            barButtonItem16.Caption = "Phiếu Yêu Cầu Lĩnh";
            barButtonItem16.Id = 16;
            barButtonItem16.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem16.ImageOptions.SvgImage");
            barButtonItem16.Name = "barButtonItem16";
            // 
            // barButtonItem17
            // 
            barButtonItem17.Caption = "Khu Vực";
            barButtonItem17.Id = 17;
            barButtonItem17.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem17.ImageOptions.SvgImage");
            barButtonItem17.Name = "barButtonItem17";
            barButtonItem17.ItemClick += barButtonItem17_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Nhập Liệu";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem17);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Menu Nhập Liệu";
            // 
            // ribbonPage3
            // 
            ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            ribbonPage3.Name = "ribbonPage3";
            ribbonPage3.Text = "Ngân Hàng Máu";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem7);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem8);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem9);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem16);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Menu Ngân Hàng Máu";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Chuẩn Đoán Hình Ảnh";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem10);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem11);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem12);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Menu Chuẩn Đoán Hình Ành";
            // 
            // ribbonPage4
            // 
            ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4 });
            ribbonPage4.Name = "ribbonPage4";
            ribbonPage4.Text = "Báo Cáo";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barButtonItem13);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Menu Báo Cáo";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.ItemLinks.Add(barButtonItem15);
            ribbonStatusBar.Location = new Point(0, 507);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1032, 32);
            // 
            // documentManager1
            // 
            documentManager1.MdiParent = this;
            documentManager1.MenuManager = ribbon;
            documentManager1.View = tabbedView1;
            documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1 });
            // 
            // defaultLookAndFeel1
            // 
            defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // RibbonForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 539);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "RibbonForm";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "RibbonForm";
            WindowState = FormWindowState.Maximized;
            Load += RibbonForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
    }
}