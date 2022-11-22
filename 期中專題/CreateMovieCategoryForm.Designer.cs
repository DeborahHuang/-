namespace 期中專題
{
	partial class CreateMovieCategoryForm
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
			this.categoryNameTextBox = new System.Windows.Forms.TextBox();
			this.categoryNameLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.displayOrderTextBox = new System.Windows.Forms.TextBox();
			this.displayOrderLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// categoryNameTextBox
			// 
			this.categoryNameTextBox.Location = new System.Drawing.Point(105, 59);
			this.categoryNameTextBox.Name = "categoryNameTextBox";
			this.categoryNameTextBox.Size = new System.Drawing.Size(100, 22);
			this.categoryNameTextBox.TabIndex = 1;
			// 
			// categoryNameLabel
			// 
			this.categoryNameLabel.AutoSize = true;
			this.categoryNameLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categoryNameLabel.Location = new System.Drawing.Point(37, 62);
			this.categoryNameLabel.Name = "categoryNameLabel";
			this.categoryNameLabel.Size = new System.Drawing.Size(62, 13);
			this.categoryNameLabel.TabIndex = 1;
			this.categoryNameLabel.Text = "電影類別:";
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.saveButton.Location = new System.Drawing.Point(185, 109);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// displayOrderTextBox
			// 
			this.displayOrderTextBox.Location = new System.Drawing.Point(105, 28);
			this.displayOrderTextBox.Name = "displayOrderTextBox";
			this.displayOrderTextBox.Size = new System.Drawing.Size(100, 22);
			this.displayOrderTextBox.TabIndex = 0;
			// 
			// displayOrderLabel
			// 
			this.displayOrderLabel.AutoSize = true;
			this.displayOrderLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.displayOrderLabel.Location = new System.Drawing.Point(37, 31);
			this.displayOrderLabel.Name = "displayOrderLabel";
			this.displayOrderLabel.Size = new System.Drawing.Size(62, 13);
			this.displayOrderLabel.TabIndex = 1;
			this.displayOrderLabel.Text = "類別編號:";
			// 
			// CreateMovieCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 163);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.displayOrderLabel);
			this.Controls.Add(this.categoryNameLabel);
			this.Controls.Add(this.displayOrderTextBox);
			this.Controls.Add(this.categoryNameTextBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateMovieCategoryForm";
			this.Text = "新增電影類別";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox categoryNameTextBox;
		private System.Windows.Forms.Label categoryNameLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label displayOrderLabel;
		private System.Windows.Forms.TextBox displayOrderTextBox;
	}
}