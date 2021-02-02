using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }

        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
