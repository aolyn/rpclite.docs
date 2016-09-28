using System;

namespace HelloRpcLiteServiceCore
{
	public class ProductService : IProductService
	{
		public string GetDateTimeString()
		{
			return DateTime.Now.ToString();
		}
	}
}