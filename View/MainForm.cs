using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace FundTracking
{
	public partial class MainForm : Form {
		int x, y;
    	bool s = false;
    	
		public MainForm() {
			InitializeComponent();
			this.SuspendLayout();
			this.KeyPreview = true;
			//перетаскивание за форму
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_Mouse);
	        this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_Mouse);
	        //перетаскивание за заголовок
	        windowTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_Mouse);
	        windowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_Mouse);
	        this.ResumeLayout(false);
		}
    	
    	private void Form1_Mouse(object sender, MouseEventArgs e) {
	        if (s == false) { x = e.X; y = e.Y; s = true; }
	        if (e.Button.ToString() == "Left")
	        { this.Location = new Point(this.Left + e.X - x, this.Top + e.Y - y); }
	        else { s = false; }
	    }
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
