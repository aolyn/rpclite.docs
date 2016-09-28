using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloRpcLiteServiceCore
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRouting();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			//config RpcLite just one statement
			app.UseRpcLite(builder => builder
					.UseService<ProductService>("ProductService", "api/service/")
					.UseServicePaths("api/")
			);

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.Run(async (context) => { await context.Response.WriteAsync("Hello World!"); });
		}
	}
}