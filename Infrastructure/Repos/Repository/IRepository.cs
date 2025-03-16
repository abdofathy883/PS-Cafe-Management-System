using System.Linq.Expressions;

public interface IRepository<T> where T : class
{
    T GetById(int id);
    ICollection<T> GetAll();
    ICollection<T> GetUsersWithData();
    ICollection<T> Find(Expression<Func<T, bool>> predicate);
    T Add(T entity);
    T Update(T entity);
    void DeleteById(int id);
    T Restore(Expression<Func<T, bool>> predicate);
    bool IsUsed(Expression<Func<T, bool>> predicate);
    bool IsIdValidType<Type>(int id) where Type : class;

}
