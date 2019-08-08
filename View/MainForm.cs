using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using FundTracking.Data;
using FundTracking.View;
using FundTracking.Controller;

namespace FundTracking
{
	public partial class MainForm : Form {
		int x, y;
    	bool s = false;
    	//это тупо или гениально? склоняюсь к первому варианту
    	Logic logic = null;
    	
		public MainForm() {
			InitializeComponent();
			this.SuspendLayout();
			this.KeyPreview = true;
			//перетаскивание за форму
			//this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_Mouse);
	        //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_Mouse);
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
		
		void MainFormShown(object sender, EventArgs e)
		{
			//событие, когда форма была отображена
			this.Refresh();
			this.SuspendLayout();
			//не знаю насколько это нестандартный подход
			this.logic = new Logic();
			//построение таблицы всех записей
			rebuildTable();
			this.ResumeLayout();
		}
		
		void rebuildTable() {
			//вынести мы этот метод куда-то с глаз долой
			List<FundEntry> entrys = logic.getEntrys();
			DataTable dtable = new DataTable("all");
			//столбец ID
			DataColumn idColumn = new DataColumn("№", Type.GetType("System.Int32"));
			idColumn.Unique = true;
			idColumn.AllowDBNull = false;
			idColumn.AutoIncrement = true;
			idColumn.AutoIncrementSeed = 1;
			idColumn.AutoIncrementStep = 1;
			//остальные столбцы
			DataColumn typeColumn     = new DataColumn("Тип", Type.GetType("System.String"));
			DataColumn titleColumn    = new DataColumn("Заголовок", Type.GetType("System.String"));
			DataColumn balanceColumn  = new DataColumn("Баланс", Type.GetType("System.Decimal"));
			DataColumn progressColumn = new DataColumn("Прогресс", Type.GetType("System.Decimal"));
			//добавляем столбцы к таблице
			dtable.Columns.Add(idColumn);       //ID (int)
			dtable.Columns.Add(typeColumn);     //type (string)
			dtable.Columns.Add(titleColumn);    //title (string)
			dtable.Columns.Add(balanceColumn);  //balance (decimal)
			dtable.Columns.Add(progressColumn); //progress (decimal)
			//первичный ключ таблицы - ID
			dtable.PrimaryKey = new DataColumn[] { dtable.Columns[0] };
			//проходим по записям
			for(int i=0; i < entrys.Count; i++) {
				DataRow row = dtable.NewRow();
				string entry_type = entrys[i].type.GetDescription();
				decimal entry_balance  = logic.calcEntryBalance(entrys[i]);
				decimal entry_progress = 0;
				if(entry_progress != 0) {
					entry_progress = (decimal) Math.Round((double) (entry_balance / entrys[i].need_amount), 2);
				}
				row.ItemArray = new object[] {
					i+1,             //ID
					entry_type,      //type
					entrys[i].title, //title
					entry_balance,   //balance
					entry_progress   //progress
				};
				dtable.Rows.Add(row);
				//Debug.Print(entrys[i].title);
			}
			//dtable.Columns[0]
			dataView_main.Table = dtable;
			DGV_allEntrys.DataSource = dataView_main;
			//настройка столбцов
			DGV_allEntrys.Columns[0].Width = 80;  //ID
			DGV_allEntrys.Columns[1].Width = 175; //type
			DGV_allEntrys.Columns[3].Width = 150; //balance
		}
		
		void BtnCreateClick(object sender, EventArgs e)
		{
			//создаем диалоговое окно заполнения данных новой записи
			EntryForm entryForm = new FundTracking.View.EntryForm();
			//событие сохранения записи
			entryForm.btnSaveEntry.Click += (fSender, eSender) =>
			{
				FundEntry entry = new FundEntry();
				entry.title       = entryForm.textBox_title.Text;   //название задачи
				entry.income      = new List<BalanceData>();        //по нулям по умолчанию
				entry.outcome     = new List<BalanceData>();        //по нулям по умолчанию
				entry.need_amount = entryForm.entry_amount.Value;   //сколько необходимо средств
				entry.comment       = entryForm.textBox_comment.Text;
				entry.use_deadline  = entryForm.checkBox_deadline.Checked;
				entry.deadline_date = entryForm.dateTimePicker.Value;
				
				int entry_typeIndex = entryForm.entry_type.SelectedIndex;
				//смотрим, есть ли такой EntryType
				if(Enum.IsDefined(typeof(EntryType), entry_typeIndex)) {
					entry.type = (EntryType) entry_typeIndex;
				} else {
					entry.type = (EntryType) 0;
				}
				//string entry_type_str = entry.type.GetDescription();
				//Debug.Print(entry_type_str);
				//сохранение записи
				logic.addEntry(entry);
				//закрытие формы
				entryForm.Close();
				rebuildTable();
			};
			entryForm.ShowDialog();
		}
		
		/// <summary>
		/// запросить индекс выбранной строки в DataGridView
		/// </summary>
		/// <returns>индекс строки</returns>
		int getSelectedCellIndex() {
			int index = 0;
			DataGridViewSelectedCellCollection selectedCells = DGV_allEntrys.SelectedCells;
			if(selectedCells.Count > 0) {
				DataGridViewCell view_cell = selectedCells[0];
				index = view_cell.RowIndex;
			} else {
				index = -1;
			}
			return index;
		}
		
		bool confirm(string info) {
			DialogResult result = MessageBox.Show(info, "OK", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if(result == DialogResult.OK) {
				return true;
			} else {
				return false;
			}
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			int index = getSelectedCellIndex();
			if(index >= 0 && confirm("Вы действительно желаете удалить выбранное задание?")) {
				logic.deleteEntry(index);
				rebuildTable();
			}
		}
	}
}
