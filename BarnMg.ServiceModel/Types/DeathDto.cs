using System;

namespace BarnMg.ServiceModel
{
	public class DeathDto
	{
		public int barnId { get; set; }
		public int qty { get; set; }
		public DateTime occurred { get; set; }
		public string cause { get; set; }
		public int causeId { get; set; }

		public DeathDto ()
		{
		}
	}
}

