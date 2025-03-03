//using PlayStation.Domain.Models;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Infrastructure.Repos
{
    internal class CafetriaRepo
    {
        PSManagementDbContext dbContext = new PSManagementDbContext();
        public List<Item> GetCafeItemsFromRepo()
        {
            return dbContext.Items.ToList();
        }
        public void AddCafeItemFromRepo(Item item)
        {
            dbContext.Items.Add(item);
            dbContext.SaveChanges();
        }
        public void UpdateCafeItemFromRepo(Item item)
        {
            dbContext.Items.Update(item);
            dbContext.SaveChanges();
        }
    }
}
