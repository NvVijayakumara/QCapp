using Microsoft.AspNetCore.Mvc;

namespace QCapp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
