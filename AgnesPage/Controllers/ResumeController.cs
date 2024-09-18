using Microsoft.AspNetCore.Mvc;

namespace AgnesPage.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Resume()
        {
            return View();
        }
    }
}
