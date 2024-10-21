using Data_base;
using Inventory_Entities;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml; // Make sure to install the EPPlus NuGet package
using System;
using System.IO;
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

            ViewData["StartDate"] = startDate; // Store start date for Excel export
            ViewData["EndDate"] = endDate;     // Store end date for Excel export

            return View(reportData);
        }

        public IActionResult ExportToExcel(DateTime? startDate, DateTime? endDate)
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

            // Create an Excel package
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Inventory Status Report");

                // Add headers
                worksheet.Cells[1, 1].Value = "Product Name";
                worksheet.Cells[1, 2].Value = "Category";
                worksheet.Cells[1, 3].Value = "Quantity in Stock";
                worksheet.Cells[1, 4].Value = "Supplier";
                worksheet.Cells[1, 5].Value = "Inventory";

                // Add data
                for (int i = 0; i < reportData.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = reportData[i].ProductName;
                    worksheet.Cells[i + 2, 2].Value = reportData[i].CategoryName;
                    worksheet.Cells[i + 2, 3].Value = reportData[i].QuantityInStock;
                    worksheet.Cells[i + 2, 4].Value = reportData[i].SupplierName;
                    worksheet.Cells[i + 2, 5].Value = reportData[i].InventoryLocation;
                }

                // Set the content type and file name
                var fileContents = package.GetAsByteArray();
                var fileName = $"InventoryStatusReport_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

                return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
    }
}
