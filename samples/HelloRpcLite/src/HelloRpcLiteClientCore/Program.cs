﻿using System;
using RpcLite.Client;
using RpcLite.Config;

namespace HelloRpcLiteClientCore
{
	public class Program
	{
		public static void Main(string[] args)
		{
			RpcInitializer.Initialize(builder => builder
					.UseClient<IProductService>("ProductService")
			);

			var serviceAddress = "http://localhost:5000/api/service/";
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