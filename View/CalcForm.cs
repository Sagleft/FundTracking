using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
//using FundTracking.Data;

namespace FundTracking.View
{
	/// <summary>
	/// Description of CalcForm.
	/// </summary>
	public partial class CalcForm : Form
	{
		public CalcForm()
		{
			InitializeComponent();
		}
		
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
