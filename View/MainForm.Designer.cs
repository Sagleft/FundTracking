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
			this.entry_deadlineInfo = new System.Windows.Forms.Label();
			this.entry_needAmount = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.entry_commentBox = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCalc = new System.Windows.Forms.Button();
			this.btnArchivate = new System.Windows.Forms.Button();
			this.btnSumMinus = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnEntryHistory = new System.Windows.Forms.Button();
			this.btnSumPlus = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_allEntrys = new System.Windows.Forms.TabPage();
			this.DGV_allEntrys = new System.Windows.Forms.DataGridView();
			this.tab_payments = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.tab_targets = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.tab_investments = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.tab_archive = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.dataView_main = new System.Data.DataView();
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
			this.tab_archive.SuspendLayout();
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
			this.groupBox3.Controls.Add(this.entry_deadlineInfo);
			this.groupBox3.Controls.Add(this.entry_needAmount);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
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
			// entry_deadlineInfo
			// 
			this.entry_deadlineInfo.Location = new System.Drawing.Point(20, 116);
			this.entry_deadlineInfo.Name = "entry_deadlineInfo";
			this.entry_deadlineInfo.Size = new System.Drawing.Size(250, 30);
			this.entry_deadlineInfo.TabIndex = 2;
			this.entry_deadlineInfo.Text = "-";
			this.entry_deadlineInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// entry_needAmount
			// 
			this.entry_needAmount.Location = new System.Drawing.Point(20, 64);
			this.entry_needAmount.Name = "entry_needAmount";
			this.entry_needAmount.Size = new System.Drawing.Size(250, 23);
			this.entry_needAmount.TabIndex = 2;
			this.entry_needAmount.Text = "-";
			this.entry_needAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(20, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(250, 29);
			this.label5.TabIndex = 1;
			this.label5.Text = "Deadline";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(250, 29);
			this.label4.TabIndex = 1;
			this.label4.Text = "Требуемая сумма";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// entry_commentBox
			// 
			this.entry_commentBox.BackColor = System.Drawing.Color.SlateGray;
			this.entry_commentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.entry_commentBox.ForeColor = System.Drawing.Color.White;
			this.entry_commentBox.Location = new System.Drawing.Point(20, 149);
			this.entry_commentBox.Name = "entry_commentBox";
			this.entry_commentBox.Size = new System.Drawing.Size(250, 65);
			this.entry_commentBox.TabIndex = 0;
			this.entry_commentBox.Text = "Нет комментария";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCalc);
			this.groupBox2.Controls.Add(this.btnArchivate);
			this.groupBox2.Controls.Add(this.btnSumMinus);
			this.groupBox2.Controls.Add(this.btnEdit);
			this.groupBox2.Controls.Add(this.btnEntryHistory);
			this.groupBox2.Controls.Add(this.btnSumPlus);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(16, 113);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(289, 205);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Выбранная задача";
			// 
			// btnCalc
			// 
			this.btnCalc.BackColor = System.Drawing.Color.Transparent;
			this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCalc.ForeColor = System.Drawing.Color.White;
			this.btnCalc.Location = new System.Drawing.Point(149, 142);
			this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(121, 39);
			this.btnCalc.TabIndex = 10;
			this.btnCalc.Text = "Калькулятор";
			this.btnCalc.UseVisualStyleBackColor = false;
			this.btnCalc.Click += new System.EventHandler(this.BtnCalcClick);
			// 
			// btnArchivate
			// 
			this.btnArchivate.BackColor = System.Drawing.Color.Transparent;
			this.btnArchivate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnArchivate.Enabled = false;
			this.btnArchivate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnArchivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnArchivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnArchivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnArchivate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnArchivate.ForeColor = System.Drawing.Color.White;
			this.btnArchivate.Location = new System.Drawing.Point(20, 142);
			this.btnArchivate.Margin = new System.Windows.Forms.Padding(4);
			this.btnArchivate.Name = "btnArchivate";
			this.btnArchivate.Size = new System.Drawing.Size(121, 39);
			this.btnArchivate.TabIndex = 10;
			this.btnArchivate.Text = "Завершить";
			this.btnArchivate.UseVisualStyleBackColor = false;
			this.btnArchivate.Click += new System.EventHandler(this.BtnArchivateClick);
			// 
			// btnSumMinus
			// 
			this.btnSumMinus.BackColor = System.Drawing.Color.Transparent;
			this.btnSumMinus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSumMinus.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnSumMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnSumMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnSumMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSumMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSumMinus.ForeColor = System.Drawing.Color.White;
			this.btnSumMinus.Location = new System.Drawing.Point(20, 95);
			this.btnSumMinus.Margin = new System.Windows.Forms.Padding(4);
			this.btnSumMinus.Name = "btnSumMinus";
			this.btnSumMinus.Size = new System.Drawing.Size(121, 39);
			this.btnSumMinus.TabIndex = 10;
			this.btnSumMinus.Text = "Вычесть";
			this.btnSumMinus.UseVisualStyleBackColor = false;
			this.btnSumMinus.Click += new System.EventHandler(this.BtnSumMinusClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Transparent;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Location = new System.Drawing.Point(149, 95);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(121, 39);
			this.btnEdit.TabIndex = 9;
			this.btnEdit.Text = "Изменить";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnEntryHistory
			// 
			this.btnEntryHistory.BackColor = System.Drawing.Color.Transparent;
			this.btnEntryHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEntryHistory.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnEntryHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnEntryHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnEntryHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntryHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEntryHistory.ForeColor = System.Drawing.Color.White;
			this.btnEntryHistory.Location = new System.Drawing.Point(149, 48);
			this.btnEntryHistory.Margin = new System.Windows.Forms.Padding(4);
			this.btnEntryHistory.Name = "btnEntryHistory";
			this.btnEntryHistory.Size = new System.Drawing.Size(121, 39);
			this.btnEntryHistory.TabIndex = 9;
			this.btnEntryHistory.Text = "История";
			this.btnEntryHistory.UseVisualStyleBackColor = false;
			this.btnEntryHistory.Click += new System.EventHandler(this.BtnEntryHistoryClick);
			// 
			// btnSumPlus
			// 
			this.btnSumPlus.BackColor = System.Drawing.Color.Transparent;
			this.btnSumPlus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSumPlus.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnSumPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnSumPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnSumPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSumPlus.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnSumPlus.ForeColor = System.Drawing.Color.White;
			this.btnSumPlus.Location = new System.Drawing.Point(20, 48);
			this.btnSumPlus.Margin = new System.Windows.Forms.Padding(4);
			this.btnSumPlus.Name = "btnSumPlus";
			this.btnSumPlus.Size = new System.Drawing.Size(121, 39);
			this.btnSumPlus.TabIndex = 9;
			this.btnSumPlus.Text = "Пополнить";
			this.btnSumPlus.UseVisualStyleBackColor = false;
			this.btnSumPlus.Click += new System.EventHandler(this.BtnSumPlusClick);
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
			this.tabControl1.Controls.Add(this.tab_archive);
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
			this.DGV_allEntrys.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_allEntrysCellMouseDoubleClick);
			// 
			// tab_payments
			// 
			this.tab_payments.Controls.Add(this.label1);
			this.tab_payments.Location = new System.Drawing.Point(4, 25);
			this.tab_payments.Name = "tab_payments";
			this.tab_payments.Padding = new System.Windows.Forms.Padding(3);
			this.tab_payments.Size = new System.Drawing.Size(736, 540);
			this.tab_payments.TabIndex = 1;
			this.tab_payments.Text = "Платежи";
			this.tab_payments.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(730, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "только чтение";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tab_targets
			// 
			this.tab_targets.Controls.Add(this.label2);
			this.tab_targets.Location = new System.Drawing.Point(4, 25);
			this.tab_targets.Name = "tab_targets";
			this.tab_targets.Size = new System.Drawing.Size(736, 540);
			this.tab_targets.TabIndex = 2;
			this.tab_targets.Text = "Цели";
			this.tab_targets.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(736, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "только чтение";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tab_investments
			// 
			this.tab_investments.Controls.Add(this.label3);
			this.tab_investments.Location = new System.Drawing.Point(4, 25);
			this.tab_investments.Name = "tab_investments";
			this.tab_investments.Size = new System.Drawing.Size(736, 540);
			this.tab_investments.TabIndex = 3;
			this.tab_investments.Text = "Инвестиции";
			this.tab_investments.UseVisualStyleBackColor = true;
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
			// tab_archive
			// 
			this.tab_archive.Controls.Add(this.label6);
			this.tab_archive.Location = new System.Drawing.Point(4, 25);
			this.tab_archive.Name = "tab_archive";
			this.tab_archive.Size = new System.Drawing.Size(736, 540);
			this.tab_archive.TabIndex = 4;
			this.tab_archive.Text = "Архив";
			this.tab_archive.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(736, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "только чтение";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.tab_archive.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataView_main)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tab_archive;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label entry_deadlineInfo;
		private System.Windows.Forms.Label entry_needAmount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnEntryHistory;
		private System.Windows.Forms.RichTextBox entry_commentBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnArchivate;
		private System.Data.DataView dataView_main;
		private System.Windows.Forms.TabPage tab_investments;
		private System.Windows.Forms.TabPage tab_targets;
		private System.Windows.Forms.TabPage tab_payments;
		private System.Windows.Forms.TabPage tab_allEntrys;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSumPlus;
		private System.Windows.Forms.Button btnSumMinus;
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
