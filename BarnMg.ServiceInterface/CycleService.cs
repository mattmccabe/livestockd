using System;
using System.Collections.Generic;
using ServiceStack;
using BarnMg.ServiceModel;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.Cors;
using BarnMg.Api;

namespace BarnMg.ServiceInterface
{
	public class CycleService:IService
	{
		private CycleApi _api;

		public CycleService ()
		{
			_api = new CycleApi ();
		}


		public List<BarnCycleDto> Get(BarnCycleList requestDto)
		{
			return _api.GetCyclesByBarn(requestDto.BarnId);
		}

		public BarnCycleDto Get(BarnCycle cycle)
		{
			return _api.Read (cycle.Id);
		}
			
		public void Put(UpdateCycle cycle)
		{
			_api.Update (cycle);
		}
			
		public void Post(CreateCycle cycle)
		{
			_api.Create (cycle);
		}
	}

}

