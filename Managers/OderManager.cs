using MyGameSimulation.Entities;
using MyGameSimulation.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation
{
    class OderManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni sipariş eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Sipariş silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Sipariş güncellendi");
        }
    }
}
