using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Business
{
    interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Update(Campaign campaign);
        public void Delete(Campaign campaign);
    }
}
