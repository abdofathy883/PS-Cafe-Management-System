using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    public class OrderDetailsService
    {
        private readonly IRepository<OrderDetail> orderDetailsRepository;
        public OrderDetailsService(IRepository<OrderDetail> _orderDetailsRepository)
        {
            orderDetailsRepository = _orderDetailsRepository;
        }

        public List<OrderDetail> GetOrderDetailsFromService()
        {
            return orderDetailsRepository.GetAll().ToList();
        }
        public OrderDetail GetOrderDetailByIdFromService(int id)
        {
            return orderDetailsRepository.GetById(id);
        }
        public void DeleteById(int Id)
        {
            orderDetailsRepository.DeleteById(Id);
        }
        
    }
}
