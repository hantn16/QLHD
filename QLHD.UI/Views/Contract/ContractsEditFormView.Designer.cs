namespace QLHD.UI.Views.Contract
{
    partial class ContractsEditFormView
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
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SigningDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ContentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsTerminatedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.TerminateDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ContractOriginValueTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.WorkIdTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContractorIdTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForIsTerminated = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSigningDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWorkId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContractorId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTerminateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContractOriginValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigningDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigningDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsTerminatedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminateDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminateDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractOriginValueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractorIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsTerminated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSigningDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTerminateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractOriginValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "ResetLayout", this.bbiResetLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.ContractViewModel), "Close", this.bbiClose)});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(QLHD.UI.ViewModels.ContractViewModel);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
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
            this.ribbonControl1.Size = new System.Drawing.Size(577, 141);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSaveAndNew);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SigningDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ContentTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsTerminatedCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.TerminateDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ContractOriginValueTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.WorkIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContractorIdTextEdit);
            this.dataLayoutControl1.DataSource = this.contractBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIsTerminated});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 141);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(577, 178);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(87, 12);
            this.NameTextEdit.MenuManager = this.ribbonControl1;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(461, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(QLHD.Model.Models.Contract);
            // 
            // SigningDateDateEdit
            // 
            this.SigningDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "SigningDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SigningDateDateEdit.EditValue = null;
            this.SigningDateDateEdit.Location = new System.Drawing.Point(87, 36);
            this.SigningDateDateEdit.MenuManager = this.ribbonControl1;
            this.SigningDateDateEdit.Name = "SigningDateDateEdit";
            this.SigningDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SigningDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SigningDateDateEdit.Size = new System.Drawing.Size(461, 20);
            this.SigningDateDateEdit.StyleController = this.dataLayoutControl1;
            this.SigningDateDateEdit.TabIndex = 5;
            // 
            // ContentTextEdit
            // 
            this.ContentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "Content", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ContentTextEdit.Location = new System.Drawing.Point(87, 84);
            this.ContentTextEdit.MenuManager = this.ribbonControl1;
            this.ContentTextEdit.Name = "ContentTextEdit";
            this.ContentTextEdit.Size = new System.Drawing.Size(461, 20);
            this.ContentTextEdit.StyleController = this.dataLayoutControl1;
            this.ContentTextEdit.TabIndex = 7;
            // 
            // IsTerminatedCheckEdit
            // 
            this.IsTerminatedCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "IsTerminated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsTerminatedCheckEdit.Location = new System.Drawing.Point(12, 132);
            this.IsTerminatedCheckEdit.MenuManager = this.ribbonControl1;
            this.IsTerminatedCheckEdit.Name = "IsTerminatedCheckEdit";
            this.IsTerminatedCheckEdit.Properties.Caption = "checkEdit1";
            this.IsTerminatedCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsTerminatedCheckEdit.Properties.ReadOnly = true;
            this.IsTerminatedCheckEdit.Size = new System.Drawing.Size(536, 19);
            this.IsTerminatedCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsTerminatedCheckEdit.TabIndex = 9;
            // 
            // TerminateDateDateEdit
            // 
            this.TerminateDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "TerminateDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TerminateDateDateEdit.EditValue = null;
            this.TerminateDateDateEdit.Location = new System.Drawing.Point(87, 132);
            this.TerminateDateDateEdit.MenuManager = this.ribbonControl1;
            this.TerminateDateDateEdit.Name = "TerminateDateDateEdit";
            this.TerminateDateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TerminateDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TerminateDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TerminateDateDateEdit.Size = new System.Drawing.Size(461, 20);
            this.TerminateDateDateEdit.StyleController = this.dataLayoutControl1;
            this.TerminateDateDateEdit.TabIndex = 10;
            // 
            // ContractOriginValueTextEdit
            // 
            this.ContractOriginValueTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "ContractOriginValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ContractOriginValueTextEdit.Location = new System.Drawing.Point(87, 156);
            this.ContractOriginValueTextEdit.MenuManager = this.ribbonControl1;
            this.ContractOriginValueTextEdit.Name = "ContractOriginValueTextEdit";
            this.ContractOriginValueTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ContractOriginValueTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ContractOriginValueTextEdit.Properties.Mask.EditMask = "c";
            this.ContractOriginValueTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ContractOriginValueTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ContractOriginValueTextEdit.Size = new System.Drawing.Size(461, 20);
            this.ContractOriginValueTextEdit.StyleController = this.dataLayoutControl1;
            this.ContractOriginValueTextEdit.TabIndex = 11;
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "IsActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsActiveCheckEdit.EditValue = true;
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(12, 180);
            this.IsActiveCheckEdit.MenuManager = this.ribbonControl1;
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "Kích hoạt";
            this.IsActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(536, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsActiveCheckEdit.TabIndex = 12;
            // 
            // WorkIdTextEdit
            // 
            this.WorkIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "WorkId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.WorkIdTextEdit.Location = new System.Drawing.Point(87, 60);
            this.WorkIdTextEdit.MenuManager = this.ribbonControl1;
            this.WorkIdTextEdit.Name = "WorkIdTextEdit";
            this.WorkIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.WorkIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.WorkIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkIdTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên Hạng Mục", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CostType", "Loại Chi Phí", 64, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Project", "Dự Án", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ParentWork", "Hạng Mục Cha", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsActive", "Tình trạng", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.WorkIdTextEdit.Properties.DataSource = this.workBindingSource;
            this.WorkIdTextEdit.Properties.DisplayMember = "Name";
            this.WorkIdTextEdit.Properties.NullText = "";
            this.WorkIdTextEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.WorkIdTextEdit.Properties.ValueMember = "Id";
            this.WorkIdTextEdit.Size = new System.Drawing.Size(461, 20);
            this.WorkIdTextEdit.StyleController = this.dataLayoutControl1;
            this.WorkIdTextEdit.TabIndex = 6;
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataSource = typeof(QLHD.Model.Models.Work);
            // 
            // ContractorIdTextEdit
            // 
            this.ContractorIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "ContractorId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ContractorIdTextEdit.Location = new System.Drawing.Point(87, 108);
            this.ContractorIdTextEdit.MenuManager = this.ribbonControl1;
            this.ContractorIdTextEdit.Name = "ContractorIdTextEdit";
            this.ContractorIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ContractorIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ContractorIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ContractorIdTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Mã Nhà Thầu", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên Nhà Thầu", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaxCode", "Mã Số Thuế", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Địa Chỉ", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Representative", "Người Đại Diện", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankAccountNo", "TK Ngân Hàng Số", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "Tại Ngân Hàng", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PhoneNumber", "SĐT", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsActive", "Tình trạng", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ContractorIdTextEdit.Properties.DataSource = this.contractorBindingSource;
            this.ContractorIdTextEdit.Properties.DisplayMember = "Name";
            this.ContractorIdTextEdit.Properties.NullText = "";
            this.ContractorIdTextEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.ContractorIdTextEdit.Properties.ValueMember = "Id";
            this.ContractorIdTextEdit.Size = new System.Drawing.Size(461, 20);
            this.ContractorIdTextEdit.StyleController = this.dataLayoutControl1;
            this.ContractorIdTextEdit.TabIndex = 8;
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataSource = typeof(QLHD.Model.Models.Contractor);
            // 
            // ItemForIsTerminated
            // 
            this.ItemForIsTerminated.Control = this.IsTerminatedCheckEdit;
            this.ItemForIsTerminated.Location = new System.Drawing.Point(0, 120);
            this.ItemForIsTerminated.Name = "ItemForIsTerminated";
            this.ItemForIsTerminated.Size = new System.Drawing.Size(540, 23);
            this.ItemForIsTerminated.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsTerminated.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(560, 211);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForSigningDate,
            this.ItemForWorkId,
            this.ItemForContent,
            this.ItemForContractorId,
            this.ItemForTerminateDate,
            this.ItemForContractOriginValue,
            this.ItemForIsActive});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(540, 191);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(540, 24);
            this.ItemForName.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForSigningDate
            // 
            this.ItemForSigningDate.Control = this.SigningDateDateEdit;
            this.ItemForSigningDate.Location = new System.Drawing.Point(0, 24);
            this.ItemForSigningDate.Name = "ItemForSigningDate";
            this.ItemForSigningDate.Size = new System.Drawing.Size(540, 24);
            this.ItemForSigningDate.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForWorkId
            // 
            this.ItemForWorkId.Control = this.WorkIdTextEdit;
            this.ItemForWorkId.Location = new System.Drawing.Point(0, 48);
            this.ItemForWorkId.Name = "ItemForWorkId";
            this.ItemForWorkId.Size = new System.Drawing.Size(540, 24);
            this.ItemForWorkId.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForContent
            // 
            this.ItemForContent.Control = this.ContentTextEdit;
            this.ItemForContent.Location = new System.Drawing.Point(0, 72);
            this.ItemForContent.Name = "ItemForContent";
            this.ItemForContent.Size = new System.Drawing.Size(540, 24);
            this.ItemForContent.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForContractorId
            // 
            this.ItemForContractorId.Control = this.ContractorIdTextEdit;
            this.ItemForContractorId.Location = new System.Drawing.Point(0, 96);
            this.ItemForContractorId.Name = "ItemForContractorId";
            this.ItemForContractorId.Size = new System.Drawing.Size(540, 24);
            this.ItemForContractorId.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForTerminateDate
            // 
            this.ItemForTerminateDate.Control = this.TerminateDateDateEdit;
            this.ItemForTerminateDate.Location = new System.Drawing.Point(0, 120);
            this.ItemForTerminateDate.Name = "ItemForTerminateDate";
            this.ItemForTerminateDate.Size = new System.Drawing.Size(540, 24);
            this.ItemForTerminateDate.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForContractOriginValue
            // 
            this.ItemForContractOriginValue.Control = this.ContractOriginValueTextEdit;
            this.ItemForContractOriginValue.Location = new System.Drawing.Point(0, 144);
            this.ItemForContractOriginValue.Name = "ItemForContractOriginValue";
            this.ItemForContractOriginValue.Size = new System.Drawing.Size(540, 24);
            this.ItemForContractOriginValue.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.Location = new System.Drawing.Point(0, 168);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(540, 23);
            this.ItemForIsActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsActive.TextVisible = false;
            // 
            // ContractsEditFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ContractsEditFormView";
            this.Size = new System.Drawing.Size(577, 319);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigningDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigningDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsTerminatedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminateDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminateDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractOriginValueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractorIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsTerminated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSigningDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTerminateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractOriginValue)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DevExpress.XtraEditors.DateEdit SigningDateDateEdit;
        private DevExpress.XtraEditors.TextEdit ContentTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsTerminatedCheckEdit;
        private DevExpress.XtraEditors.DateEdit TerminateDateDateEdit;
        private DevExpress.XtraEditors.TextEdit ContractOriginValueTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsTerminated;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSigningDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWorkId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContent;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContractorId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTerminateDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContractOriginValue;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
        private DevExpress.XtraEditors.LookUpEdit WorkIdTextEdit;
        private System.Windows.Forms.BindingSource workBindingSource;
        private DevExpress.XtraEditors.LookUpEdit ContractorIdTextEdit;
        private System.Windows.Forms.BindingSource contractorBindingSource;
    }
}
