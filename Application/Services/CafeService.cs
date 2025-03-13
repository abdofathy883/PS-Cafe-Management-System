using PlayStation.Infrastructure.Repos;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    public class CafeService
    {
        private readonly IRepository<Item> _itemRepository;
        public CafeService(IRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public Item GetCafeItemByIdFromService(int id)
        {
            return _itemRepository.GetById(id);
        }
        public List<Item> GetCafeItemsFromService()
        {
            return _itemRepository.GetAll().ToList();
        }
        public void AddCafeItemFromService(Item item)
        {
            _itemRepository.Add(item);
        }
        public void UpdateCafeItemFromService(Item item)
        {
             _itemRepository.Update(item);
        }
        public Item GetItemByID(int id)
        {
            return _itemRepository.GetById(id);
        }
    }
}
