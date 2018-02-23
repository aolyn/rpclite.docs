Create Service
=========================================================

.. tip::
  | on .Net Core only support Host in ASP.NET Core now
  | except initialization others is the same on .Net Core and full .Net

Steps sumary：

* Create Web Application project
* Add reference to RpcLite
* Create service contract interface
* Create service class by implement contract interface
* Initialize RpcLite in Startup.cs

Create Web Application project
------------------------------------------------------

* Open Visual Studio 2015/2017
* Open Menu File ‣ New ‣ Project...
* Select Templates ‣ Visual C# ‣ .Net Core
* Ensure Framework is .NET Framework 4.5 or above
* Select Project Template: ASP.NET Core Web Application (.Net Core)
* Fill project name with HelloRpcLiteServiceCore, and click Ok
* Select Empty and click Ok


Add reference to RpcLite
-------------------------

.. tip::
  | There are many methods: downoad dll and add reference, use NuGet, it's simple to use NuGet. in this documentation we use NuGet
  | Two methods when use NuGet: GUI, Command Line

*Command Line*

* Open in menu Tools ‣ NuGet Package Manager ‣ Package Manager Console
* Run Install-Package RpcLite.AspNetCore

*GUI*

* In Solution Explorer right click HelloRpcLite, select Manage NuGet Packages...
* In NuGet Page select Browse Tab page, then search RpcLite.AspNetCore
* Install RpcLite in search result

Create service contract interface
--------------------------------------------

* Create new class file IProductService.cs
* Replace content with

.. includesamplefile:: ../../../samples/HelloRpcLite/src/HelloRpcLiteServiceCore/IProductService.cs
        :language: c#
        :linenos:

Create service class by implement contract interface
------------------------------------------------------------

* Create new class file ProductService.cs
* Replace content with

.. includesamplefile:: ../../../samples/HelloRpcLite/src/HelloRpcLiteServiceCore/ProductService.cs
        :language: c#
        :linenos:

Initialize RpcLite in Startup.cs
------------------------------------------------------------

Add initialize code to Configure function

::

	app.UseRpcLite(builder => builder
			.UseService<ProductService>("ProductService", "api/service/")
	);
	
if MVC(Routing) not used, Routing service must be added in ConfigureServices function.
::

	services.AddRouting();

Full code of Startup.cs

.. includesamplefile:: ../../../samples/HelloRpcLite/src/HelloRpcLiteServiceCore/Startup.cs
        :language: c#
        :linenos:

*Remarks*

* UseService<ProductService>("ProductService", "api/service/") used to add a service
* Generic argument ProductService is the Service Implementation Class
* First argument "ProductService" specific service name
* "api/service/" is service path related to current WebApplication, for example WebApplication address is http://localhost:8080, then service address is http://localhost:8080/api/service/

Run
-----------------------------

| Until now service finished, then run to view result.

* Press F5 to run WebApplication, and visit http://localhost:5000 to WebBrowser
* Visit http://localhost:5000/api/service/ to view Service info: function list
* Visit http://localhost:5000/api/service/GetDateTimeString invoke GetDateTimeString function to view service DateTime.Now

::

  Service Name: ProductService
  Actions:
  String GetDateTimeString();
