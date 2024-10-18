using Inventory_Entities;
using Inventory_Unit;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Self.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public InventoryController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Inventory
        public async Task<IActionResult> Index()
        {
            var inventories = await unitOfWork.inventories.FindAllAsync(); // Fetch all inventories
            return View(inventories);
        }

        // GET: Inventory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inventory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Inventory_Entities.Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                // Assign the current user's email to the CreatedBy field if needed
                inventory.CreatedBy = User.Identity.Name;

                unitOfWork.inventories.Add(inventory);
                TempData["successData"] = inventory.InventoryName + " has been added successfully";
                return RedirectToAction("Index");
            }
            return View(inventory);
        }

        // GET: Inventory/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var inventory = await unitOfWork.inventories.FindByIdAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        // GET: Inventory/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var inventory = await unitOfWork.inventories.FindByIdAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        // POST: Inventory/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Inventory_Entities.Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.inventories.Update(inventory);
                TempData["successData"] = inventory.InventoryName + " has been edited successfully";
                return RedirectToAction("Index");
            }
            return View(inventory);
        }

        // GET: Inventory/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var inventory = await unitOfWork.inventories.FindByIdAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        // POST: Inventory/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var inventory = await unitOfWork.inventories.FindByIdAsync(id);
            if (inventory != null)
            {
                unitOfWork.inventories.Delete(inventory);
                TempData["errorData"] = inventory.InventoryName + " has been deleted successfully";
            }
            return RedirectToAction("Index");
        }
    }
}
