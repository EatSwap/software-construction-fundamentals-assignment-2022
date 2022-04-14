namespace OrderManageGUI;

partial class MainForm {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.placeHolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelTableContainer = new System.Windows.Forms.Panel();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageCreate = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelCreateCustomerName = new System.Windows.Forms.Label();
			this.textBoxCreateCustomerName = new System.Windows.Forms.TextBox();
			this.labelCreateCustomerAddress = new System.Windows.Forms.Label();
			this.textBoxCreateCustomerAddress = new System.Windows.Forms.TextBox();
			this.labelCreateOrderTime = new System.Windows.Forms.Label();
			this.dateTimePickerCreateOrderTime = new System.Windows.Forms.DateTimePicker();
			this.labelCreateOrderDetails = new System.Windows.Forms.Label();
			this.buttonCreateOrderDetails = new System.Windows.Forms.Button();
			this.buttonCreateOrder = new System.Windows.Forms.Button();
			this.tabPageModify = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.labelModifyCustomerName = new System.Windows.Forms.Label();
			this.textBoxModifyCustomerName = new System.Windows.Forms.TextBox();
			this.labelModifyCustomerAddress = new System.Windows.Forms.Label();
			this.textBoxModifyCustomerAddress = new System.Windows.Forms.TextBox();
			this.labelModifyOrderTime = new System.Windows.Forms.Label();
			this.dateTimePickerModifyOrderTime = new System.Windows.Forms.DateTimePicker();
			this.labelModifyOrderDetails = new System.Windows.Forms.Label();
			this.buttonModifyOrderDetails = new System.Windows.Forms.Button();
			this.buttonModifySave = new System.Windows.Forms.Button();
			this.buttonModifyDelete = new System.Windows.Forms.Button();
			this.tabPageQuery = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.labelQueryCustomerName = new System.Windows.Forms.Label();
			this.checkBoxCustomer = new System.Windows.Forms.CheckBox();
			this.labelQueryCustomerAddress = new System.Windows.Forms.Label();
			this.textBoxQueryCustomerName = new System.Windows.Forms.TextBox();
			this.textBoxQueryCustomerAddress = new System.Windows.Forms.TextBox();
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
			this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitPriceStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceOrderDetails = new System.Windows.Forms.BindingSource(this.components);
			this.checkBoxItem = new System.Windows.Forms.CheckBox();
			this.labelQueryItemName = new System.Windows.Forms.Label();
			this.textBoxQueryItemName = new System.Windows.Forms.TextBox();
			this.checkBoxOrderTime = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerQueryFrom = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerQueryTo = new System.Windows.Forms.DateTimePicker();
			this.checkBoxPrice = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxQueryPriceMin = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxQueryPriceMax = new System.Windows.Forms.TextBox();
			this.buttonQuery = new System.Windows.Forms.Button();
			this.menuStrip.SuspendLayout();
			this.panelTableContainer.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageCreate.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPageModify.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tabPageQuery.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Location = new System.Drawing.Point(0, 439);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(884, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip";
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeHolderToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(884, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip";
			// 
			// placeHolderToolStripMenuItem
			// 
			this.placeHolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
			this.placeHolderToolStripMenuItem.Name = "placeHolderToolStripMenuItem";
			this.placeHolderToolStripMenuItem.ShortcutKeyDisplayString = "F";
			this.placeHolderToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.placeHolderToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// panelTableContainer
			// 
			this.panelTableContainer.Controls.Add(this.tableLayoutPanelMain);
			this.panelTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTableContainer.Location = new System.Drawing.Point(0, 24);
			this.panelTableContainer.Name = "panelTableContainer";
			this.panelTableContainer.Size = new System.Drawing.Size(884, 415);
			this.panelTableContainer.TabIndex = 3;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 2;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.625F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.375F));
			this.tableLayoutPanelMain.Controls.Add(this.tabControl1, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.dataGridViewOrders, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.dataGridViewOrderDetails, 0, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 2;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(884, 415);
			this.tableLayoutPanelMain.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageCreate);
			this.tabControl1.Controls.Add(this.tabPageModify);
			this.tabControl1.Controls.Add(this.tabPageQuery);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(600, 3);
			this.tabControl1.Name = "tabControl1";
			this.tableLayoutPanelMain.SetRowSpan(this.tabControl1, 2);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(281, 409);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
			// 
			// tabPageCreate
			// 
			this.tabPageCreate.Controls.Add(this.tableLayoutPanel1);
			this.tabPageCreate.Location = new System.Drawing.Point(4, 24);
			this.tabPageCreate.Name = "tabPageCreate";
			this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCreate.Size = new System.Drawing.Size(273, 381);
			this.tabPageCreate.TabIndex = 0;
			this.tabPageCreate.Text = "Create";
			this.tabPageCreate.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Controls.Add(this.labelCreateCustomerName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCreateCustomerName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelCreateCustomerAddress, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCreateCustomerAddress, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelCreateOrderTime, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerCreateOrderTime, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelCreateOrderDetails, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonCreateOrderDetails, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonCreateOrder, 0, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 375);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// labelCreateCustomerName
			// 
			this.labelCreateCustomerName.AutoSize = true;
			this.labelCreateCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateCustomerName.Location = new System.Drawing.Point(3, 0);
			this.labelCreateCustomerName.Name = "labelCreateCustomerName";
			this.labelCreateCustomerName.Size = new System.Drawing.Size(74, 30);
			this.labelCreateCustomerName.TabIndex = 0;
			this.labelCreateCustomerName.Text = "Customer Name";
			this.labelCreateCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxCreateCustomerName
			// 
			this.textBoxCreateCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxCreateCustomerName.Location = new System.Drawing.Point(83, 3);
			this.textBoxCreateCustomerName.Name = "textBoxCreateCustomerName";
			this.textBoxCreateCustomerName.Size = new System.Drawing.Size(181, 23);
			this.textBoxCreateCustomerName.TabIndex = 1;
			// 
			// labelCreateCustomerAddress
			// 
			this.labelCreateCustomerAddress.AutoSize = true;
			this.labelCreateCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateCustomerAddress.Location = new System.Drawing.Point(3, 30);
			this.labelCreateCustomerAddress.Name = "labelCreateCustomerAddress";
			this.labelCreateCustomerAddress.Size = new System.Drawing.Size(74, 30);
			this.labelCreateCustomerAddress.TabIndex = 2;
			this.labelCreateCustomerAddress.Text = "Customer Address";
			this.labelCreateCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxCreateCustomerAddress
			// 
			this.textBoxCreateCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxCreateCustomerAddress.Location = new System.Drawing.Point(83, 33);
			this.textBoxCreateCustomerAddress.Name = "textBoxCreateCustomerAddress";
			this.textBoxCreateCustomerAddress.Size = new System.Drawing.Size(181, 23);
			this.textBoxCreateCustomerAddress.TabIndex = 3;
			// 
			// labelCreateOrderTime
			// 
			this.labelCreateOrderTime.AutoSize = true;
			this.labelCreateOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateOrderTime.Location = new System.Drawing.Point(3, 60);
			this.labelCreateOrderTime.Name = "labelCreateOrderTime";
			this.labelCreateOrderTime.Size = new System.Drawing.Size(74, 30);
			this.labelCreateOrderTime.TabIndex = 4;
			this.labelCreateOrderTime.Text = "Order Time";
			this.labelCreateOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimePickerCreateOrderTime
			// 
			this.dateTimePickerCreateOrderTime.CustomFormat = "dd/MMM/yyyy HH:mm:ss";
			this.dateTimePickerCreateOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerCreateOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerCreateOrderTime.Location = new System.Drawing.Point(83, 63);
			this.dateTimePickerCreateOrderTime.Name = "dateTimePickerCreateOrderTime";
			this.dateTimePickerCreateOrderTime.Size = new System.Drawing.Size(181, 23);
			this.dateTimePickerCreateOrderTime.TabIndex = 5;
			// 
			// labelCreateOrderDetails
			// 
			this.labelCreateOrderDetails.AutoSize = true;
			this.labelCreateOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateOrderDetails.Location = new System.Drawing.Point(3, 90);
			this.labelCreateOrderDetails.Name = "labelCreateOrderDetails";
			this.labelCreateOrderDetails.Size = new System.Drawing.Size(74, 30);
			this.labelCreateOrderDetails.TabIndex = 6;
			this.labelCreateOrderDetails.Text = "Order Details";
			this.labelCreateOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonCreateOrderDetails
			// 
			this.buttonCreateOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCreateOrderDetails.Location = new System.Drawing.Point(83, 93);
			this.buttonCreateOrderDetails.Name = "buttonCreateOrderDetails";
			this.buttonCreateOrderDetails.Size = new System.Drawing.Size(181, 24);
			this.buttonCreateOrderDetails.TabIndex = 7;
			this.buttonCreateOrderDetails.Text = "Click to Modify";
			this.buttonCreateOrderDetails.UseVisualStyleBackColor = true;
			this.buttonCreateOrderDetails.Click += new System.EventHandler(this.buttonCreateModifyDetails_Click);
			// 
			// buttonCreateOrder
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.buttonCreateOrder, 2);
			this.buttonCreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCreateOrder.Location = new System.Drawing.Point(3, 123);
			this.buttonCreateOrder.Name = "buttonCreateOrder";
			this.buttonCreateOrder.Size = new System.Drawing.Size(261, 24);
			this.buttonCreateOrder.TabIndex = 8;
			this.buttonCreateOrder.Text = "Create new";
			this.buttonCreateOrder.UseVisualStyleBackColor = true;
			this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
			// 
			// tabPageModify
			// 
			this.tabPageModify.Controls.Add(this.tableLayoutPanel2);
			this.tabPageModify.Location = new System.Drawing.Point(4, 24);
			this.tabPageModify.Name = "tabPageModify";
			this.tabPageModify.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageModify.Size = new System.Drawing.Size(258, 319);
			this.tabPageModify.TabIndex = 1;
			this.tabPageModify.Text = "Modify / Delete";
			this.tabPageModify.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel2.Controls.Add(this.labelModifyCustomerName, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxModifyCustomerName, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.labelModifyCustomerAddress, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBoxModifyCustomerAddress, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.labelModifyOrderTime, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.dateTimePickerModifyOrderTime, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.labelModifyOrderDetails, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.buttonModifyOrderDetails, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.buttonModifySave, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.buttonModifyDelete, 0, 5);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 7;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 313);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// labelModifyCustomerName
			// 
			this.labelModifyCustomerName.AutoSize = true;
			this.labelModifyCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifyCustomerName.Location = new System.Drawing.Point(3, 0);
			this.labelModifyCustomerName.Name = "labelModifyCustomerName";
			this.labelModifyCustomerName.Size = new System.Drawing.Size(69, 30);
			this.labelModifyCustomerName.TabIndex = 0;
			this.labelModifyCustomerName.Text = "Customer Name";
			this.labelModifyCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxModifyCustomerName
			// 
			this.textBoxModifyCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxModifyCustomerName.Location = new System.Drawing.Point(78, 3);
			this.textBoxModifyCustomerName.Name = "textBoxModifyCustomerName";
			this.textBoxModifyCustomerName.Size = new System.Drawing.Size(171, 23);
			this.textBoxModifyCustomerName.TabIndex = 1;
			// 
			// labelModifyCustomerAddress
			// 
			this.labelModifyCustomerAddress.AutoSize = true;
			this.labelModifyCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifyCustomerAddress.Location = new System.Drawing.Point(3, 30);
			this.labelModifyCustomerAddress.Name = "labelModifyCustomerAddress";
			this.labelModifyCustomerAddress.Size = new System.Drawing.Size(69, 30);
			this.labelModifyCustomerAddress.TabIndex = 2;
			this.labelModifyCustomerAddress.Text = "Customer Address";
			this.labelModifyCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxModisyCustomerAddress
			// 
			this.textBoxModifyCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxModifyCustomerAddress.Location = new System.Drawing.Point(78, 33);
			this.textBoxModifyCustomerAddress.Name = "textBoxModifyCustomerAddress";
			this.textBoxModifyCustomerAddress.Size = new System.Drawing.Size(171, 23);
			this.textBoxModifyCustomerAddress.TabIndex = 3;
			// 
			// labelModifyOrderTime
			// 
			this.labelModifyOrderTime.AutoSize = true;
			this.labelModifyOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifyOrderTime.Location = new System.Drawing.Point(3, 60);
			this.labelModifyOrderTime.Name = "labelModifyOrderTime";
			this.labelModifyOrderTime.Size = new System.Drawing.Size(69, 30);
			this.labelModifyOrderTime.TabIndex = 4;
			this.labelModifyOrderTime.Text = "Order Time";
			this.labelModifyOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimePickerModifyOrderTime
			// 
			this.dateTimePickerModifyOrderTime.CustomFormat = "dd/MMM/yyyy HH:mm:ss";
			this.dateTimePickerModifyOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerModifyOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerModifyOrderTime.Location = new System.Drawing.Point(78, 63);
			this.dateTimePickerModifyOrderTime.Name = "dateTimePickerModifyOrderTime";
			this.dateTimePickerModifyOrderTime.Size = new System.Drawing.Size(171, 23);
			this.dateTimePickerModifyOrderTime.TabIndex = 5;
			// 
			// labelModifyOrderDetails
			// 
			this.labelModifyOrderDetails.AutoSize = true;
			this.labelModifyOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifyOrderDetails.Location = new System.Drawing.Point(3, 90);
			this.labelModifyOrderDetails.Name = "labelModifyOrderDetails";
			this.labelModifyOrderDetails.Size = new System.Drawing.Size(69, 30);
			this.labelModifyOrderDetails.TabIndex = 6;
			this.labelModifyOrderDetails.Text = "Order Details";
			this.labelModifyOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonModifyOrderDetails
			// 
			this.buttonModifyOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonModifyOrderDetails.Location = new System.Drawing.Point(78, 93);
			this.buttonModifyOrderDetails.Name = "buttonModifyOrderDetails";
			this.buttonModifyOrderDetails.Size = new System.Drawing.Size(171, 24);
			this.buttonModifyOrderDetails.TabIndex = 7;
			this.buttonModifyOrderDetails.Text = "Click to Modify";
			this.buttonModifyOrderDetails.UseVisualStyleBackColor = true;
			this.buttonModifyOrderDetails.Click += new System.EventHandler(this.buttonModifyOrderDetails_Click);
			// 
			// buttonModifySave
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.buttonModifySave, 2);
			this.buttonModifySave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonModifySave.Location = new System.Drawing.Point(3, 123);
			this.buttonModifySave.Name = "buttonModifySave";
			this.buttonModifySave.Size = new System.Drawing.Size(246, 24);
			this.buttonModifySave.TabIndex = 8;
			this.buttonModifySave.Text = "Save";
			this.buttonModifySave.UseVisualStyleBackColor = true;
			this.buttonModifySave.Click += new System.EventHandler(this.buttonModifySave_Click);
			// 
			// buttonModifyDelete
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.buttonModifyDelete, 2);
			this.buttonModifyDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonModifyDelete.Location = new System.Drawing.Point(3, 153);
			this.buttonModifyDelete.Name = "buttonModifyDelete";
			this.buttonModifyDelete.Size = new System.Drawing.Size(246, 24);
			this.buttonModifyDelete.TabIndex = 9;
			this.buttonModifyDelete.Text = "Delete this";
			this.buttonModifyDelete.UseVisualStyleBackColor = true;
			this.buttonModifyDelete.Click += new System.EventHandler(this.buttonModifyDelete_Click);
			// 
			// tabPageQuery
			// 
			this.tabPageQuery.Controls.Add(this.tableLayoutPanel3);
			this.tabPageQuery.Location = new System.Drawing.Point(4, 24);
			this.tabPageQuery.Name = "tabPageQuery";
			this.tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageQuery.Size = new System.Drawing.Size(273, 381);
			this.tabPageQuery.TabIndex = 2;
			this.tabPageQuery.Text = "Query";
			this.tabPageQuery.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel3.Controls.Add(this.textBoxQueryPriceMax, 1, 10);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 10);
			this.tableLayoutPanel3.Controls.Add(this.textBoxQueryPriceMin, 1, 9);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 9);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxPrice, 0, 8);
			this.tableLayoutPanel3.Controls.Add(this.dateTimePickerQueryTo, 1, 7);
			this.tableLayoutPanel3.Controls.Add(this.dateTimePickerQueryFrom, 1, 6);
			this.tableLayoutPanel3.Controls.Add(this.labelQueryCustomerName, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxCustomer, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.labelQueryCustomerAddress, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.textBoxQueryCustomerName, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.textBoxQueryCustomerAddress, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxItem, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.labelQueryItemName, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.textBoxQueryItemName, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxOrderTime, 0, 5);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 6);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 7);
			this.tableLayoutPanel3.Controls.Add(this.buttonQuery, 0, 11);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 13;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(267, 375);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// labelQueryCustomerName
			// 
			this.labelQueryCustomerName.AutoSize = true;
			this.labelQueryCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelQueryCustomerName.Location = new System.Drawing.Point(3, 30);
			this.labelQueryCustomerName.Name = "labelQueryCustomerName";
			this.labelQueryCustomerName.Size = new System.Drawing.Size(74, 30);
			this.labelQueryCustomerName.TabIndex = 3;
			this.labelQueryCustomerName.Text = "Customer Name";
			this.labelQueryCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBoxCustomer
			// 
			this.checkBoxCustomer.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.checkBoxCustomer, 2);
			this.checkBoxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxCustomer.Location = new System.Drawing.Point(3, 3);
			this.checkBoxCustomer.Name = "checkBoxCustomer";
			this.checkBoxCustomer.Size = new System.Drawing.Size(261, 24);
			this.checkBoxCustomer.TabIndex = 0;
			this.checkBoxCustomer.Text = "Filter By Customer";
			this.checkBoxCustomer.UseVisualStyleBackColor = true;
			this.checkBoxCustomer.CheckedChanged += new System.EventHandler(this.checkBoxCustomer_CheckedChanged);
			// 
			// labelQueryCustomerAddress
			// 
			this.labelQueryCustomerAddress.AutoSize = true;
			this.labelQueryCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelQueryCustomerAddress.Location = new System.Drawing.Point(3, 60);
			this.labelQueryCustomerAddress.Name = "labelQueryCustomerAddress";
			this.labelQueryCustomerAddress.Size = new System.Drawing.Size(74, 30);
			this.labelQueryCustomerAddress.TabIndex = 4;
			this.labelQueryCustomerAddress.Text = "Customer Address";
			this.labelQueryCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxQueryCustomerName
			// 
			this.textBoxQueryCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxQueryCustomerName.Enabled = false;
			this.textBoxQueryCustomerName.Location = new System.Drawing.Point(83, 33);
			this.textBoxQueryCustomerName.Name = "textBoxQueryCustomerName";
			this.textBoxQueryCustomerName.Size = new System.Drawing.Size(181, 23);
			this.textBoxQueryCustomerName.TabIndex = 5;
			// 
			// textBoxQueryCustomerAddress
			// 
			this.textBoxQueryCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxQueryCustomerAddress.Enabled = false;
			this.textBoxQueryCustomerAddress.Location = new System.Drawing.Point(83, 63);
			this.textBoxQueryCustomerAddress.Name = "textBoxQueryCustomerAddress";
			this.textBoxQueryCustomerAddress.Size = new System.Drawing.Size(181, 23);
			this.textBoxQueryCustomerAddress.TabIndex = 6;
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.AllowUserToAddRows = false;
			this.dataGridViewOrders.AllowUserToDeleteRows = false;
			this.dataGridViewOrders.AutoGenerateColumns = false;
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.CustomerAddress,
            this.orderTimeDataGridViewTextBoxColumn,
            this.PriceStr});
			this.dataGridViewOrders.DataSource = this.bindingSourceOrders;
			this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewOrders.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewOrders.MultiSelect = false;
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.ReadOnly = true;
			this.dataGridViewOrders.RowTemplate.Height = 25;
			this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewOrders.Size = new System.Drawing.Size(591, 201);
			this.dataGridViewOrders.TabIndex = 1;
			this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.DataGridViewOrders_SelectionChanged);
			// 
			// orderIdDataGridViewTextBoxColumn
			// 
			this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
			this.orderIdDataGridViewTextBoxColumn.HeaderText = "ID";
			this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
			this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerDataGridViewTextBoxColumn
			// 
			this.customerDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerDataGridViewTextBoxColumn.HeaderText = "Customer Name";
			this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
			this.customerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// CustomerAddress
			// 
			this.CustomerAddress.DataPropertyName = "CustomerAddress";
			this.CustomerAddress.HeaderText = "Customer Address";
			this.CustomerAddress.Name = "CustomerAddress";
			this.CustomerAddress.ReadOnly = true;
			// 
			// orderTimeDataGridViewTextBoxColumn
			// 
			this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
			this.orderTimeDataGridViewTextBoxColumn.HeaderText = "Order Time";
			this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
			this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// PriceStr
			// 
			this.PriceStr.DataPropertyName = "PriceStr";
			this.PriceStr.HeaderText = "Price";
			this.PriceStr.Name = "PriceStr";
			this.PriceStr.ReadOnly = true;
			// 
			// bindingSourceOrders
			// 
			this.bindingSourceOrders.DataSource = typeof(OrderManageCLI.Order);
			// 
			// dataGridViewOrderDetails
			// 
			this.dataGridViewOrderDetails.AllowUserToAddRows = false;
			this.dataGridViewOrderDetails.AllowUserToDeleteRows = false;
			this.dataGridViewOrderDetails.AutoGenerateColumns = false;
			this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.UnitPriceStr,
            this.countDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
			this.dataGridViewOrderDetails.DataSource = this.bindingSourceOrderDetails;
			this.dataGridViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewOrderDetails.Location = new System.Drawing.Point(3, 210);
			this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
			this.dataGridViewOrderDetails.ReadOnly = true;
			this.dataGridViewOrderDetails.RowTemplate.Height = 25;
			this.dataGridViewOrderDetails.Size = new System.Drawing.Size(591, 202);
			this.dataGridViewOrderDetails.TabIndex = 2;
			// 
			// ItemName
			// 
			this.ItemName.DataPropertyName = "ItemName";
			this.ItemName.HeaderText = "Item Name";
			this.ItemName.Name = "ItemName";
			this.ItemName.ReadOnly = true;
			// 
			// UnitPriceStr
			// 
			this.UnitPriceStr.DataPropertyName = "UnitPriceStr";
			this.UnitPriceStr.HeaderText = "Unit Price";
			this.UnitPriceStr.Name = "UnitPriceStr";
			this.UnitPriceStr.ReadOnly = true;
			// 
			// countDataGridViewTextBoxColumn
			// 
			this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
			this.countDataGridViewTextBoxColumn.HeaderText = "Count";
			this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			this.countDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "PriceStr";
			this.dataGridViewTextBoxColumn1.HeaderText = "Total Price";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// bindingSourceOrderDetails
			// 
			this.bindingSourceOrderDetails.DataSource = typeof(OrderManageCLI.OrderDetails);
			// 
			// checkBoxItem
			// 
			this.checkBoxItem.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.checkBoxItem, 2);
			this.checkBoxItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxItem.Location = new System.Drawing.Point(3, 93);
			this.checkBoxItem.Name = "checkBoxItem";
			this.checkBoxItem.Size = new System.Drawing.Size(261, 24);
			this.checkBoxItem.TabIndex = 7;
			this.checkBoxItem.Text = "Filter By Item";
			this.checkBoxItem.UseVisualStyleBackColor = true;
			this.checkBoxItem.CheckedChanged += new System.EventHandler(this.checkBoxItem_CheckedChanged);
			// 
			// labelQueryItemName
			// 
			this.labelQueryItemName.AutoSize = true;
			this.labelQueryItemName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelQueryItemName.Location = new System.Drawing.Point(3, 120);
			this.labelQueryItemName.Name = "labelQueryItemName";
			this.labelQueryItemName.Size = new System.Drawing.Size(74, 30);
			this.labelQueryItemName.TabIndex = 8;
			this.labelQueryItemName.Text = "Item Name";
			this.labelQueryItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxQueryItemName
			// 
			this.textBoxQueryItemName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxQueryItemName.Enabled = false;
			this.textBoxQueryItemName.Location = new System.Drawing.Point(83, 123);
			this.textBoxQueryItemName.Name = "textBoxQueryItemName";
			this.textBoxQueryItemName.Size = new System.Drawing.Size(181, 23);
			this.textBoxQueryItemName.TabIndex = 9;
			// 
			// checkBoxOrderTime
			// 
			this.checkBoxOrderTime.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.checkBoxOrderTime, 2);
			this.checkBoxOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxOrderTime.Location = new System.Drawing.Point(3, 153);
			this.checkBoxOrderTime.Name = "checkBoxOrderTime";
			this.checkBoxOrderTime.Size = new System.Drawing.Size(261, 24);
			this.checkBoxOrderTime.TabIndex = 10;
			this.checkBoxOrderTime.Text = "Filter By Order Time Range";
			this.checkBoxOrderTime.UseVisualStyleBackColor = true;
			this.checkBoxOrderTime.CheckedChanged += new System.EventHandler(this.checkBoxOrderTime_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 30);
			this.label1.TabIndex = 11;
			this.label1.Text = "From";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 210);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 30);
			this.label2.TabIndex = 12;
			this.label2.Text = "To";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimePickerQueryFrom
			// 
			this.dateTimePickerQueryFrom.CustomFormat = "dd/MMM/yyyy HH:mm:ss";
			this.dateTimePickerQueryFrom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerQueryFrom.Enabled = false;
			this.dateTimePickerQueryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerQueryFrom.Location = new System.Drawing.Point(83, 183);
			this.dateTimePickerQueryFrom.Name = "dateTimePickerQueryFrom";
			this.dateTimePickerQueryFrom.Size = new System.Drawing.Size(181, 23);
			this.dateTimePickerQueryFrom.TabIndex = 13;
			// 
			// dateTimePickerQueryTo
			// 
			this.dateTimePickerQueryTo.CustomFormat = "dd/MMM/yyyy HH:mm:ss";
			this.dateTimePickerQueryTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerQueryTo.Enabled = false;
			this.dateTimePickerQueryTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerQueryTo.Location = new System.Drawing.Point(83, 213);
			this.dateTimePickerQueryTo.Name = "dateTimePickerQueryTo";
			this.dateTimePickerQueryTo.Size = new System.Drawing.Size(181, 23);
			this.dateTimePickerQueryTo.TabIndex = 14;
			// 
			// checkBoxPrice
			// 
			this.checkBoxPrice.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.checkBoxPrice, 2);
			this.checkBoxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxPrice.Location = new System.Drawing.Point(3, 243);
			this.checkBoxPrice.Name = "checkBoxPrice";
			this.checkBoxPrice.Size = new System.Drawing.Size(261, 24);
			this.checkBoxPrice.TabIndex = 15;
			this.checkBoxPrice.Text = "Filter By Total Price Range";
			this.checkBoxPrice.UseVisualStyleBackColor = true;
			this.checkBoxPrice.CheckedChanged += new System.EventHandler(this.checkBoxPrice_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 30);
			this.label3.TabIndex = 16;
			this.label3.Text = "Minimum";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxQueryPriceMin
			// 
			this.textBoxQueryPriceMin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxQueryPriceMin.Enabled = false;
			this.textBoxQueryPriceMin.Location = new System.Drawing.Point(83, 273);
			this.textBoxQueryPriceMin.Name = "textBoxQueryPriceMin";
			this.textBoxQueryPriceMin.Size = new System.Drawing.Size(181, 23);
			this.textBoxQueryPriceMin.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 300);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 30);
			this.label4.TabIndex = 18;
			this.label4.Text = "Maximum";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxQueryPriceMax
			// 
			this.textBoxQueryPriceMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxQueryPriceMax.Enabled = false;
			this.textBoxQueryPriceMax.Location = new System.Drawing.Point(83, 303);
			this.textBoxQueryPriceMax.Name = "textBoxQueryPriceMax";
			this.textBoxQueryPriceMax.Size = new System.Drawing.Size(181, 23);
			this.textBoxQueryPriceMax.TabIndex = 19;
			// 
			// buttonQuery
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.buttonQuery, 2);
			this.buttonQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonQuery.Location = new System.Drawing.Point(3, 333);
			this.buttonQuery.Name = "buttonQuery";
			this.buttonQuery.Size = new System.Drawing.Size(261, 24);
			this.buttonQuery.TabIndex = 20;
			this.buttonQuery.Text = "Query";
			this.buttonQuery.UseVisualStyleBackColor = true;
			this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.panelTableContainer);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panelTableContainer.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageCreate.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPageModify.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tabPageQuery.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private StatusStrip statusStrip;
	private MenuStrip menuStrip;
	private ToolStripMenuItem placeHolderToolStripMenuItem;
	private Panel panelTableContainer;
	private TableLayoutPanel tableLayoutPanelMain;
	private TabControl tabControl1;
	private TabPage tabPageCreate;
	private TabPage tabPageModify;
	private BindingSource bindingSourceOrders;
	private DataGridView dataGridViewOrders;
	private DataGridView dataGridViewOrderDetails;
	private BindingSource bindingSourceOrderDetails;
	private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
	private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
	private DataGridViewTextBoxColumn CustomerAddress;
	private DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
	private DataGridViewTextBoxColumn PriceStr;
	private DataGridViewTextBoxColumn ItemName;
	private DataGridViewTextBoxColumn UnitPriceStr;
	private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
	private TableLayoutPanel tableLayoutPanel1;
	private Label labelCreateCustomerName;
	private TextBox textBoxCreateCustomerName;
	private Label labelCreateCustomerAddress;
	private TextBox textBoxCreateCustomerAddress;
	private Label labelCreateOrderTime;
	private DateTimePicker dateTimePickerCreateOrderTime;
	private Label labelCreateOrderDetails;
	private Button buttonCreateOrderDetails;
	private Button buttonCreateOrder;
	private TableLayoutPanel tableLayoutPanel2;
	private Label labelModifyCustomerName;
	private TextBox textBoxModifyCustomerName;
	private Label labelModifyCustomerAddress;
	private TextBox textBoxModifyCustomerAddress;
	private Label labelModifyOrderTime;
	private DateTimePicker dateTimePickerModifyOrderTime;
	private Label labelModifyOrderDetails;
	private Button buttonModifyOrderDetails;
	private Button buttonModifySave;
	private Button buttonModifyDelete;
	private ToolStripMenuItem saveToolStripMenuItem;
	private ToolStripMenuItem openToolStripMenuItem;
	private TabPage tabPageQuery;
	private TableLayoutPanel tableLayoutPanel3;
	private CheckBox checkBoxCustomer;
	private Label labelQueryCustomerName;
	private Label labelQueryCustomerAddress;
	private TextBox textBoxQueryCustomerName;
	private TextBox textBoxQueryCustomerAddress;
	private CheckBox checkBoxItem;
	private Label labelQueryItemName;
	private TextBox textBoxQueryItemName;
	private CheckBox checkBoxOrderTime;
	private Label label1;
	private Label label2;
	private TextBox textBoxQueryPriceMax;
	private Label label4;
	private TextBox textBoxQueryPriceMin;
	private Label label3;
	private CheckBox checkBoxPrice;
	private DateTimePicker dateTimePickerQueryTo;
	private DateTimePicker dateTimePickerQueryFrom;
	private Button buttonQuery;
}
