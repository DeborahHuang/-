namespace 期中專題
{
	partial class MoviesForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.categoryComboBox = new System.Windows.Forms.ComboBox();
			this.movieCategoryIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.movieCategoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.movieTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rentalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.movieIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movieIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// categoryComboBox
			// 
			this.categoryComboBox.DataSource = this.movieCategoryIndexVMBindingSource1;
			this.categoryComboBox.DisplayMember = "CategoryName";
			this.categoryComboBox.FormattingEnabled = true;
			this.categoryComboBox.Location = new System.Drawing.Point(14, 24);
			this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.categoryComboBox.Name = "categoryComboBox";
			this.categoryComboBox.Size = new System.Drawing.Size(120, 21);
			this.categoryComboBox.TabIndex = 0;
			this.categoryComboBox.ValueMember = "Id";
			// 
			// movieCategoryIndexVMBindingSource1
			// 
			this.movieCategoryIndexVMBindingSource1.DataSource = typeof(期中專題.Models.Services.MovieCategoryIndexVM);
			// 
			// movieCategoryIndexVMBindingSource
			// 
			this.movieCategoryIndexVMBindingSource.DataSource = typeof(期中專題.Models.Services.MovieCategoryIndexVM);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.movieTitleDataGridViewTextBoxColumn,
            this.rentalDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.movieIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(14, 62);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(406, 271);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// CategoryName
			// 
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.HeaderText = "電影類別";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.ReadOnly = true;
			// 
			// movieTitleDataGridViewTextBoxColumn
			// 
			this.movieTitleDataGridViewTextBoxColumn.DataPropertyName = "MovieTitle";
			this.movieTitleDataGridViewTextBoxColumn.HeaderText = "電影名稱";
			this.movieTitleDataGridViewTextBoxColumn.Name = "movieTitleDataGridViewTextBoxColumn";
			this.movieTitleDataGridViewTextBoxColumn.ReadOnly = true;
			this.movieTitleDataGridViewTextBoxColumn.Width = 180;
			// 
			// rentalDataGridViewTextBoxColumn
			// 
			this.rentalDataGridViewTextBoxColumn.DataPropertyName = "Rental";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.rentalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.rentalDataGridViewTextBoxColumn.HeaderText = "租金";
			this.rentalDataGridViewTextBoxColumn.Name = "rentalDataGridViewTextBoxColumn";
			this.rentalDataGridViewTextBoxColumn.ReadOnly = true;
			this.rentalDataGridViewTextBoxColumn.Width = 70;
			// 
			// movieIndexVMBindingSource
			// 
			this.movieIndexVMBindingSource.DataSource = typeof(期中專題.Models.ViewModels.MovieIndexVM);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.Location = new System.Drawing.Point(142, 22);
			this.searchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(72, 25);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "搜尋";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addButton.Location = new System.Drawing.Point(348, 21);
			this.addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(72, 25);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "新增";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// MoviesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 346);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.categoryComboBox);
			this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MoviesForm";
			this.Text = "檢視電影名稱";
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movieCategoryIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movieIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox categoryComboBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.BindingSource movieCategoryIndexVMBindingSource;
		private System.Windows.Forms.BindingSource movieIndexVMBindingSource;
		private System.Windows.Forms.BindingSource movieCategoryIndexVMBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rentalDataGridViewTextBoxColumn;
	}
}