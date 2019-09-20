/*
 * Сделано в SharpDevelop.
 * Пользователь: SystemShock
 * Дата: 09.08.2019
 * Время: 9:11
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace FundTracking.View
{
	partial class BalanceHistoryForm
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_export_json = new System.Windows.Forms.Button();
			this.btn_export_csv = new System.Windows.Forms.Button();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.dataView = new System.Data.DataView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(794, 465);
			this.dataGridView.TabIndex = 27;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.btn_export_json);
			this.panel2.Controls.Add(this.btn_export_csv);
			this.panel2.Controls.Add(this.btnCloseWindow);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 401);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(794, 64);
			this.panel2.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 39);
			this.label1.TabIndex = 30;
			this.label1.Text = "экспорт";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_export_json
			// 
			this.btn_export_json.BackColor = System.Drawing.Color.Transparent;
			this.btn_export_json.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_export_json.Enabled = false;
			this.btn_export_json.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btn_export_json.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btn_export_json.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_export_json.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_export_json.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_export_json.ForeColor = System.Drawing.Color.White;
			this.btn_export_json.Location = new System.Drawing.Point(171, 14);
			this.btn_export_json.Margin = new System.Windows.Forms.Padding(4);
			this.btn_export_json.Name = "btn_export_json";
			this.btn_export_json.Size = new System.Drawing.Size(68, 39);
			this.btn_export_json.TabIndex = 29;
			this.btn_export_json.Text = "JSON";
			this.btn_export_json.UseVisualStyleBackColor = false;
			// 
			// btn_export_csv
			// 
			this.btn_export_csv.BackColor = System.Drawing.Color.Transparent;
			this.btn_export_csv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_export_csv.Enabled = false;
			this.btn_export_csv.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.btn_export_csv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btn_export_csv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_export_csv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_export_csv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_export_csv.ForeColor = System.Drawing.Color.White;
			this.btn_export_csv.Location = new System.Drawing.Point(106, 14);
			this.btn_export_csv.Margin = new System.Windows.Forms.Padding(4);
			this.btn_export_csv.Name = "btn_export_csv";
			this.btn_export_csv.Size = new System.Drawing.Size(57, 39);
			this.btn_export_csv.TabIndex = 28;
			this.btn_export_csv.Text = "CSV";
			this.btn_export_csv.UseVisualStyleBackColor = false;
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
			this.btnCloseWindow.Location = new System.Drawing.Point(595, 12);
			this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(186, 39);
			this.btnCloseWindow.TabIndex = 27;
			this.btnCloseWindow.Text = "Закрыть окно";
			this.btnCloseWindow.UseVisualStyleBackColor = false;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
			// 
			// BalanceHistoryForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(794, 465);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridView);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "BalanceHistoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "История финансовых операций";
			this.Shown += new System.EventHandler(this.BalanceHistoryFormShown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Data.DataView dataView;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_export_csv;
		private System.Windows.Forms.Button btn_export_json;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnCloseWindow;
	}
}
