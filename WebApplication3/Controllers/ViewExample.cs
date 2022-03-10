using Microsoft.AspNetCore.Mvc;

namespace EmptyASPNETCore.Controllers
{
    public class ViewExample : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
