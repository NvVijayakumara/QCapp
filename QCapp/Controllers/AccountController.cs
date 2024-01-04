using Microsoft.AspNetCore.Mvc;

namespace QCapp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
