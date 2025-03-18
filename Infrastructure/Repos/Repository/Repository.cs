using System.Data;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PlayStation.Models;
namespace PlayStation.Infrastructure.Repos.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IDeletable
    {
        private readonly PSManagementDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(PSManagementDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            var entity = _dbSet.Find(id) ?? throw new SqlNullValueException("This Id Not Found");


            if (entity.IsDeleted)
            {
                throw new DeletedRowInaccessibleException("This element has been deleted");
            }

            return entity;
        }

        public ICollection<T> GetUsersWithData()
        {
            return (ICollection<T>)_dbContext.Users.Include(u => u.Expenses).Select(u => new User
            {
                Id = u.Id,
                Name = u.Name,
                Role = u.Role,
                IsDeleted = u.IsDeleted,
                Expenses = u.Expenses.ToList()
            }).ToList();
        }
        
        public ICollection<T> GetAll()
        {
            return _dbSet.Where(e => e.IsDeleted == false).AsNoTracking().ToList();
        }

        public  ICollection<T> Find(Expression<Func<T, bool>> predicate)
        {
            return  _dbSet.Where(e => e.IsDeleted == false).Where(predicate).ToList();

        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            // Bug here Tracking Problem
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void DeleteById(int id)
        {
            var entity = GetById(id) ?? throw new SqlNullValueException("This entity Not Found");
            entity.IsDeleted = true;
            _dbContext.SaveChanges();
        }

        public T Restore(Expression<Func<T, bool>> predicate)
        {
            var entity = _dbSet.SingleOrDefault(predicate) ?? throw new SqlNullValueException("This entity Not Found");
            if (!entity.IsDeleted)
            {
                throw new Exception("This entity is already active");
            }

            entity.IsDeleted = false;
            _dbContext.SaveChanges();
            return entity;
        }

        public bool IsUsed(Expression<Func<T, bool>> predicate)
        {
            return  _dbSet.Any(predicate);
        }

        public bool IsIdValidType<Type>(int id) where Type : class
        {
            var entity = _dbContext.Set<Type>().Find(id);
            return entity == null ? throw new InvalidOperationException($"This {typeof(Type).Name} is not existed") : true;
        }

        //public ICollection<T> GetUsersWithData()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
