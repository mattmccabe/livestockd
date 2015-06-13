using System;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace BarnMg.ServiceModel
{
	[Route("/barns/{barnId}/water", "GET")]
	public class BarnWater:WaterDto
	{

	}

}

