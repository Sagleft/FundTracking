using System;
using System.Collections.Generic;

namespace FundTracking.Data
{
	//interface IComparer
	//{
	//    int Compare(BalanceData data1, BalanceData data2);
	//}
	
	class BalanceDataComparer : IComparer<BalanceData>
	{
	    public int Compare(BalanceData data1, BalanceData data2)
	    {
	    	if (data1.event_date > data2.event_date) {
	    		return 1;
	    	} else if (data1.event_date < data2.event_date) {
	    		return -1;
	    	} else {
	    		return 0;
	    	}
	    }
	}
}
