/*
 * Сделано в SharpDevelop.
 * Пользователь: SystemShock
 * Дата: 07.08.2019
 * Время: 3:14
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace FundTracking.View
{
	partial class UpdateBalanceForm
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
			this.btnApply = new System.Windows.Forms.Button();
			this.entry_amount = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.entry_type = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).BeginInit();
			this.SuspendLayout();
			// 
			// btnApply
			// 
			this.btnApply.BackColor = System.Drawing.Color.Transparent;
			this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnApply.ForeColor = System.Drawing.Color.White;
			this.btnApply.Location = new System.Drawing.Point(13, 286);
			this.btnApply.Margin = new System.Windows.Forms.Padding(4);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(345, 39);
			this.btnApply.TabIndex = 12;
			this.btnApply.Text = "Применить";
			this.btnApply.UseVisualStyleBackColor = false;
			// 
			// entry_amount
			// 
			this.entry_amount.Location = new System.Drawing.Point(189, 59);
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
			this.entry_amount.Size = new System.Drawing.Size(169, 30);
			this.entry_amount.TabIndex = 26;
			this.entry_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.entry_amount.Value = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 33);
			this.label1.TabIndex = 25;
			this.label1.Text = "Направление";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// entry_type
			// 
			this.entry_type.BackColor = System.Drawing.Color.SlateGray;
			this.entry_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.entry_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.entry_type.ForeColor = System.Drawing.Color.White;
			this.entry_type.FormattingEnabled = true;
			this.entry_type.Items.AddRange(new object[] {
									"Пополнение",
									"Вычет средств"});
			this.entry_type.Location = new System.Drawing.Point(189, 20);
			this.entry_type.Name = "entry_type";
			this.entry_type.Size = new System.Drawing.Size(170, 31);
			this.entry_type.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(14, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 33);
			this.label2.TabIndex = 25;
			this.label2.Text = "Сумма";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(14, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(344, 130);
			this.label3.TabIndex = 28;
			this.label3.Text = "Пополнение - если инвестиция принесла прибыль.\r\n\r\nВычет средств - если необходимо" +
			" перераспределить свои накопления.";
			// 
			// UpdateBalanceForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(371, 338);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.entry_type);
			this.Controls.Add(this.entry_amount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnApply);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UpdateBalanceForm";
			this.Text = "Обновление баланса";
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox entry_type;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.NumericUpDown entry_amount;
		private System.Windows.Forms.Button btnApply;
	}
}
