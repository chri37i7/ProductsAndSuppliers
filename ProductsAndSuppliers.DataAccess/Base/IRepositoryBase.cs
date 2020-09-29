using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsAndSuppliers.DataAccess.Base
{
    /// <summary>
    /// Base repository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryBase<T>
    {
        //NorthwindContext Context { get; set; }

        Task AddAsync(T t);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task UpdateAsync();
        Task DeleteAsync(T t);
    }
}