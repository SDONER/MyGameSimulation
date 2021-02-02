using System;
using MyGameSimulation.Abstract;
using MyGameSimulation.Entities;
using MyGameSimulation.Services;

namespace MyGameSimulation
{
    public class Campaign : IEntitiyService
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int DiscountPrice { get; set; }

    }
}