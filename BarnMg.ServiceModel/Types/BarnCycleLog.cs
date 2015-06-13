using System;

namespace BarnMg.ServiceModel
{
	public abstract class BarnCycleLog
	{
		public int Id { get; set; }
		public int BarnId { get; set; }
		public int CycleId { get; set; }
		public DateTime LogDate { get; set; }
		public int LoggedByUserId { get; set; }

	}
}

