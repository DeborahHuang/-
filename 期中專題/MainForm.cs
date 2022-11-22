using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}

		private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
		{

		}

		private void 維護會員ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new MembersForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 類別ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new MovieCategoriesForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 名稱ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new MoviesForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護訂單ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new OrdersForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
