namespace 期中專題
{
	partial class EditMovieCategoryForm
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
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.categoryNameLabel = new System.Windows.Forms.Label();
			this.categoryNameTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.displayOrderLabel = new System.Windows.Forms.Label();
			this.displayOrderTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(199, 135);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(118, 135);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 2;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
			// 
			// categoryNameLabel
			// 
			this.categoryNameLabel.AutoSize = true;
			this.categoryNameLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categoryNameLabel.Location = new System.Drawing.Point(29, 75);
			this.categoryNameLabel.Name = "categoryNameLabel";
			this.categoryNameLabel.Size = new System.Drawing.Size(62, 13);
			this.categoryNameLabel.TabIndex = 3;
			this.categoryNameLabel.Text = "電影類別:";
			// 
			// categoryNameTextBox
			// 
			this.categoryNameTextBox.Location = new System.Drawing.Point(97, 72);
			this.categoryNameTextBox.Name = "categoryNameTextBox";
			this.categoryNameTextBox.Size = new System.Drawing.Size(121, 22);
			this.categoryNameTextBox.TabIndex = 1;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// displayOrderLabel
			// 
			this.displayOrderLabel.AutoSize = true;
			this.displayOrderLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.displayOrderLabel.Location = new System.Drawing.Point(29, 40);
			this.displayOrderLabel.Name = "displayOrderLabel";
			this.displayOrderLabel.Size = new System.Drawing.Size(62, 13);
			this.displayOrderLabel.TabIndex = 3;
			this.displayOrderLabel.Text = "類別編號:";
			// 
			// displayOrderTextBox
			// 
			this.displayOrderTextBox.Location = new System.Drawing.Point(97, 37);
			this.displayOrderTextBox.Name = "displayOrderTextBox";
			this.displayOrderTextBox.Size = new System.Drawing.Size(121, 22);
			this.displayOrderTextBox.TabIndex = 0;
			// 
			// EditMovieCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 180);
			this.Controls.Add(this.displayOrderLabel);
			this.Controls.Add(this.categoryNameLabel);
			this.Controls.Add(this.displayOrderTextBox);
			this.Controls.Add(this.categoryNameTextBox);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditMovieCategoryForm";
			this.Text = "編輯電影類別";
			this.Load += new System.EventHandler(this.EditMovieCategoryForm_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label categoryNameLabel;
		private System.Windows.Forms.TextBox categoryNameTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label displayOrderLabel;
		private System.Windows.Forms.TextBox displayOrderTextBox;
	}
}