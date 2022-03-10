using Microsoft.AspNetCore.Mvc;

namespace EmptyASPNETCore.Controllers
{
    public class Birthday : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/UpAndComing.cshtml");
        }

        public IActionResult Overview(int month = 0)
        {

        }
    }
}
