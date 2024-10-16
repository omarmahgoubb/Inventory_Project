using Microsoft.AspNetCore.Mvc;
using Inventory_Unit;
using Inventory_Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;


namespace Inventory_Self.Controllers
{
    //[Authorize(Roles = RolesNames.roleAdmin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unitOfWork;


        public ProductController(Inventory_Unit.IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            // Include both category and inventory in one query
            var productList = await unitOfWork.products.FindAllAsync("category", "inventory");
            return View(productList);
        }


        //Get
        public async Task<IActionResult> Create()
        {
            await createSelectInventoryListAsync(); // Add this line
            await createSelectCategoryListAsync();
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                // Capture the uploaded image if present
                if (product.clientFile != null)
                {
                    MemoryStream stream = new MemoryStream();
                    product.clientFile.CopyTo(stream);
                    product.dbimage = stream.ToArray();
                }

                // Assign the current user's email to the CreatedBy field
                product.CreatedBy = User.Identity.Name;

                // Save the product using your unit of work or repository pattern
                unitOfWork.products.Add(product);

                // Notify the user that the product has been added
                TempData["successData"] = product.productName + " has been added successfully";

                return RedirectToAction("Index");
            }

            // If the model state is invalid, return the view with the current product data
            return View(product);
        }


        public async Task<IActionResult> Details(int id)
        {
           
            var product = await unitOfWork.products.FindByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            await createSelectInventoryListAsync();
            await createSelectCategoryListAsync();
            return View(product);
        }
        //get

        public async Task<IActionResult> Edit(int id)
        {
            var product = await unitOfWork.products.FindByIdAsync(id);
            await createSelectInventoryListAsync(); // Add this line
            await createSelectCategoryListAsync();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {

            if (ModelState.IsValid)
            {

                string fileName = string.Empty;

                if (product.clientFile != null)
                {
                    if (product.clientFile != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        product.clientFile.CopyTo(stream);
                        product.dbimage = stream.ToArray();
                    }
                }
                product.CreatedBy = User.Identity.Name;

                unitOfWork.products.Update(product);
                TempData["successData"] = product.productName + " has been edited successfully";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public async Task<IActionResult> Delete(int id)
        {
           
            var product = await unitOfWork.products.FindByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            await createSelectInventoryListAsync();
            await createSelectCategoryListAsync();

            return View(product);
        }

        //Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var product = await unitOfWork.products.FindByIdAsync(id);
            unitOfWork.products.Delete(product);
            TempData["errorData"] = product.productName + " has been deleted successfully";
            return RedirectToAction("Index");
        }

        private async Task createSelectCategoryListAsync(int selectId = 8)
        {
            var categories = await unitOfWork.categories.FindAllAsync();
            SelectList listItems = new SelectList(categories, "Id", "categoryName", selectId);
            ViewBag.categoryList = listItems;
        }
        private async Task createSelectInventoryListAsync(int selectId = 4)
        {
            var inventories = await unitOfWork.inventories.FindAllAsync();
            SelectList listItems = new SelectList(inventories, "Id", "InventoryName", selectId);
            ViewBag.inventoryList = listItems;
        }

    }
}
