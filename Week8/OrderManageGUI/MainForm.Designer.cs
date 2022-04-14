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
			this.goodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.textBoxModisyCustomerAddress = new System.Windows.Forms.TextBox();
			this.labelModifyOrderTime = new System.Windows.Forms.Label();
			this.dateTimePickerModifyOrderTime = new System.Windows.Forms.DateTimePicker();
			this.labelModifyOrderDetails = new System.Windows.Forms.Label();
			this.buttonModifyOrderDetails = new System.Windows.Forms.Button();
			this.buttonModifySave = new System.Windows.Forms.Button();
			this.buttonModifyDelete = new System.Windows.Forms.Button();
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
			this.menuStrip.SuspendLayout();
			this.panelTableContainer.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageCreate.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPageModify.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Location = new System.Drawing.Point(0, 377);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(839, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip";
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.placeHolderToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(839, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip";
			// 
			// placeHolderToolStripMenuItem
			// 
			this.placeHolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.goodToolStripMenuItem});
			this.placeHolderToolStripMenuItem.Name = "placeHolderToolStripMenuItem";
			this.placeHolderToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.placeHolderToolStripMenuItem.Text = "PlaceHolder";
			// 
			// goodToolStripMenuItem
			// 
			this.goodToolStripMenuItem.Name = "goodToolStripMenuItem";
			this.goodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.goodToolStripMenuItem.Text = "Good";
			// 
			// panelTableContainer
			// 
			this.panelTableContainer.Controls.Add(this.tableLayoutPanelMain);
			this.panelTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTableContainer.Location = new System.Drawing.Point(0, 24);
			this.panelTableContainer.Name = "panelTableContainer";
			this.panelTableContainer.Size = new System.Drawing.Size(839, 353);
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
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(839, 353);
			this.tableLayoutPanelMain.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageCreate);
			this.tabControl1.Controls.Add(this.tabPageModify);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(570, 3);
			this.tabControl1.Name = "tabControl1";
			this.tableLayoutPanelMain.SetRowSpan(this.tabControl1, 2);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(266, 347);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageCreate
			// 
			this.tabPageCreate.Controls.Add(this.tableLayoutPanel1);
			this.tabPageCreate.Location = new System.Drawing.Point(4, 24);
			this.tabPageCreate.Name = "tabPageCreate";
			this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCreate.Size = new System.Drawing.Size(258, 319);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 313);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// labelCreateCustomerName
			// 
			this.labelCreateCustomerName.AutoSize = true;
			this.labelCreateCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateCustomerName.Location = new System.Drawing.Point(3, 0);
			this.labelCreateCustomerName.Name = "labelCreateCustomerName";
			this.labelCreateCustomerName.Size = new System.Drawing.Size(69, 30);
			this.labelCreateCustomerName.TabIndex = 0;
			this.labelCreateCustomerName.Text = "Customer Name";
			this.labelCreateCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxCreateCustomerName
			// 
			this.textBoxCreateCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxCreateCustomerName.Location = new System.Drawing.Point(78, 3);
			this.textBoxCreateCustomerName.Name = "textBoxCreateCustomerName";
			this.textBoxCreateCustomerName.Size = new System.Drawing.Size(171, 23);
			this.textBoxCreateCustomerName.TabIndex = 1;
			// 
			// labelCreateCustomerAddress
			// 
			this.labelCreateCustomerAddress.AutoSize = true;
			this.labelCreateCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateCustomerAddress.Location = new System.Drawing.Point(3, 30);
			this.labelCreateCustomerAddress.Name = "labelCreateCustomerAddress";
			this.labelCreateCustomerAddress.Size = new System.Drawing.Size(69, 30);
			this.labelCreateCustomerAddress.TabIndex = 2;
			this.labelCreateCustomerAddress.Text = "Customer Address";
			this.labelCreateCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxCreateCustomerAddress
			// 
			this.textBoxCreateCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxCreateCustomerAddress.Location = new System.Drawing.Point(78, 33);
			this.textBoxCreateCustomerAddress.Name = "textBoxCreateCustomerAddress";
			this.textBoxCreateCustomerAddress.Size = new System.Drawing.Size(171, 23);
			this.textBoxCreateCustomerAddress.TabIndex = 3;
			// 
			// labelCreateOrderTime
			// 
			this.labelCreateOrderTime.AutoSize = true;
			this.labelCreateOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateOrderTime.Location = new System.Drawing.Point(3, 60);
			this.labelCreateOrderTime.Name = "labelCreateOrderTime";
			this.labelCreateOrderTime.Size = new System.Drawing.Size(69, 30);
			this.labelCreateOrderTime.TabIndex = 4;
			this.labelCreateOrderTime.Text = "Order Time";
			this.labelCreateOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimePickerCreateOrderTime
			// 
			this.dateTimePickerCreateOrderTime.CustomFormat = "dd/MMM/yyyy HH:mm:ss";
			this.dateTimePickerCreateOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerCreateOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerCreateOrderTime.Location = new System.Drawing.Point(78, 63);
			this.dateTimePickerCreateOrderTime.Name = "dateTimePickerCreateOrderTime";
			this.dateTimePickerCreateOrderTime.Size = new System.Drawing.Size(171, 23);
			this.dateTimePickerCreateOrderTime.TabIndex = 5;
			// 
			// labelCreateOrderDetails
			// 
			this.labelCreateOrderDetails.AutoSize = true;
			this.labelCreateOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreateOrderDetails.Location = new System.Drawing.Point(3, 90);
			this.labelCreateOrderDetails.Name = "labelCreateOrderDetails";
			this.labelCreateOrderDetails.Size = new System.Drawing.Size(69, 30);
			this.labelCreateOrderDetails.TabIndex = 6;
			this.labelCreateOrderDetails.Text = "Order Details";
			this.labelCreateOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonCreateOrderDetails
			// 
			this.buttonCreateOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCreateOrderDetails.Location = new System.Drawing.Point(78, 93);
			this.buttonCreateOrderDetails.Name = "buttonCreateOrderDetails";
			this.buttonCreateOrderDetails.Size = new System.Drawing.Size(171, 24);
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
			this.buttonCreateOrder.Size = new System.Drawing.Size(246, 24);
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
			this.tableLayoutPanel2.Controls.Add(this.textBoxModisyCustomerAddress, 1, 1);
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
			this.textBoxModisyCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxModisyCustomerAddress.Location = new System.Drawing.Point(78, 33);
			this.textBoxModisyCustomerAddress.Name = "textBoxModisyCustomerAddress";
			this.textBoxModisyCustomerAddress.Size = new System.Drawing.Size(171, 23);
			this.textBoxModisyCustomerAddress.TabIndex = 3;
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
			this.dataGridViewOrders.Size = new System.Drawing.Size(561, 170);
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
			this.dataGridViewOrderDetails.Location = new System.Drawing.Point(3, 179);
			this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
			this.dataGridViewOrderDetails.ReadOnly = true;
			this.dataGridViewOrderDetails.RowTemplate.Height = 25;
			this.dataGridViewOrderDetails.Size = new System.Drawing.Size(561, 171);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 399);
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
	private ToolStripMenuItem goodToolStripMenuItem;
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
	private TextBox textBoxModisyCustomerAddress;
	private Label labelModifyOrderTime;
	private DateTimePicker dateTimePickerModifyOrderTime;
	private Label labelModifyOrderDetails;
	private Button buttonModifyOrderDetails;
	private Button buttonModifySave;
	private Button buttonModifyDelete;
}
