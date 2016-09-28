using System;
using RpcLite.AspNetCore;
using RpcLite.Client;

namespace HelloRpcLiteClientCore
{
	public class Program
	{
		public static void Main(string[] args)
		{
			RpcInitializer.Initialize(builder => builder
					.UseClient<IProductService>()
			);

			var serviceAddress = "http://localhost:11651/api/service/";
			var client = ClientFactory.GetInstance<IProductService>(serviceAddress);

			try
			{
				var dateTimeString = client.GetDateTimeString();
				Console.WriteLine("DateTime now from service is " + dateTimeString);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			Console.ReadLine();
		}
	}
}