namespace QLHD.UI.Views.Work
{
    partial class WorksEditFormView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.CostTypeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCostType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ProjectIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForProjectId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ProjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForProject = new DevExpress.XtraLayout.LayoutControlItem();
            this.ParentWorkIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForParentWorkId = new DevExpress.XtraLayout.LayoutControlItem();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjectId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentWorkIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParentWorkId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "ResetLayout", this.bbiResetLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.WorkViewModel), "Close", this.bbiClose)});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(QLHD.UI.ViewModels.WorkViewModel);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiSaveLayout,
            this.bbiResetLayout,
            this.bbiDelete,
            this.bbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(699, 141);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "SaveAndClose";
            this.bbiSaveAndClose.Id = 2;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "SaveAndNew";
            this.bbiSaveAndNew.Id = 3;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 4;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save Layout";
            this.bbiSaveLayout.Id = 5;
            this.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiResetLayout
            // 
            this.bbiResetLayout.Caption = "Reset Layout";
            this.bbiResetLayout.Id = 6;
            this.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiResetLayout.Name = "bbiResetLayout";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 7;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 8;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ProjectIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ProjectTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ParentWorkIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl1.DataSource = this.workBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 141);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(699, 276);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(699, 276);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataSource = typeof(QLHD.Model.Models.Work);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForName,
            this.ItemForCostType,
            this.ItemForProjectId,
            this.ItemForProject,
            this.ItemForParentWorkId,
            this.ItemForIsActive});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(679, 256);
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdTextEdit.Location = new System.Drawing.Point(89, 12);
            this.IdTextEdit.MenuManager = this.ribbonControl1;
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdTextEdit.Properties.Mask.EditMask = "N0";
            this.IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdTextEdit.Size = new System.Drawing.Size(598, 20);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 4;
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(679, 24);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextSize = new System.Drawing.Size(73, 13);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(89, 36);
            this.NameTextEdit.MenuManager = this.ribbonControl1;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NameTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NameTextEdit.Properties.Mask.EditMask = "N0";
            this.NameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NameTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NameTextEdit.Size = new System.Drawing.Size(598, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(679, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(73, 13);
            // 
            // CostTypeTextEdit
            // 
            this.CostTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workBindingSource, "CostType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CostTypeTextEdit.Location = new System.Drawing.Point(89, 60);
            this.CostTypeTextEdit.MenuManager = this.ribbonControl1;
            this.CostTypeTextEdit.Name = "CostTypeTextEdit";
            this.CostTypeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CostTypeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CostTypeTextEdit.Properties.Mask.EditMask = "N0";
            this.CostTypeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CostTypeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CostTypeTextEdit.Size = new System.Drawing.Size(598, 20);
            this.CostTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.CostTypeTextEdit.TabIndex = 6;
            // 
            // ItemForCostType
            // 
            this.ItemForCostType.Control = this.CostTypeTextEdit;
            this.ItemForCostType.Location = new System.Drawing.Point(0, 48);
            this.ItemForCostType.Name = "ItemForCostType";
            this.ItemForCostType.Size = new System.Drawing.Size(679, 24);
            this.ItemForCostType.Text = "Cost Type";
            this.ItemForCostType.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ProjectIdTextEdit
            // 
            this.ProjectIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workBindingSource, "ProjectId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProjectIdTextEdit.Location = new System.Drawing.Point(89, 84);
            this.ProjectIdTextEdit.MenuManager = this.ribbonControl1;
            this.ProjectIdTextEdit.Name = "ProjectIdTextEdit";
            this.ProjectIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ProjectIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ProjectIdTextEdit.Properties.Mask.EditMask = "N0";
            this.ProjectIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ProjectIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ProjectIdTextEdit.Size = new System.Drawing.Size(598, 20);
            this.ProjectIdTextEdit.StyleController = this.dataLayoutControl1;
            this.ProjectIdTextEdit.TabIndex = 7;
            // 
            // ItemForProjectId
            // 
            this.ItemForProjectId.Control = this.ProjectIdTextEdit;
            this.ItemForProjectId.Location = new System.Drawing.Point(0, 72);
            this.ItemForProjectId.Name = "ItemForProjectId";
            this.ItemForProjectId.Size = new System.Drawing.Size(679, 24);
            this.ItemForProjectId.Text = "Project Id";
            this.ItemForProjectId.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ProjectTextEdit
            // 
            this.ProjectTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workBindingSource, "Project", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProjectTextEdit.Location = new System.Drawing.Point(89, 108);
            this.ProjectTextEdit.MenuManager = this.ribbonControl1;
            this.ProjectTextEdit.Name = "ProjectTextEdit";
            this.ProjectTextEdit.Size = new System.Drawing.Size(598, 20);
            this.ProjectTextEdit.StyleController = this.dataLayoutControl1;
            this.ProjectTextEdit.TabIndex = 8;
            // 
            // ItemForProject
            // 
            this.ItemForProject.Control = this.ProjectTextEdit;
            this.ItemForProject.Location = new System.Drawing.Point(0, 96);
            this.ItemForProject.Name = "ItemForProject";
            this.ItemForProject.Size = new System.Drawing.Size(679, 24);
            this.ItemForProject.Text = "Project";
            this.ItemForProject.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ParentWorkIdTextEdit
            // 
            this.ParentWorkIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workBindingSource, "ParentWorkId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ParentWorkIdTextEdit.Location = new System.Drawing.Point(89, 132);
            this.ParentWorkIdTextEdit.MenuManager = this.ribbonControl1;
            this.ParentWorkIdTextEdit.Name = "ParentWorkIdTextEdit";
            this.ParentWorkIdTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ParentWorkIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ParentWorkIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ParentWorkIdTextEdit.Properties.Mask.EditMask = "N0";
            this.ParentWorkIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ParentWorkIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ParentWorkIdTextEdit.Size = new System.Drawing.Size(598, 20);
            this.ParentWorkIdTextEdit.StyleController = this.dataLayoutControl1;
            this.ParentWorkIdTextEdit.TabIndex = 9;
            // 
            // ItemForParentWorkId
            // 
            this.ItemForParentWorkId.Control = this.ParentWorkIdTextEdit;
            this.ItemForParentWorkId.Location = new System.Drawing.Point(0, 120);
            this.ItemForParentWorkId.Name = "ItemForParentWorkId";
            this.ItemForParentWorkId.Size = new System.Drawing.Size(679, 24);
            this.ItemForParentWorkId.Text = "Parent Work Id";
            this.ItemForParentWorkId.TextSize = new System.Drawing.Size(73, 13);
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workBindingSource, "IsActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(12, 156);
            this.IsActiveCheckEdit.MenuManager = this.ribbonControl1;
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "checkEdit1";
            this.IsActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(675, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsActiveCheckEdit.TabIndex = 10;
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.Location = new System.Drawing.Point(0, 144);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(679, 112);
            this.ItemForIsActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsActive.TextVisible = false;
            // 
            // WorksEditFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "WorksEditFormView";
            this.Size = new System.Drawing.Size(699, 417);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjectId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentWorkIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParentWorkId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private System.Windows.Forms.BindingSource workBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit CostTypeTextEdit;
        private DevExpress.XtraEditors.TextEdit ProjectIdTextEdit;
        private DevExpress.XtraEditors.TextEdit ProjectTextEdit;
        private DevExpress.XtraEditors.TextEdit ParentWorkIdTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProjectId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProject;
        private DevExpress.XtraLayout.LayoutControlItem ItemForParentWorkId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
    }
}
