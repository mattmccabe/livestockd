using System;
using System.Collections.Generic;
using ServiceStack;
using BarnMg.ServiceModel;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.Cors;
using BarnMg.Api;

namespace BarnMg.ServiceInterface
{
	public class BarnService:IService
	{
		private BarnApi _api;

		public BarnService ()
		{
			_api = new BarnApi ();
		}

		protected int AccountId {
			get {
				return 1;
			}
		}
	
		public List<BarnDto> Get(BarnList requestDto)
		{
			return _api.GetBarnsByAccount (AccountId);
		}

		public BarnDto Get(Barn barn)
		{
			return _api.Read (barn.Id);
		}
			
		public void Put(UpdateBarn barn)
		{
			barn.AccountId = AccountId;
			_api.Update (barn);
		}
			
		public void Post(CreateBarn barn)
		{
			barn.AccountId = AccountId;
			_api.Create (barn);
		}
	}
}

