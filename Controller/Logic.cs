using System;
using System.Collections.Generic;
using FundTracking.Data;

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
	}
}
