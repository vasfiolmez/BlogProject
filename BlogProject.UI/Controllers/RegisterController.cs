using Microsoft.AspNetCore.Mvc;

namespace BlogProject.UI.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
