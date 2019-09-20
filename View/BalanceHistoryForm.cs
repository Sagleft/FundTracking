using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
//using System.ComponentModel;
using FundTracking.Data;

namespace FundTracking.View
{
	/// <summary>
	/// Description of BalanceHistoryForm.
	/// </summary>
	public partial class BalanceHistoryForm : Form
	{
		public FundEntry entry;
		public BalanceHistoryForm(FundEntry new_entry)
		{
			InitializeComponent();
			this.entry = new_entry;
		}
		
		public void rebuildTable() {
			DataTable dtable = new DataTable("history");
			//столбец ID
			DataColumn idColumn = new DataColumn("№", Type.GetType("System.Int32"));
			idColumn.Unique = true;
			idColumn.AllowDBNull = false;
			idColumn.AutoIncrement = true;
			idColumn.AutoIncrementSeed = 1;
			idColumn.AutoIncrementStep = 1;
			//остальные столбцы
			DataColumn typeColumn   = new DataColumn("Тип", Type.GetType("System.String"));
			DataColumn amountColumn = new DataColumn("Сумма, д.ед", Type.GetType("System.Decimal"));
			DataColumn dateColumn   = new DataColumn("Дата", Type.GetType("System.DateTime"));
			//добавляем столбцы к таблице
			dtable.Columns.Add(idColumn);     //ID (int)
			dtable.Columns.Add(typeColumn);   //type (string)
			dtable.Columns.Add(amountColumn); //amount (decimal)
			dtable.Columns.Add(dateColumn);   //date (DateTime)
			//первичный ключ
			dtable.PrimaryKey = new DataColumn[] { dtable.Columns[0] };
			
			//получение записей
			//BalanceData[] arr_income  = entry.income.ToArray();
			//BalanceData[] arr_outcome = entry.outcome.ToArray();
			//int bdata_count = arr_income.Length + arr_outcome.Length;
			//объединяем записи "пополнение" и "вычет"
			//BalanceData[] arr_history = arr_income.Union(arr_outcome).ToArray();
			//List<BalanceData> list_history = list_income;
			//сортировка по дате
			//Array.Sort(arr_history, BalanceDataComparer);
			
			List<BalanceData> list_income  = entry.income;
			List<BalanceData> list_outcome = entry.outcome;
			List<BalanceData> list_history = list_income.Union(list_outcome).ToList();
			//arr_income
			list_history.Sort(new BalanceDataComparer());
			
			//проходим по записям
			for(int i=0; i < list_history.Count; i++) {
				DataRow row = dtable.NewRow();
				string entry_type = list_history[i].type.GetDescription();
				row.ItemArray = new object[] {
					i+1,             //ID
					entry_type,      //type
					list_history[i].amount,    //amount
					list_history[i].event_date //date
				};
				dtable.Rows.Add(row);
			}
			dataView.Table = dtable;
			dataGridView.DataSource = dataView;
		}
		
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BalanceHistoryFormShown(object sender, EventArgs e)
		{
			rebuildTable();
		}
	}
}
