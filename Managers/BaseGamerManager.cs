using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation.Abstract
{
    public abstract class BaseGamerManager : IUserValidationService
    {
        IUserValidationService _userValidationService;
        public BaseGamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Adlı gamer doğrulanarak eklendi");
            }
            else
            {
                Console.WriteLine("Yeni kullanıcı doğrulanamadı. Kayıt başarısız.");
            }
            
        }

        public bool CheckIfRealPerson(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "Adlı gamer silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "Adlı gamer bilgileri güncellendi");
        }
    }
}
