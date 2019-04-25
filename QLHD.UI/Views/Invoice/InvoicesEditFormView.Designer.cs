namespace QLHD.UI.Views.Invoice
{
    partial class InvoicesEditFormView
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReleaseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PretaxValueSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.VatValueSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.PayValueSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.PaymentPeriodIdGridLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.paymentPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReleaseDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPretaxValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVatValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaymentPeriodId = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretaxValueSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatValueSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayValueSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentPeriodIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReleaseDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPretaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVatValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentPeriodId)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(715, 141);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
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
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "ResetLayout", this.bbiResetLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLHD.UI.ViewModels.InvoiceViewModel), "Close", this.bbiClose)});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(QLHD.UI.ViewModels.InvoiceViewModel);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ReleaseDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.PretaxValueSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.VatValueSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.PayValueSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.PaymentPeriodIdGridLookUpEdit);
            this.dataLayoutControl1.DataSource = this.invoiceBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 141);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(967, 223, 450, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(715, 361);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NumberTextEdit
            // 
            this.NumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "Number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumberTextEdit.Location = new System.Drawing.Point(84, 36);
            this.NumberTextEdit.MenuManager = this.ribbonControl1;
            this.NumberTextEdit.Name = "NumberTextEdit";
            this.NumberTextEdit.Size = new System.Drawing.Size(619, 20);
            this.NumberTextEdit.StyleController = this.dataLayoutControl1;
            this.NumberTextEdit.TabIndex = 4;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(QLHD.Model.Models.Invoice);
            // 
            // ReleaseDateDateEdit
            // 
            this.ReleaseDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "ReleaseDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReleaseDateDateEdit.EditValue = null;
            this.ReleaseDateDateEdit.Location = new System.Drawing.Point(84, 60);
            this.ReleaseDateDateEdit.MenuManager = this.ribbonControl1;
            this.ReleaseDateDateEdit.Name = "ReleaseDateDateEdit";
            this.ReleaseDateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ReleaseDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ReleaseDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ReleaseDateDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.ReleaseDateDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ReleaseDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ReleaseDateDateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.ReleaseDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ReleaseDateDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.ReleaseDateDateEdit.Size = new System.Drawing.Size(619, 20);
            this.ReleaseDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ReleaseDateDateEdit.TabIndex = 5;
            // 
            // PretaxValueSpinEdit
            // 
            this.PretaxValueSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "PretaxValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PretaxValueSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PretaxValueSpinEdit.Location = new System.Drawing.Point(84, 84);
            this.PretaxValueSpinEdit.MenuManager = this.ribbonControl1;
            this.PretaxValueSpinEdit.Name = "PretaxValueSpinEdit";
            this.PretaxValueSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PretaxValueSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PretaxValueSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PretaxValueSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.PretaxValueSpinEdit.Properties.Mask.EditMask = "n0";
            this.PretaxValueSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PretaxValueSpinEdit.Size = new System.Drawing.Size(619, 20);
            this.PretaxValueSpinEdit.StyleController = this.dataLayoutControl1;
            this.PretaxValueSpinEdit.TabIndex = 6;
            // 
            // VatValueSpinEdit
            // 
            this.VatValueSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "VatValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.VatValueSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.VatValueSpinEdit.Location = new System.Drawing.Point(84, 108);
            this.VatValueSpinEdit.MenuManager = this.ribbonControl1;
            this.VatValueSpinEdit.Name = "VatValueSpinEdit";
            this.VatValueSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.VatValueSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.VatValueSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VatValueSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.VatValueSpinEdit.Properties.Mask.EditMask = "n0";
            this.VatValueSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.VatValueSpinEdit.Size = new System.Drawing.Size(619, 20);
            this.VatValueSpinEdit.StyleController = this.dataLayoutControl1;
            this.VatValueSpinEdit.TabIndex = 7;
            // 
            // PayValueSpinEdit
            // 
            this.PayValueSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "PayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PayValueSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PayValueSpinEdit.Location = new System.Drawing.Point(84, 132);
            this.PayValueSpinEdit.MenuManager = this.ribbonControl1;
            this.PayValueSpinEdit.Name = "PayValueSpinEdit";
            this.PayValueSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PayValueSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PayValueSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayValueSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.PayValueSpinEdit.Properties.Mask.EditMask = "n0";
            this.PayValueSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PayValueSpinEdit.Properties.ReadOnly = true;
            this.PayValueSpinEdit.Size = new System.Drawing.Size(619, 20);
            this.PayValueSpinEdit.StyleController = this.dataLayoutControl1;
            this.PayValueSpinEdit.TabIndex = 8;
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "IsActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsActiveCheckEdit.EditValue = true;
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(12, 156);
            this.IsActiveCheckEdit.MenuManager = this.ribbonControl1;
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "Kích hoạt";
            this.IsActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(691, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsActiveCheckEdit.TabIndex = 9;
            // 
            // PaymentPeriodIdGridLookUpEdit
            // 
            this.PaymentPeriodIdGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "PaymentPeriodId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PaymentPeriodIdGridLookUpEdit.Location = new System.Drawing.Point(84, 12);
            this.PaymentPeriodIdGridLookUpEdit.MenuManager = this.ribbonControl1;
            this.PaymentPeriodIdGridLookUpEdit.Name = "PaymentPeriodIdGridLookUpEdit";
            this.PaymentPeriodIdGridLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PaymentPeriodIdGridLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PaymentPeriodIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PaymentPeriodIdGridLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên Lần TT", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Mô Tả", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Contract", "Hợp Đồng", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order", "Thứ Tự", 45, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Kiểu TT", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueRequested", "Số Tiền Đề Nghị", 86, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RequestedDate", "Ngày Đề Nghị", 76, DevExpress.Utils.FormatType.DateTime, "dd/MM/yy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValuePaid", "Số Tiền Thanh Toán", 105, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaidDate", "Ngày Thanh Toán", 95, DevExpress.Utils.FormatType.DateTime, "dd/MM/yy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueAccepted", "Giá Trị NTHT", 69, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AcceptedDate", "Ngày nghiệm thu", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsActive", "Tình trạng", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.PaymentPeriodIdGridLookUpEdit.Properties.DataSource = this.paymentPeriodBindingSource;
            this.PaymentPeriodIdGridLookUpEdit.Properties.DisplayMember = "Name";
            this.PaymentPeriodIdGridLookUpEdit.Properties.NullText = "";
            this.PaymentPeriodIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.PaymentPeriodIdGridLookUpEdit.Properties.ValueMember = "Id";
            this.PaymentPeriodIdGridLookUpEdit.Size = new System.Drawing.Size(619, 20);
            this.PaymentPeriodIdGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.PaymentPeriodIdGridLookUpEdit.TabIndex = 10;
            // 
            // paymentPeriodBindingSource
            // 
            this.paymentPeriodBindingSource.DataSource = typeof(QLHD.Model.Models.PaymentPeriod);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(715, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNumber,
            this.ItemForReleaseDate,
            this.ItemForPretaxValue,
            this.ItemForVatValue,
            this.ItemForPayValue,
            this.ItemForIsActive,
            this.ItemForPaymentPeriodId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(695, 341);
            // 
            // ItemForNumber
            // 
            this.ItemForNumber.Control = this.NumberTextEdit;
            this.ItemForNumber.Location = new System.Drawing.Point(0, 24);
            this.ItemForNumber.Name = "ItemForNumber";
            this.ItemForNumber.Size = new System.Drawing.Size(695, 24);
            this.ItemForNumber.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForReleaseDate
            // 
            this.ItemForReleaseDate.Control = this.ReleaseDateDateEdit;
            this.ItemForReleaseDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForReleaseDate.Name = "ItemForReleaseDate";
            this.ItemForReleaseDate.Size = new System.Drawing.Size(695, 24);
            this.ItemForReleaseDate.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForPretaxValue
            // 
            this.ItemForPretaxValue.Control = this.PretaxValueSpinEdit;
            this.ItemForPretaxValue.Location = new System.Drawing.Point(0, 72);
            this.ItemForPretaxValue.Name = "ItemForPretaxValue";
            this.ItemForPretaxValue.Size = new System.Drawing.Size(695, 24);
            this.ItemForPretaxValue.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForVatValue
            // 
            this.ItemForVatValue.Control = this.VatValueSpinEdit;
            this.ItemForVatValue.Location = new System.Drawing.Point(0, 96);
            this.ItemForVatValue.Name = "ItemForVatValue";
            this.ItemForVatValue.Size = new System.Drawing.Size(695, 24);
            this.ItemForVatValue.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForPayValue
            // 
            this.ItemForPayValue.Control = this.PayValueSpinEdit;
            this.ItemForPayValue.Location = new System.Drawing.Point(0, 120);
            this.ItemForPayValue.Name = "ItemForPayValue";
            this.ItemForPayValue.Size = new System.Drawing.Size(695, 24);
            this.ItemForPayValue.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.Location = new System.Drawing.Point(0, 144);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(695, 197);
            this.ItemForIsActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsActive.TextVisible = false;
            // 
            // ItemForPaymentPeriodId
            // 
            this.ItemForPaymentPeriodId.Control = this.PaymentPeriodIdGridLookUpEdit;
            this.ItemForPaymentPeriodId.Location = new System.Drawing.Point(0, 0);
            this.ItemForPaymentPeriodId.Name = "ItemForPaymentPeriodId";
            this.ItemForPaymentPeriodId.Size = new System.Drawing.Size(695, 24);
            this.ItemForPaymentPeriodId.Text = "Lần TT";
            this.ItemForPaymentPeriodId.TextSize = new System.Drawing.Size(69, 13);
            // 
            // InvoicesEditFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "InvoicesEditFormView";
            this.Size = new System.Drawing.Size(715, 502);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretaxValueSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatValueSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayValueSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentPeriodIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReleaseDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPretaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVatValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentPeriodId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NumberTextEdit;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DevExpress.XtraEditors.DateEdit ReleaseDateDateEdit;
        private DevExpress.XtraEditors.SpinEdit PretaxValueSpinEdit;
        private DevExpress.XtraEditors.SpinEdit VatValueSpinEdit;
        private DevExpress.XtraEditors.SpinEdit PayValueSpinEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReleaseDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPretaxValue;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVatValue;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayValue;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
        private System.Windows.Forms.BindingSource paymentPeriodBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaymentPeriodId;
        private DevExpress.XtraEditors.LookUpEdit PaymentPeriodIdGridLookUpEdit;
    }
}
