﻿治理系统
===============

.. image:: ../_static/rpclist-registry.png

Registry主要是解决服务端与客户端的耦合问题，可以把服务地址直接写到代码或配置文件中。在这种模式下如果服务端要迁移客户端必须更着修改。如果把服务地址存在地址服务器中，客户端的服务地址是从地址服务器（治理系统）中动态读取，在作服务迁移时客户端就不需要修改只需要修改治理系统中相关服务的地址即可。

在有的系统中可以进一步优化，治理系统中各服务的地址不需要手动配置而是服务在启动时自动注册到治理系统中。RpcLite中Registry可扩展，用户可以根据需要自定义，在后面的章节会详情介绍自定义方式。