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

        #region Windows Form Designer Generated Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTh2 = new System.Windows.Forms.Label();
            this.textBoxStemLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.remakeButton = new System.Windows.Forms.Button();
            this.labelRecursionDepth = new System.Windows.Forms.Label();
            this.textBoxRecursionDepth = new System.Windows.Forms.TextBox();
            this.labelPer1 = new System.Windows.Forms.Label();
            this.textBoxPer1 = new System.Windows.Forms.TextBox();
            this.labelPer2 = new System.Windows.Forms.Label();
            this.textBoxPer2 = new System.Windows.Forms.TextBox();
            this.labelTh1 = new System.Windows.Forms.Label();
            this.textBoxTh1 = new System.Windows.Forms.TextBox();
            this.textBoxTh2 = new System.Windows.Forms.TextBox();
            this.labelPenColour = new System.Windows.Forms.Label();
            this.comboBoxPenColour = new System.Windows.Forms.ComboBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mainLayoutTable.SuspendLayout();
            this.drawingPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.drawingPanel.Controls.Add(this.statusStrip1);
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(210, 3);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(480, 415);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Nothing drawn yet.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelTh2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStemLength, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLength, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.remakeButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelRecursionDepth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRecursionDepth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPer1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPer1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPer2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPer2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTh1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTh1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTh2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelPenColour, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPenColour, 1, 6);
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
            // labelTh2
            // 
            this.labelTh2.AutoSize = true;
            this.labelTh2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTh2.Location = new System.Drawing.Point(3, 205);
            this.labelTh2.Name = "labelTh2";
            this.labelTh2.Size = new System.Drawing.Size(94, 41);
            this.labelTh2.TabIndex = 11;
            this.labelTh2.Text = "左分支角度";
            this.labelTh2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStemLength
            // 
            this.textBoxStemLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStemLength.Location = new System.Drawing.Point(103, 51);
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
            // textBoxPer1
            // 
            this.textBoxPer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPer1.Location = new System.Drawing.Point(103, 92);
            this.textBoxPer1.Name = "textBoxPer1";
            this.textBoxPer1.Size = new System.Drawing.Size(95, 20);
            this.textBoxPer1.TabIndex = 6;
            this.textBoxPer1.Text = "0.6";
            // 
            // labelPer2
            // 
            this.labelPer2.AutoSize = true;
            this.labelPer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPer2.Location = new System.Drawing.Point(3, 123);
            this.labelPer2.Name = "labelPer2";
            this.labelPer2.Size = new System.Drawing.Size(94, 41);
            this.labelPer2.TabIndex = 7;
            this.labelPer2.Text = "左分支长度比";
            this.labelPer2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPer2
            // 
            this.textBoxPer2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPer2.Location = new System.Drawing.Point(103, 133);
            this.textBoxPer2.Name = "textBoxPer2";
            this.textBoxPer2.Size = new System.Drawing.Size(95, 20);
            this.textBoxPer2.TabIndex = 8;
            this.textBoxPer2.Text = "0.7";
            // 
            // labelTh1
            // 
            this.labelTh1.AutoSize = true;
            this.labelTh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTh1.Location = new System.Drawing.Point(3, 164);
            this.labelTh1.Name = "labelTh1";
            this.labelTh1.Size = new System.Drawing.Size(94, 41);
            this.labelTh1.TabIndex = 9;
            this.labelTh1.Text = "右分支角度";
            this.labelTh1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTh1
            // 
            this.textBoxTh1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTh1.Location = new System.Drawing.Point(103, 174);
            this.textBoxTh1.Name = "textBoxTh1";
            this.textBoxTh1.Size = new System.Drawing.Size(95, 20);
            this.textBoxTh1.TabIndex = 10;
            this.textBoxTh1.Text = "30";
            // 
            // textBoxTh2
            // 
            this.textBoxTh2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTh2.Location = new System.Drawing.Point(103, 215);
            this.textBoxTh2.Name = "textBoxTh2";
            this.textBoxTh2.Size = new System.Drawing.Size(95, 20);
            this.textBoxTh2.TabIndex = 12;
            this.textBoxTh2.Text = "20";
            // 
            // labelPenColour
            // 
            this.labelPenColour.AutoSize = true;
            this.labelPenColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPenColour.Location = new System.Drawing.Point(3, 246);
            this.labelPenColour.Name = "labelPenColour";
            this.labelPenColour.Size = new System.Drawing.Size(94, 41);
            this.labelPenColour.TabIndex = 13;
            this.labelPenColour.Text = "画笔颜色";
            this.labelPenColour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPenColour
            // 
            this.comboBoxPenColour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPenColour.DisplayMember = "1";
            this.comboBoxPenColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPenColour.FormattingEnabled = true;
            this.comboBoxPenColour.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "RebeccaPurple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"});
            this.comboBoxPenColour.Location = new System.Drawing.Point(103, 256);
            this.comboBoxPenColour.Name = "comboBoxPenColour";
            this.comboBoxPenColour.Size = new System.Drawing.Size(95, 21);
            this.comboBoxPenColour.TabIndex = 14;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
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
            this.drawingPanel.ResumeLayout(false);
            this.drawingPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutTable;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTh2;
        private System.Windows.Forms.TextBox textBoxStemLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Button remakeButton;
        private System.Windows.Forms.Label labelRecursionDepth;
        private System.Windows.Forms.TextBox textBoxRecursionDepth;
        private System.Windows.Forms.Label labelPer1;
        private System.Windows.Forms.TextBox textBoxPer1;
        private System.Windows.Forms.Label labelPer2;
        private System.Windows.Forms.TextBox textBoxPer2;
        private System.Windows.Forms.Label labelTh1;
        private System.Windows.Forms.TextBox textBoxTh1;
        private System.Windows.Forms.TextBox textBoxTh2;
        private System.Windows.Forms.Label labelPenColour;
        private System.Windows.Forms.ComboBox comboBoxPenColour;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

