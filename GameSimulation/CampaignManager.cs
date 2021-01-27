using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class CampaignManager : ICampaignServices
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampName +" adlı kampanya eklendi başlangıç tarihi : " + campaign.CampDate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampName +" adlı kampanya silindi süresi doldu.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampName+" adlı kampanyanın tarihi uzadı : " + campaign.CampDate);
        }
    }
}
