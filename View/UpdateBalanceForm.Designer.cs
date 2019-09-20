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
			this.label3 = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_comment = new System.Windows.Forms.TextBox();
			this.entry_amount = new System.Windows.Forms.NumericUpDown();
			this.entry_sum_direction = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(344, 146);
			this.label3.TabIndex = 36;
			this.label3.Text = "Пополнение - пополнение средств задачи или если инвестиция принесла прибыль.\r\n\r\nВ" +
			"ычет средств - если необходимо перераспределить свои накопления.";
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
			this.btnApply.Location = new System.Drawing.Point(12, 409);
			this.btnApply.Margin = new System.Windows.Forms.Padding(4);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(345, 39);
			this.btnApply.TabIndex = 31;
			this.btnApply.Text = "Применить";
			this.btnApply.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 33);
			this.label2.TabIndex = 32;
			this.label2.Text = "Сумма";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_comment
			// 
			this.textBox_comment.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_comment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_comment.Location = new System.Drawing.Point(12, 288);
			this.textBox_comment.Multiline = true;
			this.textBox_comment.Name = "textBox_comment";
			this.textBox_comment.Size = new System.Drawing.Size(344, 114);
			this.textBox_comment.TabIndex = 37;
			// 
			// entry_amount
			// 
			this.entry_amount.Location = new System.Drawing.Point(187, 55);
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
			this.entry_amount.TabIndex = 34;
			this.entry_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.entry_amount.Value = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			// 
			// entry_sum_direction
			// 
			this.entry_sum_direction.BackColor = System.Drawing.Color.SlateGray;
			this.entry_sum_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.entry_sum_direction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.entry_sum_direction.ForeColor = System.Drawing.Color.White;
			this.entry_sum_direction.FormattingEnabled = true;
			this.entry_sum_direction.Location = new System.Drawing.Point(187, 16);
			this.entry_sum_direction.Name = "entry_sum_direction";
			this.entry_sum_direction.Size = new System.Drawing.Size(170, 31);
			this.entry_sum_direction.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(345, 34);
			this.label4.TabIndex = 38;
			this.label4.Text = "Комментарий к операции";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 33);
			this.label1.TabIndex = 33;
			this.label1.Text = "Направление";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UpdateBalanceForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(372, 462);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_comment);
			this.Controls.Add(this.entry_amount);
			this.Controls.Add(this.entry_sum_direction);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UpdateBalanceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Обновление баланса задачи";
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox_comment;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox entry_sum_direction;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.NumericUpDown entry_amount;
		public System.Windows.Forms.Button btnApply;
	}
}
