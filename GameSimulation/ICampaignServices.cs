using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface ICampaignServices
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
