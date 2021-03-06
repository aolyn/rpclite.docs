﻿入门教程
===============

  教程中涉及到的Demo源码可从github上下载，`下载地址 <https://github.com/aolyn/rpclite.docs/tree/master/samples/HelloRpcLite>`_

要使用RpcLite提供服务或调用其它服务首先要创建AppHost，创建AppHost需要RpcConfig参数。RpcConfig有两种生成方式：从配置文件读取、通过Fluent风格从ConfigBuilder创建。在本指南中主要通过Fluent风格创建。

.. tip::

后面介绍两种简单的使用方式

* 只创建服务供JavaScript中使用

.. image:: ../_static/service-web-browser.png

* 在客户端中调用服务

.. image:: ../_static/service-client.png

下面的文档会说明在不同平台下如何使用RpcLite。

.. toctree::
  :titlesonly:
  :caption: 默认支持的平台
  :maxdepth: 1

  full-dotnet/index
  netcore/index
