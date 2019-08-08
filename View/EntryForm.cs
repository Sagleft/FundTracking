using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using FundTracking.Data;

namespace FundTracking.View
{
	/// <summary>
	/// Description of EntryForm.
	/// </summary>
	public partial class EntryForm : Form
	{
		public EntryForm()
		{
			InitializeComponent();
			//загрузка типов записей
			entry_type.Items.Clear();
			entry_type.Items.AddRange(EnumExtenders.Descriptions((EntryType) 0));
			entry_type.SelectedIndex = 0;
		}
		
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
