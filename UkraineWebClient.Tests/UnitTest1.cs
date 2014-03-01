using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UkraineWebClient.Models;
using System.Linq;
namespace UkraineWebClient.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var ctx = new DiscountsContext();
			ctx.Database.Log = Console.WriteLine;
			var res = ctx.AreaShops;
			foreach (var item in res)
			{
				Console.WriteLine("{0}-{1}-{2}", item.AreaID, item.ID, item.ShopID);
			}
		}
	}
}
