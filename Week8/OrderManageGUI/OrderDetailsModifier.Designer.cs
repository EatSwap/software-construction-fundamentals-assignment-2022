namespace OrderManageGUI;

partial class OrderDetailsModifier {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
			this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceOrderDetails = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.labelAddItem = new System.Windows.Forms.Label();
			this.labelItemName = new System.Windows.Forms.Label();
			this.textBoxItemName = new System.Windows.Forms.TextBox();
			this.labelUnitPrice = new System.Windows.Forms.Label();
			this.labelCount = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelRemoveItem = new System.Windows.Forms.Label();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonDone = new System.Windows.Forms.Button();
			this.numericUpDownUnitPrice = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderDetails)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewOrderDetails, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 311);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// dataGridViewOrderDetails
			// 
			this.dataGridViewOrderDetails.AllowUserToAddRows = false;
			this.dataGridViewOrderDetails.AllowUserToDeleteRows = false;
			this.dataGridViewOrderDetails.AutoGenerateColumns = false;
			this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.unitPriceStrDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceStrDataGridViewTextBoxColumn});
			this.dataGridViewOrderDetails.DataSource = this.bindingSourceOrderDetails;
			this.dataGridViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewOrderDetails.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
			this.dataGridViewOrderDetails.ReadOnly = true;
			this.dataGridViewOrderDetails.RowTemplate.Height = 25;
			this.dataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewOrderDetails.Size = new System.Drawing.Size(484, 305);
			this.dataGridViewOrderDetails.TabIndex = 0;
			// 
			// itemNameDataGridViewTextBoxColumn
			// 
			this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
			this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
			this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
			this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitPriceStrDataGridViewTextBoxColumn
			// 
			this.unitPriceStrDataGridViewTextBoxColumn.DataPropertyName = "UnitPriceStr";
			this.unitPriceStrDataGridViewTextBoxColumn.HeaderText = "Unit Price";
			this.unitPriceStrDataGridViewTextBoxColumn.Name = "unitPriceStrDataGridViewTextBoxColumn";
			this.unitPriceStrDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// countDataGridViewTextBoxColumn
			// 
			this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
			this.countDataGridViewTextBoxColumn.HeaderText = "Count";
			this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			this.countDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceStrDataGridViewTextBoxColumn
			// 
			this.priceStrDataGridViewTextBoxColumn.DataPropertyName = "PriceStr";
			this.priceStrDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceStrDataGridViewTextBoxColumn.Name = "priceStrDataGridViewTextBoxColumn";
			this.priceStrDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bindingSourceOrderDetails
			// 
			this.bindingSourceOrderDetails.DataSource = typeof(OrderManageCLI.OrderDetails);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.tableLayoutPanel2.Controls.Add(this.labelAddItem, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.labelItemName, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBoxItemName, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.labelUnitPrice, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.labelCount, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.labelRemoveItem, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.buttonRemove, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.buttonClear, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.buttonDone, 0, 8);
			this.tableLayoutPanel2.Controls.Add(this.numericUpDownUnitPrice, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.numericUpDownCount, 1, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(493, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 10;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(204, 305);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// labelAddItem
			// 
			this.labelAddItem.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.labelAddItem, 2);
			this.labelAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAddItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelAddItem.Location = new System.Drawing.Point(3, 0);
			this.labelAddItem.Name = "labelAddItem";
			this.labelAddItem.Size = new System.Drawing.Size(198, 30);
			this.labelAddItem.TabIndex = 0;
			this.labelAddItem.Text = "Add Item";
			this.labelAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelItemName
			// 
			this.labelItemName.AutoSize = true;
			this.labelItemName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelItemName.Location = new System.Drawing.Point(3, 30);
			this.labelItemName.Name = "labelItemName";
			this.labelItemName.Size = new System.Drawing.Size(65, 30);
			this.labelItemName.TabIndex = 1;
			this.labelItemName.Text = "Item Name";
			this.labelItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxItemName
			// 
			this.textBoxItemName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxItemName.Location = new System.Drawing.Point(74, 33);
			this.textBoxItemName.Name = "textBoxItemName";
			this.textBoxItemName.Size = new System.Drawing.Size(127, 23);
			this.textBoxItemName.TabIndex = 2;
			// 
			// labelUnitPrice
			// 
			this.labelUnitPrice.AutoSize = true;
			this.labelUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelUnitPrice.Location = new System.Drawing.Point(3, 60);
			this.labelUnitPrice.Name = "labelUnitPrice";
			this.labelUnitPrice.Size = new System.Drawing.Size(65, 30);
			this.labelUnitPrice.TabIndex = 3;
			this.labelUnitPrice.Text = "Unit Price";
			this.labelUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCount.Location = new System.Drawing.Point(3, 90);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(65, 30);
			this.labelCount.TabIndex = 5;
			this.labelCount.Text = "Count";
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonAdd
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.buttonAdd, 2);
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAdd.Location = new System.Drawing.Point(3, 123);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(198, 24);
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "Add an Item";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelRemoveItem
			// 
			this.labelRemoveItem.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.labelRemoveItem, 2);
			this.labelRemoveItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRemoveItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelRemoveItem.Location = new System.Drawing.Point(3, 150);
			this.labelRemoveItem.Name = "labelRemoveItem";
			this.labelRemoveItem.Size = new System.Drawing.Size(198, 30);
			this.labelRemoveItem.TabIndex = 8;
			this.labelRemoveItem.Text = "Remove Item(s)";
			this.labelRemoveItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonRemove
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.buttonRemove, 2);
			this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonRemove.Location = new System.Drawing.Point(3, 183);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(198, 24);
			this.buttonRemove.TabIndex = 9;
			this.buttonRemove.Text = "Remove Selected Items";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// buttonClear
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.buttonClear, 2);
			this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonClear.Location = new System.Drawing.Point(3, 213);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(198, 24);
			this.buttonClear.TabIndex = 10;
			this.buttonClear.Text = "Clear All Items";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonDone
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.buttonDone, 2);
			this.buttonDone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonDone.Location = new System.Drawing.Point(3, 243);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new System.Drawing.Size(198, 24);
			this.buttonDone.TabIndex = 11;
			this.buttonDone.Text = "Done";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
			// 
			// numericUpDownUnitPrice
			// 
			this.numericUpDownUnitPrice.DecimalPlaces = 2;
			this.numericUpDownUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDownUnitPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numericUpDownUnitPrice.Location = new System.Drawing.Point(74, 63);
			this.numericUpDownUnitPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDownUnitPrice.Name = "numericUpDownUnitPrice";
			this.numericUpDownUnitPrice.Size = new System.Drawing.Size(127, 23);
			this.numericUpDownUnitPrice.TabIndex = 12;
			this.numericUpDownUnitPrice.ValueChanged += new System.EventHandler(this.numericUpDownUnitPrice_ValueChanged);
			// 
			// numericUpDownCount
			// 
			this.numericUpDownCount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDownCount.Location = new System.Drawing.Point(74, 93);
			this.numericUpDownCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDownCount.Name = "numericUpDownCount";
			this.numericUpDownCount.Size = new System.Drawing.Size(127, 23);
			this.numericUpDownCount.TabIndex = 13;
			// 
			// OrderDetailsModifier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 311);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "OrderDetailsModifier";
			this.Text = "OrderDetailsModifier";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderDetails)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private DataGridView dataGridViewOrderDetails;
    private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn unitPriceStrDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn priceStrDataGridViewTextBoxColumn;
    private BindingSource bindingSourceOrderDetails;
    private TableLayoutPanel tableLayoutPanel2;
    private Label labelAddItem;
    private Label labelItemName;
    private TextBox textBoxItemName;
    private Label labelUnitPrice;
    private Label labelCount;
    private Button buttonAdd;
    private Label labelRemoveItem;
    private Button buttonRemove;
    private Button buttonClear;
	private Button buttonDone;
	private NumericUpDown numericUpDownUnitPrice;
	private NumericUpDown numericUpDownCount;
}
