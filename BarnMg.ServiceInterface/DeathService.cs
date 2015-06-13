using System;
using System.Collections.Generic;
using BarnMg.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace BarnMg.ServiceInterface
{
	public class DeathService:IService
	{
		public DeathService ()
		{
		}

		public List<DeathDto> Get(BarnDeaths request)
		{
			var result = new List<DeathDto> ();

			return result;
		}
	}
}

