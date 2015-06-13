using System;
using System.Linq;
using BarnMg.ServiceModel;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;


namespace BarnMg.Api
{
	public class BarnLogApi : ApiBase
	{
		public BarnLogApi ()
		{

		}

		protected override string CollectionName { get { return "barnLogs"; } }


		public List<WaterLogDto> GetWaterLogs(int barnId, int cycleId)
		{
			var q = Query<WaterLogDto>.EQ (b => b.BarnId, barnId);


			var results = from w in GetCollection<WaterLogDto> ().AsQueryable<WaterLogDto> ()
			              where w.BarnId == barnId && w.CycleId == cycleId
			              select w;

			return results.ToList ();
		}

		public void Create(WaterLogDto water)
		{
			GetCollection<WaterLogDto> ().Insert(water);
		}

		public void Update(WaterLogDto water)
		{
			GetCollection<WaterLogDto> ().Save(water);
		}

		public WaterLogDto Read(int id)
		{
			return Read (new WaterLogDto () { Id = id });
		}

		public WaterLogDto Read(WaterLogDto dto)
		{
			var q = Query<WaterLogDto>.EQ (w => w.Id,  dto.Id);
			return GetCollection<WaterLogDto> ().FindOne(q);
		}
			
	}
}

