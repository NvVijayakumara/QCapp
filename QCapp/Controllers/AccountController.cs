using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models;
using QCapp.ViewModels;
using System.Configuration;
using System.Data;
using System.Security.Claims;

namespace QCapp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger _logger;
        private readonly QcprojV1Context _qcprojV1Context;
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration, ILogger<AccountController> logger)
        {
            _configuration = configuration;
            _logger = logger;

            _qcprojV1Context = new QcprojV1Context(configuration);
        }

        [AllowAnonymous]
        public IActionResult Login(string? returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(UserLoginModel model, string? returnUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                //get user details
                var user = _qcprojV1Context.Users.Where(x => x.EmailAddress == model.Email && x.Password == model.Password).FirstOrDefault();

                if (user != null)
                {
                    var claims = new[] { 
                        //new Claim("name", user.EmailAddress), 
                        //new Claim(ClaimTypes.Role, user.AccessLevelId.ToString()) 
                        //new Claim("EmailAddress", user.EmailAddress),
                        
                        new Claim("UserId", user.UserId.ToString()),
                        new Claim("AccessLevelId", user.AccessLevelId.ToString()),
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Login failed. Please check Username and/or password");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Server Error");
                _logger.LogError(ex, "Server Error");
            }

            return View(model);
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }


        #region Helpers
        private ActionResult RedirectToLocal(string? returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
