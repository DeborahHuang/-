namespace 期中專題
{
	partial class CreateOrderForm
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
			this.saveButton = new System.Windows.Forms.Button();
			this.memberIdTextBox = new System.Windows.Forms.TextBox();
			this.movieTitleComboBox = new System.Windows.Forms.ComboBox();
			this.orderIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
			this.orderIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.categoryNameLabel = new System.Windows.Forms.Label();
			this.movieTitleLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.saveButton.Location = new System.Drawing.Point(242, 157);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// memberIdTextBox
			// 
			this.memberIdTextBox.Location = new System.Drawing.Point(97, 100);
			this.memberIdTextBox.Name = "memberIdTextBox";
			this.memberIdTextBox.Size = new System.Drawing.Size(152, 22);
			this.memberIdTextBox.TabIndex = 2;
			// 
			// movieTitleComboBox
			// 
			this.movieTitleComboBox.DataSource = this.orderIndexVMBindingSource1;
			this.movieTitleComboBox.DisplayMember = "MovieTitle";
			this.movieTitleComboBox.FormattingEnabled = true;
			this.movieTitleComboBox.Location = new System.Drawing.Point(97, 67);
			this.movieTitleComboBox.Name = "movieTitleComboBox";
			this.movieTitleComboBox.Size = new System.Drawing.Size(152, 20);
			this.movieTitleComboBox.TabIndex = 1;
			this.movieTitleComboBox.ValueMember = "MovieId";
			// 
			// orderIndexVMBindingSource1
			// 
			this.orderIndexVMBindingSource1.DataSource = typeof(期中專題.Models.ViewModels.OrderIndexVM);
			// 
			// categoryNameComboBox
			// 
			this.categoryNameComboBox.DataSource = this.orderIndexVMBindingSource;
			this.categoryNameComboBox.DisplayMember = "CategoryName";
			this.categoryNameComboBox.FormattingEnabled = true;
			this.categoryNameComboBox.Location = new System.Drawing.Point(97, 37);
			this.categoryNameComboBox.Name = "categoryNameComboBox";
			this.categoryNameComboBox.Size = new System.Drawing.Size(152, 20);
			this.categoryNameComboBox.TabIndex = 0;
			this.categoryNameComboBox.ValueMember = "MovieCategoryId";
			// 
			// orderIndexVMBindingSource
			// 
			this.orderIndexVMBindingSource.DataSource = typeof(期中專題.Models.ViewModels.OrderIndexVM);
			// 
			// categoryNameLabel
			// 
			this.categoryNameLabel.AutoSize = true;
			this.categoryNameLabel.Location = new System.Drawing.Point(35, 40);
			this.categoryNameLabel.Name = "categoryNameLabel";
			this.categoryNameLabel.Size = new System.Drawing.Size(56, 12);
			this.categoryNameLabel.TabIndex = 6;
			this.categoryNameLabel.Text = "電影類別:";
			// 
			// movieTitleLabel
			// 
			this.movieTitleLabel.AutoSize = true;
			this.movieTitleLabel.Location = new System.Drawing.Point(35, 70);
			this.movieTitleLabel.Name = "movieTitleLabel";
			this.movieTitleLabel.Size = new System.Drawing.Size(56, 12);
			this.movieTitleLabel.TabIndex = 6;
			this.movieTitleLabel.Text = "電影名稱:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "會員ID:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 210);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.memberIdTextBox);
			this.Controls.Add(this.movieTitleComboBox);
			this.Controls.Add(this.categoryNameComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.movieTitleLabel);
			this.Controls.Add(this.categoryNameLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateOrderForm";
			this.Text = "新增訂單";
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox memberIdTextBox;
		private System.Windows.Forms.ComboBox movieTitleComboBox;
		private System.Windows.Forms.ComboBox categoryNameComboBox;
		private System.Windows.Forms.Label categoryNameLabel;
		private System.Windows.Forms.Label movieTitleLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource orderIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource orderIndexVMBindingSource;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}