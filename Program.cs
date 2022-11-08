using System;

namespace Metalapps_Sales_Automation
{
	public class Driver
	{
		static void Main(string[] args)
		{
			salesdetails obj = new salesdetails();
			Console.WriteLine("Enter sales id ");
			obj.SalesId = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter customer name ");
			obj.CustomerName = Console.ReadLine();

			Console.WriteLine("Enter the number of units sold");
			obj.NoOfUnits = int.Parse(Console.ReadLine());
			metalapps app = new metalapps();
			app.CalculateNetAmount(obj);
			app.AddSalesDetails(obj);
			Console.WriteLine("Sales Bill ");
			Console.WriteLine("***********");
			Console.WriteLine("Sales Id : " + obj.SalesId);
			Console.WriteLine("Customer Name : " + obj.CustomerName);
			Console.WriteLine("Number of Units Sold : " + obj.NoOfUnits);
			Console.WriteLine("Net Amount : " + obj.NetAmount);
		}
	}
}
