namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region G

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxStemLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.remakeButton = new System.Windows.Forms.Button();
            this.labelRecursionDepth = new System.Windows.Forms.Label();
            this.textBoxRecursionDepth = new System.Windows.Forms.TextBox();
            this.labelPer1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainLayoutTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutTable
            // 
            this.mainLayoutTable.ColumnCount = 2;
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainLayoutTable.Controls.Add(this.drawingPanel, 1, 0);
            this.mainLayoutTable.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutTable.Name = "mainLayoutTable";
            this.mainLayoutTable.RowCount = 1;
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutTable.Size = new System.Drawing.Size(693, 421);
            this.mainLayoutTable.TabIndex = 0;
            // 
            // drawingPanel
            // 
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(210, 3);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(480, 415);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxStemLength, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLength, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.remakeButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelRecursionDepth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRecursionDepth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPer1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 415);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxStemLength
            // 
            this.textBoxStemLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStemLength.Location = new System.Drawing.Point(103, 51);
            this.textBoxStemLength.MaxLength = 3;
            this.textBoxStemLength.Name = "textBoxStemLength";
            this.textBoxStemLength.Size = new System.Drawing.Size(95, 20);
            this.textBoxStemLength.TabIndex = 4;
            this.textBoxStemLength.Text = "100";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLength.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLength.Location = new System.Drawing.Point(3, 41);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(94, 41);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "主干长度";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // remakeButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.remakeButton, 2);
            this.remakeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remakeButton.Font = new System.Drawing.Font("DengXian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remakeButton.Location = new System.Drawing.Point(3, 290);
            this.remakeButton.Name = "remakeButton";
            this.remakeButton.Size = new System.Drawing.Size(195, 122);
            this.remakeButton.TabIndex = 0;
            this.remakeButton.Text = "马上重开！";
            this.remakeButton.UseVisualStyleBackColor = true;
            this.remakeButton.Click += new System.EventHandler(this.remakeButton_Click);
            // 
            // labelRecursionDepth
            // 
            this.labelRecursionDepth.AutoSize = true;
            this.labelRecursionDepth.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelRecursionDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRecursionDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecursionDepth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRecursionDepth.Location = new System.Drawing.Point(3, 0);
            this.labelRecursionDepth.Name = "labelRecursionDepth";
            this.labelRecursionDepth.Size = new System.Drawing.Size(94, 41);
            this.labelRecursionDepth.TabIndex = 1;
            this.labelRecursionDepth.Text = "递归深度";
            this.labelRecursionDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxRecursionDepth
            // 
            this.textBoxRecursionDepth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRecursionDepth.Location = new System.Drawing.Point(103, 10);
            this.textBoxRecursionDepth.MaxLength = 3;
            this.textBoxRecursionDepth.Name = "textBoxRecursionDepth";
            this.textBoxRecursionDepth.Size = new System.Drawing.Size(95, 20);
            this.textBoxRecursionDepth.TabIndex = 2;
            this.textBoxRecursionDepth.Text = "11";
            // 
            // labelPer1
            // 
            this.labelPer1.AutoSize = true;
            this.labelPer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPer1.Location = new System.Drawing.Point(3, 82);
            this.labelPer1.Name = "labelPer1";
            this.labelPer1.Size = new System.Drawing.Size(94, 41);
            this.labelPer1.TabIndex = 5;
            this.labelPer1.Text = "右分支长度比";
            this.labelPer1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(103, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 421);
            this.Controls.Add(this.mainLayoutTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cayley Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainLayoutTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutTable;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button remakeButton;
        private System.Windows.Forms.Label labelRecursionDepth;
        private System.Windows.Forms.TextBox textBoxRecursionDepth;
        private System.Windows.Forms.TextBox textBoxStemLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelPer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

