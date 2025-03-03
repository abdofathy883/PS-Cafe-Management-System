using PlayStation.Infrastructure.Repos;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    internal class CafeService
    {
        CafetriaRepo cafetriaRepo = new CafetriaRepo();
        public List<Item> GetCafeItemsFromService()
        {
            return cafetriaRepo.GetCafeItemsFromRepo();
        }
        public void AddCafeItemFromService(Item item)
        {
            cafetriaRepo.AddCafeItemFromRepo(item);
        }
        public void UpdateCafeItemFromService(Item item)
        {
            cafetriaRepo.UpdateCafeItemFromRepo(item);
        }
    }
}
