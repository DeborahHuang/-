namespace 期中專題
{
	partial class EditMovieForm
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
			this.rentalLabel = new System.Windows.Forms.Label();
			this.movieNameLabel = new System.Windows.Forms.Label();
			this.categoryNameLabel = new System.Windows.Forms.Label();
			this.rentalTextBox = new System.Windows.Forms.TextBox();
			this.movieTitleTextBox = new System.Windows.Forms.TextBox();
			this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
			this.movieCategoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// rentalLabel
			// 
			this.rentalLabel.AutoSize = true;
			this.rentalLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rentalLabel.Location = new System.Drawing.Point(27, 96);
			this.rentalLabel.Name = "rentalLabel";
			this.rentalLabel.Size = new System.Drawing.Size(36, 13);
			this.rentalLabel.TabIndex = 6;
			this.rentalLabel.Text = "租金:";
			// 
			// movieNameLabel
			// 
			this.movieNameLabel.AutoSize = true;
			this.movieNameLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.movieNameLabel.Location = new System.Drawing.Point(27, 62);
			this.movieNameLabel.Name = "movieNameLabel";
			this.movieNameLabel.Size = new System.Drawing.Size(62, 13);
			this.movieNameLabel.TabIndex = 7;
			this.movieNameLabel.Text = "電影名稱:";
			// 
			// categoryNameLabel
			// 
			this.categoryNameLabel.AutoSize = true;
			this.categoryNameLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categoryNameLabel.Location = new System.Drawing.Point(27, 31);
			this.categoryNameLabel.Name = "categoryNameLabel";
			this.categoryNameLabel.Size = new System.Drawing.Size(62, 13);
			this.categoryNameLabel.TabIndex = 8;
			this.categoryNameLabel.Text = "電影類別:";
			// 
			// rentalTextBox
			// 
			this.rentalTextBox.Location = new System.Drawing.Point(93, 93);
			this.rentalTextBox.Name = "rentalTextBox";
			this.rentalTextBox.Size = new System.Drawing.Size(121, 22);
			this.rentalTextBox.TabIndex = 2;
			// 
			// movieTitleTextBox
			// 
			this.movieTitleTextBox.Location = new System.Drawing.Point(93, 59);
			this.movieTitleTextBox.Name = "movieTitleTextBox";
			this.movieTitleTextBox.Size = new System.Drawing.Size(121, 22);
			this.movieTitleTextBox.TabIndex = 1;
			// 
			// categoryNameComboBox
			// 
			this.categoryNameComboBox.DataSource = this.movieCategoryIndexVMBindingSource;
			this.categoryNameComboBox.DisplayMember = "CategoryName";
			this.categoryNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryNameComboBox.FormattingEnabled = true;
			this.categoryNameComboBox.Location = new System.Drawing.Point(93, 28);
			this.categoryNameComboBox.Name = "categoryNameComboBox";
			this.categoryNameComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryNameComboBox.TabIndex = 0;
			this.categoryNameComboBox.ValueMember = "Id";
			// 
			// movieCategoryIndexVMBindingSource
			// 
			this.movieCategoryIndexVMBindingSource.DataSource = typeof(期中專題.Models.Services.MovieCategoryIndexVM);
			// 
			// updateButton
			// 
			this.updateButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(139, 146);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(220, 146);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// EditMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 194);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.rentalLabel);
			this.Controls.Add(this.movieNameLabel);
			this.Controls.Add(this.categoryNameLabel);
			this.Controls.Add(this.rentalTextBox);
			this.Controls.Add(this.movieTitleTextBox);
			this.Controls.Add(this.categoryNameComboBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditMovieForm";
			this.Text = "編輯電影";
			this.Load += new System.EventHandler(this.EditMovieForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label rentalLabel;
		private System.Windows.Forms.Label movieNameLabel;
		private System.Windows.Forms.Label categoryNameLabel;
		private System.Windows.Forms.TextBox rentalTextBox;
		private System.Windows.Forms.TextBox movieTitleTextBox;
		private System.Windows.Forms.ComboBox categoryNameComboBox;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.BindingSource movieCategoryIndexVMBindingSource;
	}
}