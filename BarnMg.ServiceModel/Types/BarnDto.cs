using System;
using ServiceStack;

namespace BarnMg.ServiceModel
{

	public class BarnDto
	{
		public int Id { get ; set; }
		public string Name { get; set; }
		public int AccountId { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set;}

		public BarnDto ()
		{

		}
	}
}

