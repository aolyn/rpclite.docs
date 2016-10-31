Merops Registry Service
==============================

提供了服务提供者信息查询功能，本质上是一个RpcLite服务，契约定义如下：

::

	public interface IRegistryService
	{
		GetServiceInfoResponse GetServiceInfo(GetServiceInfoRequest request);

		Task<GetServiceInfoResponse> GetServiceInfoAsync(GetServiceInfoRequest request);
	}
