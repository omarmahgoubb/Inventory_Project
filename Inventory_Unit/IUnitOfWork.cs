using Inventory_Entities;
using Inventory_Repositories.Repository.Interfaces;


namespace Inventory_Unit
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> products { get; }

        IRepository<Inventory> inventories { get; }

        IRepository<Supplier> suppliers { get; }
        IRepository<Category> categories { get; }

        int CommitChanges();
    }
}
