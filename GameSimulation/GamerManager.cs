using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GamerManager : IGamerServices
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName+" "+gamer.GamerLastname+" adlı oyuncu kayıt edildi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " " + gamer.GamerLastname + " adlı oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " " + gamer.GamerLastname + " adlı oyuncu bilgilerini güncelledi.");
        }
    }
}
