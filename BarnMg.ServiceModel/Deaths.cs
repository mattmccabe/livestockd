using System;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace BarnMg.ServiceModel
{
	[Route("/barns/{barnId}/deaths", "GET")]
	public class BarnDeaths:DeathDto
	{
		public int barnId { get; set; }
	}

}

