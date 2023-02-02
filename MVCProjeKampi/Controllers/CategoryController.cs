using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }
    }
}
