using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation
{
    class UserValidationManager : IUserValidationService
    {

        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.BirthYear == 1992 && gamer.FirstName == "Serpil" &&
                gamer.LastName == "DÖNER" && gamer.IdentitiyNumber == 12345678945)
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