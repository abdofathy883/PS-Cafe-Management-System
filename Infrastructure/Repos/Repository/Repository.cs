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

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id) ?? throw new SqlNullValueException("This Id Not Found");


            if (entity.IsDeleted)
            {
                throw new DeletedRowInaccessibleException("This element has been deleted");
            }

            return entity;
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _dbSet.Where(e => e.IsDeleted==false).AsNoTracking().ToListAsync();
        }

        public async Task<ICollection<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(e => e.IsDeleted == false).Where(predicate).ToListAsync();

        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id) ?? throw new SqlNullValueException("This entity Not Found");
            entity.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> RestoreAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await _dbSet.SingleOrDefaultAsync(predicate) ?? throw new SqlNullValueException("This entity Not Found");
            if (!entity.IsDeleted)
            {
                throw new Exception("This entity is already active");
            }

            entity.IsDeleted = false;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> IsUsedAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<bool> IsIdValidTypeAsync<Type>(int id) where Type : class
        {
            var entity = await _dbContext.Set<Type>().FindAsync(id);
            return entity == null ? throw new InvalidOperationException($"This {typeof(Type).Name} is not existed") : true;
        }
    }
}
