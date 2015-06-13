using System;
using ServiceStack;
using ServiceStack.ServiceHost;


namespace BarnMg.ServiceModel
{

	[Route("/barns/{BarnId}/cycles", "GET", Summary="Get all cycles for a barn")]
	public class BarnCycleList:BarnCycleDto
	{
	
	}
		
	[Route("/barns/{BarnId}/cycles/{Id}", "GET", Summary="Get a single cycle for the specified barn")]
	public class BarnCycle:BarnCycleDto
	{

	}

	[Route("/barns/{BarnId}/cycles", "POST", Summary="Create a new cycle for the specified barn")]
	public class CreateCycle:BarnCycleDto
	{	
	}

	[Route("/barns/{BarnId}/cycles/{Id}", "PUT", Summary="Update a cycle that belongs to the specified barn")]
	public class UpdateCycle:BarnCycleDto
	{

	}

}

