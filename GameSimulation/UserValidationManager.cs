using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {

            if (gamer.BirthYear == 1985 && gamer.GamerName =="Engin" && gamer.GamerLastname =="Demiroğ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
