using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taiwan.Stock.Utility
{
	public class StockDateTime
	{
		public int DayofWeek(DateTime dt)
		{
			DayOfWeek dayofweek = dt.DayOfWeek;
			var week = (int)dayofweek;
			return week;
		}
		public int DayofTime(DateTime dt)
		{
			string place = dt.ToString("hhmm");
			int.TryParse(place, out int time);
			return time;
		}
		public bool StockUtility(DateTime dt)
		{
			int week = DayofWeek(dt);
			int time = DayofTime(dt);
			bool yesno = true;
			return (week > 5 || week < 1 || time < 900 || time > 1330) ? !yesno : yesno;
		}

	}
}

