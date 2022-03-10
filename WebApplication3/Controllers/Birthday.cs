using Microsoft.AspNetCore.Mvc;

namespace EmptyASPNETCore.Controllers
{
    public class Birthday : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/UpAndComing.cshtml");
        }

        //Ändrade logiken, för månad 0 är Januari
        public IActionResult Overview(int month = -1)
        {
            if (month >= 13 || month < -1)
            {
                return NotFound();
            }

            ViewData.Model = month;
            return View("/Views/Overview.cshtml");
        }
    }
}
