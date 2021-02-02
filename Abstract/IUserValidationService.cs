using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation
{
    public interface IUserValidationService
    {
        bool CheckIfRealPerson(Gamer gamer);
       
        //bool Validate(Gamer gamer);
    }
}
