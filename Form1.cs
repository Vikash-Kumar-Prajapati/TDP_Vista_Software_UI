using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDP_Vista_Software_UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
		}

		private void rs_btn1_Paint(object sender, PaintEventArgs e)
		{
			//Font font = new Font("Cosmic Sans", 9);
			//Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

			//e.Graphics.TranslateTransform(100, 50);
			//e.Graphics.RotateTransform(90);
			//e.Graphics.DrawString("Btn 1", font, brush, 0, 0);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				this.WindowState = FormWindowState.Minimized;
			}
			else if(this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				this.WindowState = FormWindowState.Maximized;
			}
			else if(this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else if(this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Minimized;
			}
			else if(this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}


	}
}
