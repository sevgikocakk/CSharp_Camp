using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface IGameServices
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        
    }
}
