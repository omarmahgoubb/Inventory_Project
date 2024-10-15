using Data_base;
using Inventory_Entities;
using Inventory_Repositories.Repository.Classes;
using Inventory_Repositories.Repository.Interfaces;


namespace Inventory_Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext context;

        public UnitOfWork(DataBaseContext context)
        {
            this.context = context;
            products = new MainRepository<Product>(context);
            inventories = new MainRepository<Inventory>(context);
            suppliers = new MainRepository<Supplier>(context);
            categories = new MainRepository<Category>(context);

        }

        public IRepository<Product> products { get; private set; }

        public IRepository<Inventory> inventories { get; private set; }

        public IRepository<Supplier> suppliers { get; private set; }
        public IRepository<Category> categories { get; private set; }

        public int CommitChanges()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
