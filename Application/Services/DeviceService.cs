//using PlayStation.Domain.Models;
using PlayStation.Infrastructure.Repos;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    public class DeviceService
    {
        private readonly IRepository<Device> _deviceRepository;
        public DeviceService(IRepository<Device> deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public Device GetDeviceByIdFromService(int id)
        {
            return _deviceRepository.GetById(id);
        }
        public List<Device> GetAllDevicesFromService()
        {
            return _deviceRepository.GetAll().ToList();
        }
        public void AddDeviceFromService(Device device)
        {
            _deviceRepository.Add(device);
        }
        public void UpdateDeviceFromService(Device device)
        {
            _deviceRepository.Update(device);
        }
        public void RemoveDeviceFromService(Device device)
        {
            _deviceRepository.DeleteById(device.Id);
        }
    }
}
