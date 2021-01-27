using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
