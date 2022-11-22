namespace 期中專題
{
	partial class EditMemberForm
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
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.acountLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Location = new System.Drawing.Point(296, 73);
			this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(116, 23);
			this.phoneNumberTextBox.TabIndex = 4;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(296, 30);
			this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(116, 23);
			this.emailTextBox.TabIndex = 3;
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(74, 73);
			this.accountTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(116, 23);
			this.accountTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(74, 112);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(116, 23);
			this.passwordTextBox.TabIndex = 2;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(74, 30);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(116, 23);
			this.nameTextBox.TabIndex = 0;
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.phoneNumberLabel.Location = new System.Drawing.Point(220, 76);
			this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(62, 13);
			this.phoneNumberLabel.TabIndex = 6;
			this.phoneNumberLabel.Text = "手機號碼:";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.emailLabel.Location = new System.Drawing.Point(220, 34);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(38, 13);
			this.emailLabel.TabIndex = 7;
			this.emailLabel.Text = "Email:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.passwordLabel.Location = new System.Drawing.Point(28, 116);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(36, 13);
			this.passwordLabel.TabIndex = 8;
			this.passwordLabel.Text = "密碼:";
			// 
			// acountLabel
			// 
			this.acountLabel.AutoSize = true;
			this.acountLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.acountLabel.Location = new System.Drawing.Point(28, 76);
			this.acountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.acountLabel.Name = "acountLabel";
			this.acountLabel.Size = new System.Drawing.Size(36, 13);
			this.acountLabel.TabIndex = 9;
			this.acountLabel.Text = "帳號:";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.NameLabel.Location = new System.Drawing.Point(28, 34);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(36, 13);
			this.NameLabel.TabIndex = 10;
			this.NameLabel.Text = "姓名:";
			// 
			// updateButton
			// 
			this.updateButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(231, 167);
			this.updateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(88, 25);
			this.updateButton.TabIndex = 5;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(326, 167);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(88, 25);
			this.deleteButton.TabIndex = 6;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditMemberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 218);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.acountLabel);
			this.Controls.Add(this.NameLabel);
			this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditMemberForm";
			this.Text = "編輯會員資料";
			this.Load += new System.EventHandler(this.EditMemberForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label acountLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}