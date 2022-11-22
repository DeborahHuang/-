namespace 期中專題
{
	partial class OrdersForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.addButton = new System.Windows.Forms.Button();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rental = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.movieTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.OrderDate,
            this.DeadLine,
            this.PhoneNumber,
            this.Email,
            this.categoryNameDataGridViewTextBoxColumn,
            this.movieTitleDataGridViewTextBoxColumn,
            this.Rental});
			this.dataGridView1.DataSource = this.orderIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 44);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1191, 410);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addButton.Location = new System.Drawing.Point(1130, 13);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "新增";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(12, 17);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(56, 12);
			this.phoneNumberLabel.TabIndex = 6;
			this.phoneNumberLabel.Text = "手機號碼:";
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Location = new System.Drawing.Point(80, 11);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.phoneNumberTextBox.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.Location = new System.Drawing.Point(187, 11);
			this.searchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(59, 25);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "查詢";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// OrderDate
			// 
			this.OrderDate.DataPropertyName = "OrderDate";
			this.OrderDate.HeaderText = "訂閱時間";
			this.OrderDate.Name = "OrderDate";
			this.OrderDate.ReadOnly = true;
			this.OrderDate.Width = 150;
			// 
			// DeadLine
			// 
			this.DeadLine.DataPropertyName = "DeadLine";
			this.DeadLine.HeaderText = "截止時間";
			this.DeadLine.Name = "DeadLine";
			this.DeadLine.ReadOnly = true;
			this.DeadLine.Width = 150;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.DataPropertyName = "PhoneNumber";
			this.PhoneNumber.HeaderText = "手機號碼";
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.ReadOnly = true;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Width = 150;
			// 
			// Rental
			// 
			this.Rental.DataPropertyName = "Rental";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Rental.DefaultCellStyle = dataGridViewCellStyle1;
			this.Rental.HeaderText = "租金";
			this.Rental.Name = "Rental";
			this.Rental.ReadOnly = true;
			this.Rental.Width = 70;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 50;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 80;
			// 
			// accountDataGridViewTextBoxColumn
			// 
			this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
			this.accountDataGridViewTextBoxColumn.HeaderText = "會員帳號";
			this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
			this.accountDataGridViewTextBoxColumn.ReadOnly = true;
			this.accountDataGridViewTextBoxColumn.Width = 150;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "電影類別";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// movieTitleDataGridViewTextBoxColumn
			// 
			this.movieTitleDataGridViewTextBoxColumn.DataPropertyName = "MovieTitle";
			this.movieTitleDataGridViewTextBoxColumn.HeaderText = "電影名稱";
			this.movieTitleDataGridViewTextBoxColumn.Name = "movieTitleDataGridViewTextBoxColumn";
			this.movieTitleDataGridViewTextBoxColumn.ReadOnly = true;
			this.movieTitleDataGridViewTextBoxColumn.Width = 150;
			// 
			// orderIndexVMBindingSource
			// 
			this.orderIndexVMBindingSource.DataSource = typeof(期中專題.Models.ViewModels.OrderIndexVM);
			// 
			// orderIndexVMBindingSource1
			// 
			this.orderIndexVMBindingSource1.DataSource = typeof(期中專題.Models.ViewModels.OrderIndexVM);
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1217, 466);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrdersForm";
			this.Text = "檢視訂單";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.BindingSource orderIndexVMBindingSource;
		private System.Windows.Forms.BindingSource orderIndexVMBindingSource1;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rental;
	}
}