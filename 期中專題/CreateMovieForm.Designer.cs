namespace 期中專題
{
	partial class CreateMovieForm
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
			this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
			this.movieCategoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.movieTitleTextBox = new System.Windows.Forms.TextBox();
			this.rentalTextBox = new System.Windows.Forms.TextBox();
			this.categoryNameLabel = new System.Windows.Forms.Label();
			this.movieNameLabel = new System.Windows.Forms.Label();
			this.rentalLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// categoryNameComboBox
			// 
			this.categoryNameComboBox.DataSource = this.movieCategoryIndexVMBindingSource;
			this.categoryNameComboBox.DisplayMember = "CategoryName";
			this.categoryNameComboBox.FormattingEnabled = true;
			this.categoryNameComboBox.Location = new System.Drawing.Point(100, 30);
			this.categoryNameComboBox.Name = "categoryNameComboBox";
			this.categoryNameComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryNameComboBox.TabIndex = 0;
			this.categoryNameComboBox.ValueMember = "Id";
			// 
			// movieCategoryIndexVMBindingSource
			// 
			this.movieCategoryIndexVMBindingSource.DataSource = typeof(期中專題.Models.Services.MovieCategoryIndexVM);
			// 
			// movieTitleTextBox
			// 
			this.movieTitleTextBox.Location = new System.Drawing.Point(100, 61);
			this.movieTitleTextBox.Name = "movieTitleTextBox";
			this.movieTitleTextBox.Size = new System.Drawing.Size(121, 22);
			this.movieTitleTextBox.TabIndex = 1;
			// 
			// rentalTextBox
			// 
			this.rentalTextBox.Location = new System.Drawing.Point(100, 95);
			this.rentalTextBox.Name = "rentalTextBox";
			this.rentalTextBox.Size = new System.Drawing.Size(121, 22);
			this.rentalTextBox.TabIndex = 2;
			// 
			// categoryNameLabel
			// 
			this.categoryNameLabel.AutoSize = true;
			this.categoryNameLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categoryNameLabel.Location = new System.Drawing.Point(34, 33);
			this.categoryNameLabel.Name = "categoryNameLabel";
			this.categoryNameLabel.Size = new System.Drawing.Size(62, 13);
			this.categoryNameLabel.TabIndex = 2;
			this.categoryNameLabel.Text = "電影類別:";
			// 
			// movieNameLabel
			// 
			this.movieNameLabel.AutoSize = true;
			this.movieNameLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.movieNameLabel.Location = new System.Drawing.Point(34, 64);
			this.movieNameLabel.Name = "movieNameLabel";
			this.movieNameLabel.Size = new System.Drawing.Size(62, 13);
			this.movieNameLabel.TabIndex = 2;
			this.movieNameLabel.Text = "電影名稱:";
			// 
			// rentalLabel
			// 
			this.rentalLabel.AutoSize = true;
			this.rentalLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rentalLabel.Location = new System.Drawing.Point(58, 98);
			this.rentalLabel.Name = "rentalLabel";
			this.rentalLabel.Size = new System.Drawing.Size(36, 13);
			this.rentalLabel.TabIndex = 2;
			this.rentalLabel.Text = "租金:";
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.saveButton.Location = new System.Drawing.Point(225, 134);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "新增";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 178);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.rentalLabel);
			this.Controls.Add(this.movieNameLabel);
			this.Controls.Add(this.categoryNameLabel);
			this.Controls.Add(this.rentalTextBox);
			this.Controls.Add(this.movieTitleTextBox);
			this.Controls.Add(this.categoryNameComboBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateMovieForm";
			this.Text = "新增電影";
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox categoryNameComboBox;
		private System.Windows.Forms.TextBox movieTitleTextBox;
		private System.Windows.Forms.TextBox rentalTextBox;
		private System.Windows.Forms.Label categoryNameLabel;
		private System.Windows.Forms.Label movieNameLabel;
		private System.Windows.Forms.Label rentalLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.BindingSource movieCategoryIndexVMBindingSource;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}