using Microsoft.AspNetCore.Mvc;
using WebMVCApp.Data;

namespace WebMVCApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db; //Connects to the database in this controller

        public CategoryController(ApplicationDbContext db) // Inside of this constructor we can register whatever services that are called in the Program.cs container
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList(); // This retrieves and assigns the records to a list object
            return View();
        }
    }
}
