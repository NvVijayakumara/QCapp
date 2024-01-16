using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using QCapp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace QCapp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly QcprojV1Context _qcprojV1Context;
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration, ILogger<AccountController> logger)
        {
            _configuration = configuration;
            _logger = logger;

            _qcprojV1Context = new QcprojV1Context(configuration);
        }

        public IActionResult Index()
        {
            // Get the lookup object from User.Claims
            var claimsLookup = ((ClaimsIdentity)User.Identity).Claims.ToLookup(c => c.Type);

            // Access the claims by their type
            var claimUserId = claimsLookup["UserId"].FirstOrDefault();
            var claimAccessLevelId = claimsLookup["AccessLevelId"].FirstOrDefault();


            //get user details
            var user = _qcprojV1Context.Users.Where(x => x.UserId == int.Parse(claimUserId.Value)).FirstOrDefault();

            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
