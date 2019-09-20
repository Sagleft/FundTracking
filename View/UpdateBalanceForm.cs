using System;
using System.Drawing;
using System.Windows.Forms;
using FundTracking.Data;

namespace FundTracking.View
{
	/// <summary>
	/// Форма пополнения / вычетания средств задачи
	/// </summary>
	public partial class UpdateBalanceForm : Form
	{
		public UpdateBalanceForm()
		{
			InitializeComponent();
			entry_sum_direction.Items.Clear();
			entry_sum_direction.Items.AddRange(EnumExtenders.Descriptions((BalanceType) 0));
			entry_sum_direction.SelectedIndex = 0;
		}
		
		void BtnApplyClick(object sender, EventArgs e)
		{
			//
		}
	}
}
