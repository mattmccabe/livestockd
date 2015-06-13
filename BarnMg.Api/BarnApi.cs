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
	public class BarnApi : ApiBase
	{
		public BarnApi ()
		{

		}

		protected override string CollectionName { get { return "barns"; } }


		public MongoCollection<BarnDto> GetBarnCollection()
		{
			return GetCollection<BarnDto>();
		}

		public List<BarnDto> GetBarnsByAccount(int accountId)
		{
			var q = Query<BarnDto>.EQ (b => b.AccountId, accountId);
			return GetBarnCollection ().Find(q).ToList();
		}

		public void Create(BarnDto barn)
		{
			GetBarnCollection ().Insert(barn);
		}

		public void Update(BarnDto barn)
		{
			GetBarnCollection ().Save(barn);
		}

		public BarnDto Read(int id)
		{
			return Read (new BarnDto () { Id = id });
		}

		public BarnDto Read(BarnDto dto)
		{
			var q = Query<BarnDto>.EQ (b => b.Id,  dto.Id);
			return GetBarnCollection ().FindOne(q);
		}
			
	}
}

