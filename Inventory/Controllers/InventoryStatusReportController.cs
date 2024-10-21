using Data_base;
using Inventory_Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Inventory.Controllers
{
    public class InventoryStatusReportController : Controller
    {
        private readonly DataBaseContext _context;

        public InventoryStatusReportController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InventoryStatusReport(DateTime? startDate, DateTime? endDate)
        {
            var reportData = (from p in _context.Products
                              join c in _context.Categories on p.categoryId equals c.Id
                              join s in _context.Suppliers on p.supplierId equals s.Id
                              join i in _context.Inventories on p.inventoryId equals i.Id
                              where (!startDate.HasValue || p.CreationDate >= startDate)
                              && (!endDate.HasValue || p.CreationDate <= endDate)
                              select new InventoryStatusReportViewModel
                              {
                                  ProductName = p.productName,
                                  CategoryName = c.categoryName,
                                  QuantityInStock = p.productQuantity,
                                  SupplierName = s.SupplierName,
                                  InventoryLocation = i.InventoryName
                              }).ToList();

            return View(reportData);
        }




    }
}
