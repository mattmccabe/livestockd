using System;

namespace BarnMg.ServiceModel
{
	public class BarnCycleDto
	{
		public BarnCycleDto ()
		{

		}

		public int Id { get; set; }
		public int BarnId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime ProposedCompletionDate { get; set; }
		public DateTime ActualCompletionDate { get; set; }
		public int UnitsRecieved { get; set; }
		public int UnitsCurrent { get; set; }
		public double AvgStartingWeight { get; set; }

	}
}

