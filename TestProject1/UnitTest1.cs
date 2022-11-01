using System.Globalization;
using Taiwan.Stock.Utility;

namespace TestProject1
{
	public class Tests:Exception
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1_判斷一到五營業日()
		{
			var obj = new StockDateTime();
			DateTime test=new DateTime(2022,10,29,11,15,00);
			var result=obj.StockUtility(test);
			Assert.AreEqual(false, result); ;
		}
		[Test]
		public void Test2_判斷正確交易時間()
		{
			var obj = new StockDateTime();
			DateTime test = new DateTime(2022, 10, 27, 11, 15, 00);
			var result = obj.StockUtility(test);
			Assert.AreEqual(true, result);
		}

		[Test]
		public void Test2_日期對_判斷交易時間()
		{
			var obj = new StockDateTime();
			DateTime test = new DateTime(2022, 10, 27, 15, 15, 00);
			var result = obj.StockUtility(test);
			Assert.AreEqual(false, result);
		}
	}
}