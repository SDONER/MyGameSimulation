using MyGameSimulation.Entities;
using MyGameSimulation.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation
{
    class CampaingManager : ICampaignService
    {
        ICampaignService _campaignService;

        public CampaingManager()
        {
        }

        public CampaingManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public CampaingManager(Campaign campaign)
        {
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Sisteme yeni kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
