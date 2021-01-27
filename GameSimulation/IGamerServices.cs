using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface IGamerServices
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
