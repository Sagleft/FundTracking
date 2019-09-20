using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
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
			//DGV_allEntrys.dou
			SetDoubleBuffered(DGV_allEntrys);
			//построение таблицы всех записей
			rebuildTable();
			this.ResumeLayout();
		}
		
		public static void SetDoubleBuffered(Control control)
		{
			// set instance non-public property with name "DoubleBuffered" to true
			typeof(Control).InvokeMember("DoubleBuffered",
			BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
			null, control, new object[] { true });
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
			DataColumn balanceColumn  = new DataColumn("Баланс, д.ед", Type.GetType("System.Decimal"));
			DataColumn progressColumn = new DataColumn("Прогресс, %", Type.GetType("System.Decimal"));
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
				if(entry_balance != 0) {
					entry_progress = (decimal) Math.Round((double) (100 * entry_balance / entrys[i].need_amount), 2);
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
				if(entryForm.textBox_title.Text == "") {
					alert("Необходимо заполнить заголовок записи");
				} else {
					FundEntry entry = new FundEntry();
					entry.title       = entryForm.textBox_title.Text;   //название задачи
					entry.income      = new List<BalanceData>();        //по нулям по умолчанию
					entry.outcome     = new List<BalanceData>();        //по нулям по умолчанию
					entry.need_amount = entryForm.entry_amount.Value;   //сколько необходимо средств
					entry.comment       = entryForm.textBox_comment.Text;
					entry.use_deadline  = entryForm.checkBox_deadline.Checked;
					entry.deadline_date = entryForm.dateTimePicker.Value;
					
					int entry_typeIndex = entryForm.entry_type.SelectedIndex;
					if(entry_typeIndex == -1) {
						//тип задания не был выбран
						entry_typeIndex = 0; //используем значение по умолчанию
					}
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
				}
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
		
		void alert(string info) {
			MessageBox.Show(info, "Уведомление", MessageBoxButtons.OK);
		}
		
		bool confirm(string info) {
			DialogResult result = MessageBox.Show(info, "Требуется подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
		
		void BtnArchivateClick(object sender, EventArgs e)
		{
			if(confirm("Архивировать данную запись?")) {
				//TODO: 
			}
		}
		
		void openBalanceUpdateForm(BalanceType btype, int entry_index = 0) {
			UpdateBalanceForm balance_form = new UpdateBalanceForm();
			//пополнение
			balance_form.entry_sum_direction.SelectedIndex = (int) btype;
			balance_form.btnApply.Click += (fSender, eSender) =>
			{
				decimal bdata_amount = balance_form.entry_amount.Value;
				FundEntry entry = logic.getEntry(entry_index);
				decimal entry_balance = logic.calcEntryBalance(entry);
				bool can_continue = true;
				
				//если вычет средств, то проверяем баланс
				if(btype == BalanceType.Outcome && bdata_amount > entry_balance) {
					//запрашивается вычет баланса больше, чем есть
					can_continue = false;
					alert("Вы пытаетесь вычесть баланса больше, чем доступно в задаче");
				}
				
				if(can_continue) {
					BalanceData bdata = new BalanceData();
					bdata.amount = bdata_amount;
					bdata.comment = balance_form.textBox_comment.Text;
					bdata.type = btype;
					logic.addBalanceData(bdata, btype, entry_index);
					balance_form.Close();
					rebuildTable();
				}
			};
			balance_form.ShowDialog();
		}
		
		void BtnSumPlusClick(object sender, EventArgs e)
		{
			int entry_index = getSelectedCellIndex();
			if(entry_index >= 0) {
				openBalanceUpdateForm(BalanceType.Income, entry_index);
			}
		}
		
		void BtnSumMinusClick(object sender, EventArgs e)
		{
			int entry_index = getSelectedCellIndex();
			if(entry_index >= 0) {
				openBalanceUpdateForm(BalanceType.Outcome, entry_index);
			}
		}
		
		void BtnEntryHistoryClick(object sender, EventArgs e)
		{
			int entry_index = getSelectedCellIndex();
			if(entry_index >= 0) {
				FundEntry entry = logic.getEntry(entry_index);
				BalanceHistoryForm history_form = new BalanceHistoryForm(entry);
				history_form.ShowDialog();
			}
		}
		
		void BtnCalcClick(object sender, EventArgs e)
		{
			CalcForm calc_form = new CalcForm();
			calc_form.btnDoCalc.Click += (fSender, eSender) => {
				//alert("test");
				calc_form.listBox_calc.Items.Clear();
				//строим список элементов, которые не учитываем
				Dictionary<EntryType, bool> exclude_types = new Dictionary<EntryType, bool>();
				//TOQ: вынести что-то вроде этого в отдельный метод EnumsExtender
				exclude_types.Add(EntryType.Target, calc_form.checkBox_targets.Checked);
				exclude_types.Add(EntryType.Payment, calc_form.checkBox_payments.Checked);
				exclude_types.Add(EntryType.Investment, calc_form.checkBox_investments.Checked);
				//Debug.Print(exclude_types.ToString());
				List<BalanceData> bdata_list = logic.buildFinanceList(exclude_types);
				decimal bdata_sum = 0;
				for(int i=0; i < bdata_list.Count; i++) {
					bdata_sum += bdata_list[i].amount;
					calc_form.listBox_calc.Items.Add(bdata_list[i].comment);
				}
				//calc_form.listBox_calc.Items.AddRange(
				//получаем число свободных средств
				decimal free_value = calc_form.entry_amount.Value - bdata_sum;
				calc_form.label_result.Text = Math.Round(free_value, 2).ToString();
			};
			calc_form.ShowDialog();
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			
		}
		
		void DGV_allEntrysCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//клик по ячейке таблицы
			int entry_index = getSelectedCellIndex();
			if(entry_index >= 0) {
				FundEntry entry = logic.getEntry(entry_index);
				string entry_comment = entry.comment;
				if(entry_comment == "") {
					entry_comment = "Нет комментария";
				}
				alert("Комментарий: " + entry_comment + "\n\nОсновная сумма: " + entry.need_amount.ToString() + " д.ед");
			}
		}
	}
}
