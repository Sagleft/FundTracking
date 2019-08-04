/*
 * Сделано в SharpDevelop.
 * Пользователь: SystemShock
 * Дата: 10.03.2019
 * Время: 17:35
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace FundTracking
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.windowTitle = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// windowTitle
			// 
			this.windowTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.windowTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.windowTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.windowTitle.ForeColor = System.Drawing.Color.White;
			this.windowTitle.Location = new System.Drawing.Point(0, 0);
			this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.windowTitle.Name = "windowTitle";
			this.windowTitle.Size = new System.Drawing.Size(1067, 41);
			this.windowTitle.TabIndex = 1;
			this.windowTitle.Text = "        Fund Tracking";
			this.windowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(21, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
			this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonExit.FlatAppearance.BorderSize = 0;
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonExit.Location = new System.Drawing.Point(1017, 0);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(43, 39);
			this.buttonExit.TabIndex = 4;
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(975, 0);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(43, 39);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(552, 556);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(288, 39);
			this.button3.TabIndex = 5;
			this.button3.Text = "Добавить новую цель";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SlateGray;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 41);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(323, 569);
			this.panel1.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(1067, 610);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.windowTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "FundTracking";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label windowTitle;
	}
}
