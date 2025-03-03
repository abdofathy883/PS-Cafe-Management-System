//using PlayStation.Domain.Models;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Infrastructure.Repos
{
    internal class DeviceRepo
    {
        PSManagementDbContext dbContext = new PSManagementDbContext();
        public List<Device> GetAllDevicesFromRepo()
        {
            return dbContext.Devices.ToList();
        }
        public void AddDeviceFromRepo(Device device)
        {
            dbContext.Devices.Add(device);
            dbContext.SaveChanges();
        }
        public void UpdateDeviceFromRepo(Device device)
        {
            dbContext.Devices.Update(device);
            dbContext.SaveChanges();
        }
        public void RemoveDeviceFromRepo(Device device)
        {
            dbContext.Devices.Remove(device);
            dbContext.SaveChanges();
        }
    }
}
