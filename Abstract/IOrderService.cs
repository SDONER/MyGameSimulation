using MyGameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSimulation.Abstract
{
    public interface IOrderService
    {
        void ApplyCampaing(IOrderService order, Gamer game, Campaign camaign);
    }
}
