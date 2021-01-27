using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class OrderManager : ICampaignServices
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampName +" Kampanya ile satış %50 indirimli. ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampName + " Kampanya ile  %50 indirimli satış sona erdi. ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampName + " Kampanya ile satış %35 indirimli olarak güncellendi. ");
        }
    }
}
