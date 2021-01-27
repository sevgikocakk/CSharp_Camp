using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GameManager : IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName +" adlı oyununuz kütüphanenize eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyununuz silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyununuz için bir güncellemeniz var.");
        }
    }
}
