using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taiwan.Stock.Utility;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var obj = new StockDateTime();
			DateTime dt=new DateTime(2022,11,01,11,11,11);
			bool stock=obj.StockUtility(dt);
			Console.WriteLine(stock);
		}
	}
}
