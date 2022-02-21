namespace WindowsFormsCalculator {
	partial class Form1 {
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
			this.ds = new System.Windows.Forms.Label();
			this.OperandFirst = new System.Windows.Forms.TextBox();
			this.OperatorSelector = new System.Windows.Forms.ComboBox();
			this.OperandSecond = new System.Windows.Forms.TextBox();
			this.Calculate = new System.Windows.Forms.Button();
			this.Result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ds
			// 
			this.ds.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.ds.Location = new System.Drawing.Point(68, 30);
			this.ds.Margin = new System.Windows.Forms.Padding(0);
			this.ds.Name = "ds";
			this.ds.Size = new System.Drawing.Size(475, 55);
			this.ds.TabIndex = 0;
			this.ds.Text = "Enter your favourite operand:";
			// 
			// OperandFirst
			// 
			this.OperandFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.OperandFirst.Location = new System.Drawing.Point(50, 100);
			this.OperandFirst.Name = "OperandFirst";
			this.OperandFirst.Size = new System.Drawing.Size(200, 31);
			this.OperandFirst.TabIndex = 1;
			// 
			// OperatorSelector
			// 
			this.OperatorSelector.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.OperatorSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.OperatorSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.OperatorSelector.FormattingEnabled = true;
			this.OperatorSelector.Items.AddRange(new object[] {"+", "-", "*", "/", "%", "^", "&", "|"});
			this.OperatorSelector.Location = new System.Drawing.Point(280, 100);
			this.OperatorSelector.Name = "OperatorSelector";
			this.OperatorSelector.Size = new System.Drawing.Size(50, 32);
			this.OperatorSelector.TabIndex = 2;
			// 
			// OperandSecond
			// 
			this.OperandSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.OperandSecond.Location = new System.Drawing.Point(350, 100);
			this.OperandSecond.Name = "OperandSecond";
			this.OperandSecond.Size = new System.Drawing.Size(200, 31);
			this.OperandSecond.TabIndex = 3;
			// 
			// Calculate
			// 
			this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Calculate.Location = new System.Drawing.Point(240, 150);
			this.Calculate.Name = "Calculate";
			this.Calculate.Size = new System.Drawing.Size(120, 40);
			this.Calculate.TabIndex = 4;
			this.Calculate.Text = "Calculate";
			this.Calculate.UseVisualStyleBackColor = true;
			// 
			// Result
			// 
			this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Result.Location = new System.Drawing.Point(50, 210);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(500, 32);
			this.Result.TabIndex = 5;
			this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(594, 271);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.Calculate);
			this.Controls.Add(this.OperandSecond);
			this.Controls.Add(this.OperatorSelector);
			this.Controls.Add(this.OperandFirst);
			this.Controls.Add(this.ds);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(600, 300);
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "Form1";
			this.Text = "Calculator GUI";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label Result;

		private System.Windows.Forms.Button Calculate;

		private System.Windows.Forms.TextBox OperandSecond;

		private System.Windows.Forms.ComboBox OperatorSelector;

		private System.Windows.Forms.TextBox OperandFirst;

		private System.Windows.Forms.Label ds;

		#endregion
	}
}