using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine("Yeni kullanıcı doğrulandı. Kayıt başarılı.");
            }
            else
            {
                Console.WriteLine("Yeni kullanıcı doğrulanamadı. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silidi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
