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
            this.biContracts = new DevExpress.XtraBars.BarButtonItem();
            this.biContractors = new DevExpress.XtraBars.BarButtonItem();
            this.biProjects = new DevExpress.XtraBars.BarButtonItem();
            this.biPaymentPeriods = new DevExpress.XtraBars.BarButtonItem();
            this.biWorks = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
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
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biContracts,
            this.biContractors,
            this.biProjects,
            this.biPaymentPeriods,
            this.biWorks});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 141);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
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
    }
}