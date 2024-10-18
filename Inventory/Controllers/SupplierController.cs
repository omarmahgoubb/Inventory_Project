using Inventory_database.Migrations;
using Inventory_Entities;
using Inventory_Unit;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class SupplierController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

        public SupplierController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var suppliers = await unitOfWork.suppliers.FindAllAsync();
            return View(suppliers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.suppliers.Add(supplier);
                TempData["successData"] = supplier.SupplierName + " has been added successfully";
                return RedirectToAction("Index");
            }
            return View(supplier);
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var supplier = await unitOfWork.suppliers.FindByIdAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var supplier = await unitOfWork.suppliers.FindByIdAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.suppliers.Update(supplier);
                TempData["successData"] = supplier.SupplierName + " has been edited successfully";
                return RedirectToAction("Index");
            }
            return View(supplier);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if(id== 0)
            {
                return NotFound();
            }
            var supplier= await unitOfWork.suppliers.FindByIdAsync(id);

            if(supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteItem(int id)
        {
            var supplier = await unitOfWork.suppliers.FindByIdAsync(id);
            if (supplier != null)
            {
                unitOfWork.suppliers.Delete(supplier);
                TempData["errorData"] = supplier.SupplierName + " has been deleted successfully";
            }
            return RedirectToAction("Index");

        }
    }
}
