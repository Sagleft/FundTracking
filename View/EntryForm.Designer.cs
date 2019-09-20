namespace FundTracking.View
{
	partial class EntryForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.entry_amount = new System.Windows.Forms.NumericUpDown();
			this.textBox_comment = new System.Windows.Forms.TextBox();
			this.textBox_title = new System.Windows.Forms.TextBox();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.entry_type = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox_deadline = new System.Windows.Forms.CheckBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSaveEntry = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(13, 250);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 39);
			this.label3.TabIndex = 21;
			this.label3.Text = "Тип";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(9, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(298, 28);
			this.label2.TabIndex = 19;
			this.label2.Text = "Комментарий";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(9, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(298, 28);
			this.label1.TabIndex = 20;
			this.label1.Text = "Название";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// entry_amount
			// 
			this.entry_amount.Location = new System.Drawing.Point(13, 75);
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
			this.entry_amount.TabIndex = 24;
			this.entry_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.entry_amount.Value = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			// 
			// textBox_comment
			// 
			this.textBox_comment.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_comment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_comment.Location = new System.Drawing.Point(9, 146);
			this.textBox_comment.Multiline = true;
			this.textBox_comment.Name = "textBox_comment";
			this.textBox_comment.Size = new System.Drawing.Size(298, 91);
			this.textBox_comment.TabIndex = 17;
			// 
			// textBox_title
			// 
			this.textBox_title.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_title.Location = new System.Drawing.Point(9, 75);
			this.textBox_title.Name = "textBox_title";
			this.textBox_title.Size = new System.Drawing.Size(298, 27);
			this.textBox_title.TabIndex = 18;
			this.textBox_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.btnCloseWindow.Location = new System.Drawing.Point(11, 330);
			this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(317, 39);
			this.btnCloseWindow.TabIndex = 25;
			this.btnCloseWindow.Text = "Закрыть окно";
			this.btnCloseWindow.UseVisualStyleBackColor = false;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.entry_type);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox_comment);
			this.groupBox1.Controls.Add(this.textBox_title);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(11, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(317, 310);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Описание";
			// 
			// entry_type
			// 
			this.entry_type.BackColor = System.Drawing.Color.SlateGray;
			this.entry_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.entry_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.entry_type.ForeColor = System.Drawing.Color.White;
			this.entry_type.FormattingEnabled = true;
			this.entry_type.Location = new System.Drawing.Point(77, 253);
			this.entry_type.Name = "entry_type";
			this.entry_type.Size = new System.Drawing.Size(230, 31);
			this.entry_type.TabIndex = 22;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.entry_amount);
			this.groupBox2.Controls.Add(this.checkBox_deadline);
			this.groupBox2.Controls.Add(this.dateTimePicker);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(334, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(345, 310);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Сумма и время";
			// 
			// checkBox_deadline
			// 
			this.checkBox_deadline.Location = new System.Drawing.Point(13, 119);
			this.checkBox_deadline.Name = "checkBox_deadline";
			this.checkBox_deadline.Size = new System.Drawing.Size(326, 40);
			this.checkBox_deadline.TabIndex = 23;
			this.checkBox_deadline.Text = "Задать Deadline";
			this.checkBox_deadline.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(13, 165);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(326, 30);
			this.dateTimePicker.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(9, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(330, 28);
			this.label6.TabIndex = 20;
			this.label6.Text = "Требуемая сумма";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnSaveEntry
			// 
			this.btnSaveEntry.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnSaveEntry.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveEntry.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btnSaveEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnSaveEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnSaveEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveEntry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSaveEntry.ForeColor = System.Drawing.Color.White;
			this.btnSaveEntry.Location = new System.Drawing.Point(334, 330);
			this.btnSaveEntry.Margin = new System.Windows.Forms.Padding(4);
			this.btnSaveEntry.Name = "btnSaveEntry";
			this.btnSaveEntry.Size = new System.Drawing.Size(345, 39);
			this.btnSaveEntry.TabIndex = 26;
			this.btnSaveEntry.Text = "Сохранить";
			this.btnSaveEntry.UseVisualStyleBackColor = false;
			// 
			// EntryForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(694, 385);
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnSaveEntry);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "EntryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавление задачи";
			((System.ComponentModel.ISupportInitialize)(this.entry_amount)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.NumericUpDown entry_amount;
		public System.Windows.Forms.DateTimePicker dateTimePicker;
		public System.Windows.Forms.CheckBox checkBox_deadline;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.ComboBox entry_type;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox textBox_comment;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textBox_title;
		public System.Windows.Forms.Button btnSaveEntry;
	}
}
