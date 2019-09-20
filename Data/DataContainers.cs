using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace FundTracking.Data
{
	public class DataContainer {
		public const string format = "FundTrackingFile"; //.ftf
		public int version_code    = 1;
		public List<FundEntry> entrys_list = null;
	}
	
	/// <summary>
	/// <param name="Target">цель</param>
	/// <param name="Payment">платеж</param>
	/// <param name="Investment">инвестиция</param>
	/// </summary>
	public enum EntryType: int {
		[Description("Цель")]
		Target = 0,
		
		[Description("Платеж")]
		Payment,
		
		[Description("Инвестиция")]
		Investment
	}
	
	public enum BalanceType: int {
		[Description("Пополнение")]
		Income,
		
		[Description("Вычет")]
		Outcome
	}
	
	/// <summary>
	/// <param name="title">название</param>
	/// <param name="need_amount">сумма, денежных единиц</param>
	/// <param name="comment">комментарий к задаче</param>
	/// <param name="income">пополнения задачи</param>
	/// <param name="outcome">вычет баланса</param>
	/// </summary>
	public class FundEntry {
		public EntryType type        = EntryType.Target;
		public string title          = "";
		public decimal need_amount   = 0;
		public string comment        = "";
		public bool use_deadline      = false;
		public DateTime deadline_date = DateTime.Now;
		public List<BalanceData> income  = null;
		public List<BalanceData> outcome = null;
	}
	
	public class BalanceData {
		public decimal amount = 0;
		public string comment = "";
		public BalanceType type = BalanceType.Income;
		public DateTime event_date = DateTime.Now;
	}
}
