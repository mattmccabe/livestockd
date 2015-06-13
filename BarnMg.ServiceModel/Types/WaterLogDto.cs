using System;

namespace BarnMg.ServiceModel
{
	public class WaterLogDto : BarnCycleLog
	{
		public WaterLogDto ()
		{
		}

		public int WaterReading { get; set; } 
		public string Notes { get; set; }
		public DateTime MeasureDate { get; set; }
	}
}

