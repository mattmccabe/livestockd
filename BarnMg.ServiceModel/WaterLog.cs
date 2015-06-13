using System;
using ServiceStack;
using ServiceStack.ServiceHost;


namespace BarnMg.ServiceModel
{

	[Route("/barns/{BarnId}/cycles/{CycleId}/water", "GET", Summary="Get all water log entries")]
	public class WaterList:WaterLogDto
	{
	
	}
		
	[Route("/barns/{BarnId}/cycles/{CycleId}/water/{Id}", "GET", Summary="Get a single water log entry")]
	public class WaterLog:WaterLogDto
	{

	}

	[Route("/barns/{BarnId}/cycles/{CycleId}/water", "POST", Summary="Create a new water reading entry")]
	public class CreateWaterLog:WaterLogDto
	{	
	}

	[Route("/barns/{BarnId}/cycles/{CycleId}/water/{Id}", "PUT", Summary="Update a water reading entry")]
	public class UpdateWaterLog:WaterLogDto
	{

	}

}

