using Microsoft.AspNetCore.Mvc;

namespace MVC_CRUD_PROJECT.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
