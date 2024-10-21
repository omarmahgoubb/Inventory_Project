using System;

namespace Inventory_Entities
{
    public class InventoryStatusReportViewModel
    {
        public string ProductName { get; set; }       // Maps to Product.productName
        public string CategoryName { get; set; }      // Maps to Category.categoryName
        public int QuantityInStock { get; set; }      // Maps to Product.productQuantity
        public string SupplierName { get; set; }      // Maps to Supplier.SupplierName
        public string InventoryLocation { get; set; } // Maps to Inventory.InventoryName
        public string Address { get; set; }           // Maps to Inventory.Address (Added for more info)
    }
}
