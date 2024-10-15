using Inventory_Entities;
using Inventory_Unit;
using Microsoft.AspNetCore.Mvc;


namespace Inventory_Self.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;


        public CategoryController(Inventory_Unit.IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task<IActionResult> Index()
        {
            var categories = await unitOfWork.categories.FindAllAsync(); // Make sure to fetch categories

            return View(categories);
        }

        //Get
        public async Task<IActionResult> Create()
        {
            return View();
        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {

            if (ModelState.IsValid)
            {
                if (category.clientFile != null)
                {
                    MemoryStream stream = new MemoryStream();
                    category.clientFile.CopyTo(stream);
                    category.dbimage = stream.ToArray();
                }
                unitOfWork.categories.Add(category);
                TempData["successData"] = category.categoryName + " has been added successfully";
                return RedirectToAction("Index");
            }
            return View(category);

        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = await unitOfWork.categories.FindByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        //get

        public async Task<IActionResult> Edit(int id)
        {
            var category = await unitOfWork.categories.FindByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {

            if (ModelState.IsValid)
            {
                unitOfWork.categories.Update(category);
                TempData["successData"] = category.categoryName + " has been edited successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = await unitOfWork.categories.FindByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var category = await unitOfWork.categories.FindByIdAsync(id);
            unitOfWork.categories.Delete(category);
            TempData["successData"] = category.categoryName + " has been deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
