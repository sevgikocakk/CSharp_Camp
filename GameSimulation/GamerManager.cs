using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GamerManager : IGamerServices
    {
        IUserValidationService userValidationService;
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService) 
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.GamerName + " " + gamer.GamerLastname + gamer.BirthYear+" adlı oyuncu kayıt edildi.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarız.Kayıt yapılamadı.");
            }
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
