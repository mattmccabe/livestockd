using System;
using ServiceStack;
using ServiceStack.ServiceHost;


namespace BarnMg.ServiceModel
{

	[Route("/barns", "GET", Summary="Get all barns")]
	public class BarnList
	{

	}
		
	[Route("/barns/{id}", "GET", Summary="Get a single barn")]
	public class Barn:BarnDto
	{

	}

	[Route("/barns", "POST", Summary="Create a new barn")]
	public class CreateBarn:BarnDto
	{	
	}

	[Route("/barns/{id}", "PUT", Summary="Update an existing barn")]
	public class UpdateBarn:BarnDto
	{

	}

}

