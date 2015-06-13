using System;

namespace BarnMg.ServiceModel
{
	public class WaterDto
	{
		public int id { get; set; }
		public int barnId { get; set; }
		public DateTime logged { get; set; }
		public int reading { get; set; }

		public WaterDto ()
		{

		}
	}
}

