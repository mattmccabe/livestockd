using System;
using BarnMg.ServiceModel;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.ServiceHost;
using BarnMg.Api;

namespace BarnMg.ServiceInterface
{
	public class WaterService:IService
	{
		private BarnLogApi _api;

		public WaterService ()
		{
			_api = new BarnLogApi ();
		}

		public List<WaterLogDto> Get(WaterList request)
		{
			return _api.GetWaterLogs (request.BarnId, request.CycleId);
		}

		public WaterLogDto Get(WaterLog request)
		{
			return _api.Read (request.Id);
		}

		public void Post(CreateWaterLog request)
		{
			_api.Create (request);
		}

		public void Put(UpdateWaterLog request)
		{
			_api.Update (request);
		}
	}
}

