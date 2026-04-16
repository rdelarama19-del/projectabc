using Microsoft.AspNetCore.Mvc;

namespace projectabc.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
