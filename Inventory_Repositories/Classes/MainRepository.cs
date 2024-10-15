using Data_base;
using Inventory_database;
using Inventory_Repositories.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Inventory_Repositories.Repository.Classes
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        protected DataBaseContext context;
        public MainRepository(DataBaseContext context)
        {
            this.context = context;
        }

        public void Add(T myItem)
        {
            context.Set<T>().Add(myItem);
            context.SaveChanges();
        }

        public void Delete(T myItem)
        {
            context.Set<T>().Remove(myItem);
            context.SaveChanges();
        }

        public void Update(T myItem)
        {
            context.Set<T>().Update(myItem);
            context.SaveChanges();
        }

        public IEnumerable<T> FindAll()
        {
            return context.Set<T>().ToList();
        }

        public IEnumerable<T> FindAll(params string[] agers)
        {
            IQueryable<T> query = context.Set<T>();
            if (agers.Length > 0)
            {
                foreach (var ager in agers)
                {
                    query = query.Include(ager);
                }
            }
            return query.ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(params string[] agers)
        {
            IQueryable<T> query = context.Set<T>();
            if (agers.Length > 0)
            {
                foreach (var ager in agers)
                {
                    query = query.Include(ager);
                }
            }
            return await query.ToListAsync();
        }

        public T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);

        }


    }
}
