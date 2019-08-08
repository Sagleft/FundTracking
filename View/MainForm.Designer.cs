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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.entry_commentBox = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_allEntrys = new System.Windows.Forms.TabPage();
			this.DGV_allEntrys = new System.Windows.Forms.DataGridView();
			this.tab_payments = new System.Windows.Forms.TabPage();
			this.tab_targets = new System.Windows.Forms.TabPage();
			this.tab_investments = new System.Windows.Forms.TabPage();
			this.dataView_main = new System.Data.DataView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tab_allEntrys.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_allEntrys)).BeginInit();
			this.tab_payments.SuspendLayout();
			this.tab_targets.SuspendLayout();
			this.tab_investments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView_main)).BeginInit();
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
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
			this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
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
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(43, 39);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SlateGray;
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 41);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(323, 569);
			this.panel1.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.entry_commentBox);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(16, 324);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(289, 233);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Детали";
			// 
			// entry_commentBox
			// 
			this.entry_commentBox.BackColor = System.Drawing.Color.SlateGray;
			this.entry_commentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.entry_commentBox.ForeColor = System.Drawing.Color.White;
			this.entry_commentBox.Location = new System.Drawing.Point(20, 38);
			this.entry_commentBox.Name = "entry_commentBox";
			this.entry_commentBox.Size = new System.Drawing.Size(250, 176);
			this.entry_commentBox.TabIndex = 0;
			this.entry_commentBox.Text = "Нет данных";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(16, 113);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(289, 205);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Выбранная задача";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Transparent;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(149, 142);
			this.button7.Margin = new System.Windows.Forms.Padding(4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(121, 39);
			this.button7.TabIndex = 10;
			this.button7.Text = "Управление суммой";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(20, 142);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(121, 39);
			this.button4.TabIndex = 10;
			this.button4.Text = "Завершить";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(20, 95);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 39);
			this.button3.TabIndex = 10;
			this.button3.Text = "Вычесть";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(149, 95);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(121, 39);
			this.button6.TabIndex = 9;
			this.button6.Text = "Изменить";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(149, 48);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(121, 39);
			this.button5.TabIndex = 9;
			this.button5.Text = "История";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(20, 48);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 39);
			this.button1.TabIndex = 9;
			this.button1.Text = "Пополнить";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnCreate);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(16, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 93);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Управление";
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(149, 35);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(121, 39);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.Transparent;
			this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreate.ForeColor = System.Drawing.Color.White;
			this.btnCreate.Location = new System.Drawing.Point(20, 35);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(121, 39);
			this.btnCreate.TabIndex = 7;
			this.btnCreate.Text = "Создать";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tab_allEntrys);
			this.tabControl1.Controls.Add(this.tab_payments);
			this.tabControl1.Controls.Add(this.tab_targets);
			this.tabControl1.Controls.Add(this.tab_investments);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(323, 41);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(744, 569);
			this.tabControl1.TabIndex = 9;
			// 
			// tab_allEntrys
			// 
			this.tab_allEntrys.Controls.Add(this.DGV_allEntrys);
			this.tab_allEntrys.Location = new System.Drawing.Point(4, 32);
			this.tab_allEntrys.Name = "tab_allEntrys";
			this.tab_allEntrys.Padding = new System.Windows.Forms.Padding(3);
			this.tab_allEntrys.Size = new System.Drawing.Size(736, 533);
			this.tab_allEntrys.TabIndex = 0;
			this.tab_allEntrys.Text = "Все записи";
			this.tab_allEntrys.UseVisualStyleBackColor = true;
			// 
			// DGV_allEntrys
			// 
			this.DGV_allEntrys.AllowUserToAddRows = false;
			this.DGV_allEntrys.AllowUserToDeleteRows = false;
			this.DGV_allEntrys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_allEntrys.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.DGV_allEntrys.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DGV_allEntrys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_allEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGV_allEntrys.Location = new System.Drawing.Point(3, 3);
			this.DGV_allEntrys.Name = "DGV_allEntrys";
			this.DGV_allEntrys.ReadOnly = true;
			this.DGV_allEntrys.RowTemplate.Height = 24;
			this.DGV_allEntrys.Size = new System.Drawing.Size(730, 527);
			this.DGV_allEntrys.TabIndex = 9;
			// 
			// tab_payments
			// 
			this.tab_payments.Controls.Add(this.label1);
			this.tab_payments.Location = new System.Drawing.Point(4, 32);
			this.tab_payments.Name = "tab_payments";
			this.tab_payments.Padding = new System.Windows.Forms.Padding(3);
			this.tab_payments.Size = new System.Drawing.Size(736, 533);
			this.tab_payments.TabIndex = 1;
			this.tab_payments.Text = "Платежи";
			this.tab_payments.UseVisualStyleBackColor = true;
			// 
			// tab_targets
			// 
			this.tab_targets.Controls.Add(this.label2);
			this.tab_targets.Location = new System.Drawing.Point(4, 32);
			this.tab_targets.Name = "tab_targets";
			this.tab_targets.Size = new System.Drawing.Size(736, 533);
			this.tab_targets.TabIndex = 2;
			this.tab_targets.Text = "Цели";
			this.tab_targets.UseVisualStyleBackColor = true;
			// 
			// tab_investments
			// 
			this.tab_investments.Controls.Add(this.label3);
			this.tab_investments.Location = new System.Drawing.Point(4, 32);
			this.tab_investments.Name = "tab_investments";
			this.tab_investments.Size = new System.Drawing.Size(736, 533);
			this.tab_investments.TabIndex = 3;
			this.tab_investments.Text = "Инвестиции";
			this.tab_investments.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(730, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "только чтение";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(736, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "только чтение";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(736, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "только чтение";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(1067, 610);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.windowTitle);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "FundTracking";
			this.Shown += new System.EventHandler(this.MainFormShown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tab_allEntrys.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_allEntrys)).EndInit();
			this.tab_payments.ResumeLayout(false);
			this.tab_targets.ResumeLayout(false);
			this.tab_investments.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataView_main)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.RichTextBox entry_commentBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button4;
		private System.Data.DataView dataView_main;
		private System.Windows.Forms.TabPage tab_investments;
		private System.Windows.Forms.TabPage tab_targets;
		private System.Windows.Forms.TabPage tab_payments;
		private System.Windows.Forms.TabPage tab_allEntrys;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView DGV_allEntrys;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label windowTitle;
	}
}
