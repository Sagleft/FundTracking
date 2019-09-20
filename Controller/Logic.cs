using System;
using System.Collections.Generic;
using FundTracking.Data;
using System.Diagnostics;

namespace FundTracking.Controller
{
	/// <summary>
	/// Description of Logic.
	/// </summary>
	public class Logic
	{
		FileSystemProvider fs;
		DataContainer dataContainer = null;
		
		public Logic()
		{
			this.fs = new FileSystemProvider();
			this.dataContainer = fs.load();
		}
		
		public void addEntry(FundEntry entry) {
			dataContainer.entrys_list.Add(entry);
			fs.save(dataContainer);
		}
		
		/// <summary>
		/// удаление записи через индекс
		/// </summary>
		/// <param name="entry_index">индекс записи</param>
		public void deleteEntry(int entry_index = 0) {
			dataContainer.entrys_list.RemoveAt(entry_index);
			fs.save(dataContainer);
		}
		
		/// <summary>
		/// удаление записи
		/// </summary>
		/// <param name="entry">запись</param>
		public void deleteEntry(FundEntry entry) {
			dataContainer.entrys_list.Remove(entry);
			fs.save(dataContainer);
		}
		
		public decimal calcEntryBalance(FundEntry entry) {
			decimal balance_income  = 0;
			decimal balance_outcome = 0;
			//TOQ: есть решения более быстрые?
			for(int i=0; i < entry.income.Count; i++) {
				balance_income += entry.income[i].amount;
			}
			for(int i=0; i < entry.outcome.Count; i++) {
				balance_outcome += entry.outcome[i].amount;
			}
			return balance_income - balance_outcome;
		}
		
		public List<FundEntry> getEntrys() {
			return dataContainer.entrys_list;
		}
		
		public FundEntry getEntry(int entry_index = 0) {
			return dataContainer.entrys_list[entry_index];
		}
		
		public void addBalanceData(BalanceData bdata, BalanceType btype, int entry_index = 0) {
			//TODO: проверку, не выходит ли индекс за пределы
			bool is_ok = true;
			switch(btype) {
				default:
					is_ok = false;
					break;
				case BalanceType.Income:
					dataContainer.entrys_list[entry_index].income.Add(bdata);
					break;
				case BalanceType.Outcome:
					dataContainer.entrys_list[entry_index].outcome.Add(bdata);
					break;
			}
			if(is_ok) {
				fs.save(dataContainer);
			}
		}
		
		public List<BalanceData> buildFinanceList(Dictionary<EntryType, bool> exclude_types = null) {
			//кажется, нужен refactoring
			List<BalanceData> result_list = new List<BalanceData>();
			//string line = "";
			decimal entry_balance = 0;
			string[] enum_descriptions = EntryType.Payment.Descriptions();
			decimal[] enum_balances = new decimal[enum_descriptions.Length];
			//проход по записям
			for(int i=0; i < dataContainer.entrys_list.Count; i++) {
				FundEntry entry = dataContainer.entrys_list[i];
				entry_balance = this.calcEntryBalance(entry);
				int entry_typeINT = (int)entry.type;
				enum_balances[entry_typeINT] += entry_balance;
			}
			//проход по типам записей
			for(int j=0; j < enum_descriptions.Length; j++) {
				bool can_continue = true;
				if( exclude_types != null ) {
					//exclude_types
					EntryType entry_type = (EntryType) j;
					if(exclude_types[entry_type] == true) {
						//найден тип, который надо исключить
						//Debug.Print("Исключаем тип: " + entry_type.GetDescription());
						can_continue = false;
					}
				}
				if(can_continue) {
					BalanceData bdata = new BalanceData();
					bdata.amount = enum_balances[j];
					bdata.comment = enum_descriptions[j] + ": " + enum_balances[j].ToString() + " д.ед";
					result_list.Add(bdata);
				}
			}
			
			return result_list;
		}
	}
}
