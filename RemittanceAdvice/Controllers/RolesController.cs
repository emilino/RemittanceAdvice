using Microsoft.AspNetCore.Mvc;

namespace RemittanceAdvice.Controllers
{
    public class RolesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
