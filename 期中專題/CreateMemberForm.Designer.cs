namespace 期中專題
{
	partial class CreateMemberForm
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.acountLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(26, 23);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(32, 12);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "姓名:";
			// 
			// acountLabel
			// 
			this.acountLabel.AutoSize = true;
			this.acountLabel.Location = new System.Drawing.Point(26, 62);
			this.acountLabel.Name = "acountLabel";
			this.acountLabel.Size = new System.Drawing.Size(32, 12);
			this.acountLabel.TabIndex = 0;
			this.acountLabel.Text = "帳號:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(26, 99);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(32, 12);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "密碼:";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(191, 23);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(35, 12);
			this.emailLabel.TabIndex = 0;
			this.emailLabel.Text = "Email:";
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(191, 62);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(56, 12);
			this.phoneNumberLabel.TabIndex = 0;
			this.phoneNumberLabel.Text = "手機號碼:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(65, 20);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 22);
			this.nameTextBox.TabIndex = 0;
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(65, 59);
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(100, 22);
			this.accountTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(65, 95);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
			this.passwordTextBox.TabIndex = 2;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(256, 20);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(100, 22);
			this.emailTextBox.TabIndex = 3;
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Location = new System.Drawing.Point(256, 59);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.phoneNumberTextBox.TabIndex = 4;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(281, 136);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 5;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateMemberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 184);
			this.Controls.Add(this.saveButton);
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateMemberForm";
			this.Text = "註冊新會員";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label acountLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}