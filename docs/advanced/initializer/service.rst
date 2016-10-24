Full .Net 服务端
==============================

配置方式与客户端一样。只是需要在web.config中添加RpcLiteHttpModule

初始化代码一般可写在Global.asax.cs的Application_Start中，如下示例：

::

	using System;
	using RpcLite.AspNet;
	using ServiceTest.ServiceImpl;
	
	namespace ServiceTest.WebHost
	{
		public class Global : System.Web.HttpApplication
		{
			protected void Application_Start(object sender, EventArgs e)
			{
				RpcInitializer.Initialize(builder => builder
						.UseService<ProductService>("ProductService", "api/service/")
						.UseService<TestService>("ProductService", "api/test/")
						.UseServicePaths("api/")
				);
	}
	
web.config
::

	<?xml version="1.0" encoding="utf-8"?>
	<configuration>
		<system.webServer>
			<modules>
				<add name="RpcLite" type="RpcLite.Service.RpcHttpModule, RpcLite.NetFx" />
			</modules>
		</system.webServer>
	</configuration>