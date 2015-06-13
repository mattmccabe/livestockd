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
	public class CycleApi : ApiBase
	{
		public CycleApi ()
		{

		}

		protected override string CollectionName { get { return "barnCycles"; } }


		public List<BarnCycleDto> GetCyclesByBarn(int barnId)
		{
			var q = Query<BarnCycleDto>.EQ (b => b.BarnId, barnId);
			return GetCollection<BarnCycleDto>().Find(q).ToList();
		}

		public void Create(BarnCycleDto cycle)
		{
			GetCollection<BarnCycleDto> ().Insert(cycle);
		}

		public void Update(BarnCycleDto cycle)
		{
			GetCollection<BarnCycleDto> ().Save(cycle);
		}

		public BarnCycleDto Read(int id)
		{
			return Read (new BarnCycleDto () { Id = id });
		}

		public BarnCycleDto Read(BarnCycleDto dto)
		{
			var q = Query<BarnCycleDto>.EQ (b => b.Id,  dto.Id);
			return GetCollection<BarnCycleDto> ().FindOne(q);
		}


	}
}

