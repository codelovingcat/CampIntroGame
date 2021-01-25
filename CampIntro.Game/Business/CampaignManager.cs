using Game.DataAccess;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    class CampaignManager : ICampaignService
    {
        private ICampaignDal _campaignDal;

        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }
        public void Add(Campaign campaign)
        {
            // _campaignDal.Add(campaign);
            Console.WriteLine("Kampanya ekleme işlemi.");
        }

        public void Delete(Campaign campaign)
        {
            //_campaignDal.Delete(campaign);
            Console.WriteLine("Kampanya silme işlemi.");
        }

        public void Update(Campaign campaign)
        {
            // _campaignDal.Update(campaign);
            Console.WriteLine("Kampanya güncelleme işlemi.");
        }
    }
}
