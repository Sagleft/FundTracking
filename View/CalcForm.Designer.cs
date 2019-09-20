/*
 * Сделано в SharpDevelop.
 * Пользователь: SystemShock
 * Дата: 12.08.2019
 * Время: 2:41
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace FundTracking.View
{
	partial class CalcForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.checkBox_targets = new System.Windows.Forms.CheckBox();
			this.checkBox_investments = new System.Windows.Forms.CheckBox();
			this.checkBox_payments = new System.Windows.Forms.CheckBox();
			this.label_result = new System.Windows.Forms.Label();
			this.listBox_calc = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.entry_amount = new System.Windows.Forms.NumericUpDown();
			this.btnDoCalc = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCloseWindow);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 400);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(694, 65);
			this.panel1.TabIndex = 0;
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
			this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCloseWindow.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCloseWindow.ForeColor = System.Drawing.Color.White;
			this.btnCloseWindow.Location = new System.Drawing.Point(495, 13);
			this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(186, 39);
			this.btnCloseWindow.TabIndex = 28;
			this.btnCloseWindow.Text = "Закрыть окно";
			this.btnCloseWindow.UseVisualStyleBackColor = false;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(694, 400);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.checkBox_targets);
			this.tabPage1.Controls.Add(this.checkBox_investments);
			this.tabPage1.Controls.Add(this.checkBox_payments);
			this.tabPage1.Controls.Add(this.label_result);
			this.tabPage1.Controls.Add(this.listBox_calc);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.entry_amount);
			this.tabPage1.Controls.Add(this.btnDoCalc);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(686, 364);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Доступные финансы";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// checkBox_targets
			// 
			this.checkBox_targets.Location = new System.Drawing.Point(447, 188);
			this.checkBox_targets.Name = "checkBox_targets";
			this.checkBox_targets.Size = new System.Drawing.Size(230, 24);
			this.checkBox_targets.TabIndex = 34;
			this.checkBox_targets.Text = "Цели";
			this.checkBox_targets.UseVisualStyleBackColor = true;
			// 
			// checkBox_investments
			// 
			this.checkBox_investments.Checked = true;
			this.checkBox_investments.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_investments.Location = new System.Drawing.Point(447, 248);
			this.checkBox_investments.Name = "checkBox_investments";
			this.checkBox_investments.Size = new System.Drawing.Size(230, 24);
			this.checkBox_investments.TabIndex = 34;
			this.checkBox_investments.Text = "Инвестиции";
			this.checkBox_investments.UseVisualStyleBackColor = true;
			// 
			// checkBox_payments
			// 
			this.checkBox_payments.Location = new System.Drawing.Point(447, 218);
			this.checkBox_payments.Name = "checkBox_payments";
			this.checkBox_payments.Size = new System.Drawing.Size(230, 24);
			this.checkBox_payments.TabIndex = 34;
			this.checkBox_payments.Text = "Платежи";
			this.checkBox_payments.UseVisualStyleBackColor = true;
			// 
			// label_result
			// 
			this.label_result.Location = new System.Drawing.Point(339, 59);
			this.label_result.Name = "label_result";
			this.label_result.Size = new System.Drawing.Size(198, 37);
			this.label_result.TabIndex = 33;
			this.label_result.Text = "-";
			this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listBox_calc
			// 
			this.listBox_calc.FormattingEnabled = true;
			this.listBox_calc.ItemHeight = 23;
			this.listBox_calc.Location = new System.Drawing.Point(19, 178);
			this.listBox_calc.Name = "listBox_calc";
			this.listBox_calc.Size = new System.Drawing.Size(404, 165);
			this.listBox_calc.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(429, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(248, 40);
			this.label4.TabIndex = 31;
			this.label4.Text = "Не учитывать";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(19, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(404, 40);
			this.label2.TabIndex = 31;
			this.label2.Text = "Зарезервированный баланс";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// entry_amount
			// 
			this.entry_amount.Location = new System.Drawing.Point(339, 21);
			this.entry_amount.Maximum = new decimal(new int[] {
									1410065407,
									2,
									0,
									0});
			this.entry_amount.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.entry_amount.Name = "entry_amount";
			this.entry_amount.Size = new System.Drawing.Size(326, 30);
			this.entry_amount.TabIndex = 30;
			this.entry_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.entry_amount.Value = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			// 
			// btnDoCalc
			// 
			this.btnDoCalc.BackColor = System.Drawing.Color.SlateGray;
			this.btnDoCalc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDoCalc.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnDoCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnDoCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnDoCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDoCalc.ForeColor = System.Drawing.Color.White;
			this.btnDoCalc.Location = new System.Drawing.Point(544, 57);
			this.btnDoCalc.Margin = new System.Windows.Forms.Padding(4);
			this.btnDoCalc.Name = "btnDoCalc";
			this.btnDoCalc.Size = new System.Drawing.Size(121, 39);
			this.btnDoCalc.TabIndex = 29;
			this.btnDoCalc.Text = "Расчет";
			this.btnDoCalc.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(19, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(314, 35);
			this.label3.TabIndex = 21;
			this.label3.Text = "Итого свободных";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(19, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(314, 35);
			this.label1.TabIndex = 21;
			this.label1.Text = "Введите ваш доступный баланс";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CalcForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(694, 465);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CalcForm";
			this.Text = "Калькулятор финансов";
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.CheckBox checkBox_payments;
		public System.Windows.Forms.CheckBox checkBox_investments;
		public System.Windows.Forms.CheckBox checkBox_targets;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label_result;
		public System.Windows.Forms.ListBox listBox_calc;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.NumericUpDown entry_amount;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnDoCalc;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Panel panel1;
	}
}
