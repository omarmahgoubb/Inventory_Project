using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Repositories.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T myItem);
        void Update(T myItem);
        void Delete(T myItem);
        T FindById(int id);
        Task<T> FindByIdAsync(int id);
        IEnumerable<T> FindAll();
        Task<IEnumerable<T>> FindAllAsync();
        IEnumerable<T> FindAll(params string[] agers);
        Task<IEnumerable<T>> FindAllAsync(params string[] agers);
    }
}
