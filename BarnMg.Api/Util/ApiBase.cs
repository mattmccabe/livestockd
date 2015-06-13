using System;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BarnMg.Api
{
	public abstract class ApiBase
	{
		public ApiBase ()
		{

		}

		protected MongoServer GetMongoServer(){

			var client = new MongoClient (ConfigurationManager.AppSettings ["mongoConnect"]);
			return client.GetServer ();
		}

		protected MongoDatabase GetDatabase() {
			var server = GetMongoServer ();
			return server.GetDatabase ("livestockd");
		}

		public MongoCollection<T> GetCollection<T>()
		{
			return GetDatabase ().GetCollection<T>(CollectionName);
		}

		protected abstract string CollectionName { get; }
			
	}
}

