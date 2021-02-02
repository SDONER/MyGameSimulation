using System;
using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;


namespace MyGameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer
            { Id = 1, BirthYear = 1992, FirstName = "Serpil", LastName = "DÖNER", IdentitiyNumber = 12345678945 });

            Campaign campaign1 = new Campaign { Id = 1, Name = "Welcome Campaign", DiscountPrice = 5 };

        }
    }
}
