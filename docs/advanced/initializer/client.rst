客户端
===============

对于Full .Net和.Net Core仅使用客户端时始化方式相同，都是使用RpcLite.Config.RpcInitializer类中的Initialize方法，常用的有如下两个重载。

::

	public class RpcInitializer
	{
		public static void Initialize(Action<RpcConfigBuilder> builder){}
		
		public static void Initialize(RpcConfig rpcConfig){}
	}

示例::

			RpcInitializer.Initialize(builder => builder
				.UseAppId("10000")
				.UseClient<IProductService>("ProductService"));

RpcInitializer.Initialize()

* 在Full .Net中会默认读取web.config/app.config中的配置。
* 在.Net Core中会读取rpclite.config.json中的配置如果配置文件不存在则使用空配置。