namespace QLHD.UI.Views
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.biContracts = new DevExpress.XtraBars.BarButtonItem();
            this.biContractors = new DevExpress.XtraBars.BarButtonItem();
            this.biProjects = new DevExpress.XtraBars.BarButtonItem();
            this.biPaymentPeriods = new DevExpress.XtraBars.BarButtonItem();
            this.biWorks = new DevExpress.XtraBars.BarButtonItem();
            this.biLogout = new DevExpress.XtraBars.BarButtonItem();
            this.biSettings = new DevExpress.XtraBars.BarButtonItem();
            this.biContractApendixes = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.bbContracts = new DevExpress.XtraBars.BarButtonItem();
            this.bbContractors = new DevExpress.XtraBars.BarButtonItem();
            this.bbProjects = new DevExpress.XtraBars.BarButtonItem();
            this.bbWorks = new DevExpress.XtraBars.BarButtonItem();
            this.bbPaymentPeriods = new DevExpress.XtraBars.BarButtonItem();
            this.bbContractApendixes = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterDocumentManagerService(null, false, this.tabbedView1)});
            this.mvvmContext1.ViewModelType = typeof(QLHD.UI.ViewModels.QLHDDbContextViewModel);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biContracts,
            this.biContractors,
            this.biProjects,
            this.biPaymentPeriods,
            this.biWorks,
            this.biLogout,
            this.biSettings,
            this.biContractApendixes,
            this.barSubItem1,
            this.barSubItem2,
            this.bbContracts,
            this.bbContractors,
            this.bbProjects,
            this.bbWorks,
            this.bbPaymentPeriods,
            this.bbContractApendixes});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barSubItem1);
            this.ribbonControl1.Size = new System.Drawing.Size(800, 141);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(70, 211);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl1.TabIndex = 2;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(188, 0);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(292, 150);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            // 
            // biContracts
            // 
            this.biContracts.Caption = "Contracts";
            this.biContracts.Id = 7;
            this.biContracts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biContracts.ImageOptions.Image")));
            this.biContracts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biContracts.ImageOptions.LargeImage")));
            this.biContracts.Name = "biContracts";
            this.biContracts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biContractors
            // 
            this.biContractors.Caption = "Contractors";
            this.biContractors.Id = 8;
            this.biContractors.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biContractors.ImageOptions.Image")));
            this.biContractors.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biContractors.ImageOptions.LargeImage")));
            this.biContractors.Name = "biContractors";
            this.biContractors.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biProjects
            // 
            this.biProjects.Caption = "Projects";
            this.biProjects.Id = 9;
            this.biProjects.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biProjects.ImageOptions.Image")));
            this.biProjects.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biProjects.ImageOptions.LargeImage")));
            this.biProjects.Name = "biProjects";
            this.biProjects.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biPaymentPeriods
            // 
            this.biPaymentPeriods.Caption = "PaymentPeriods";
            this.biPaymentPeriods.Id = 10;
            this.biPaymentPeriods.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biPaymentPeriods.ImageOptions.Image")));
            this.biPaymentPeriods.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biPaymentPeriods.ImageOptions.LargeImage")));
            this.biPaymentPeriods.Name = "biPaymentPeriods";
            this.biPaymentPeriods.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biWorks
            // 
            this.biWorks.Caption = "Works";
            this.biWorks.Id = 11;
            this.biWorks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biWorks.ImageOptions.Image")));
            this.biWorks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biWorks.ImageOptions.LargeImage")));
            this.biWorks.Name = "biWorks";
            this.biWorks.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biLogout
            // 
            this.biLogout.Caption = "Logout";
            this.biLogout.Id = 12;
            this.biLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biLogout.ImageOptions.Image")));
            this.biLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biLogout.ImageOptions.LargeImage")));
            this.biLogout.Name = "biLogout";
            this.biLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biSettings
            // 
            this.biSettings.Caption = "Settings";
            this.biSettings.Id = 13;
            this.biSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biSettings.ImageOptions.Image")));
            this.biSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biSettings.ImageOptions.LargeImage")));
            this.biSettings.Name = "biSettings";
            this.biSettings.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biContractApendixes
            // 
            this.biContractApendixes.Caption = "ContractApendix";
            this.biContractApendixes.Id = 14;
            this.biContractApendixes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biContractApendixes.ImageOptions.Image")));
            this.biContractApendixes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biContractApendixes.ImageOptions.LargeImage")));
            this.biContractApendixes.Name = "biContractApendixes";
            this.biContractApendixes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 15;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Danh Mục";
            this.barSubItem2.Id = 16;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbContracts),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbContractors),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbProjects, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbWorks),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbPaymentPeriods),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbContractApendixes)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // bbContracts
            // 
            this.bbContracts.Caption = "Contracts";
            this.bbContracts.Id = 17;
            this.bbContracts.Name = "bbContracts";
            // 
            // bbContractors
            // 
            this.bbContractors.Caption = "Contractors";
            this.bbContractors.Id = 18;
            this.bbContractors.Name = "bbContractors";
            // 
            // bbProjects
            // 
            this.bbProjects.Caption = "Projects";
            this.bbProjects.Id = 19;
            this.bbProjects.Name = "bbProjects";
            this.bbProjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bbWorks
            // 
            this.bbWorks.Caption = "Works";
            this.bbWorks.Id = 20;
            this.bbWorks.Name = "bbWorks";
            // 
            // bbPaymentPeriods
            // 
            this.bbPaymentPeriods.Caption = "PaymentPeriods";
            this.bbPaymentPeriods.Id = 21;
            this.bbPaymentPeriods.Name = "bbPaymentPeriods";
            // 
            // bbContractApendixes
            // 
            this.bbContractApendixes.Caption = "ContractApendixes";
            this.bbContractApendixes.Id = 22;
            this.bbContractApendixes.Name = "bbContractApendixes";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ListEntities";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.biContracts);
            this.ribbonPageGroup1.ItemLinks.Add(this.biContractors);
            this.ribbonPageGroup1.ItemLinks.Add(this.biProjects);
            this.ribbonPageGroup1.ItemLinks.Add(this.biPaymentPeriods);
            this.ribbonPageGroup1.ItemLinks.Add(this.biWorks);
            this.ribbonPageGroup1.ItemLinks.Add(this.biContractApendixes);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.biLogout);
            this.ribbonPageGroup2.ItemLinks.Add(this.biSettings);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hệ thống";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem biContracts;
        private DevExpress.XtraBars.BarButtonItem biContractors;
        private DevExpress.XtraBars.BarButtonItem biProjects;
        private DevExpress.XtraBars.BarButtonItem biPaymentPeriods;
        private DevExpress.XtraBars.BarButtonItem biWorks;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem biLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem biSettings;
        private DevExpress.XtraBars.BarButtonItem biContractApendixes;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem bbContracts;
        private DevExpress.XtraBars.BarButtonItem bbContractors;
        private DevExpress.XtraBars.BarButtonItem bbProjects;
        private DevExpress.XtraBars.BarButtonItem bbWorks;
        private DevExpress.XtraBars.BarButtonItem bbPaymentPeriods;
        private DevExpress.XtraBars.BarButtonItem bbContractApendixes;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
    }
}