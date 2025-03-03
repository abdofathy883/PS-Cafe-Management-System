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
    internal class DeviceService
    {
        DeviceRepo deviceRepo = new DeviceRepo();
        public List<Device> GetAllDevicesFromService()
        {
            return deviceRepo.GetAllDevicesFromRepo();
        }
        public void AddDeviceFromService(Device device)
        {
            deviceRepo.AddDeviceFromRepo(device);
        }
        public void UpdateDeviceFromService(Device device)
        {
            deviceRepo.UpdateDeviceFromRepo(device);
        }
        public void RemoveDeviceFromService(Device device)
        {
            deviceRepo.RemoveDeviceFromRepo(device);
        }
    }
}
