using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using QCapp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using QCapp.ViewModels;
using static Azure.Core.HttpHeader;

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

            //get menus, sub menus, and menu links filtered by access level id
            var query = from m in _qcprojV1Context.Menus
                        join ml in _qcprojV1Context.MenuLinks on m.MenuId equals ml.MenuId
                        join uamm in _qcprojV1Context.UserAccessMenuMapings on ml.MenuLinkId equals uamm.MenuLinkId
                        where uamm.AccessLevelId == user.AccessLevelId && ml.Active == true
                        select new UserLink()
                        {
                            MenuId = m.MenuId,
                            MenuName = m.MenuName,
                            ParentMenuId = m.ParentMeenuId,
                            MenuOrder =m.Order,
                            MenuCssClass = m.CssClass,

                            LinkId = ml.MenuLinkId,
                            LinkName = ml.Name,
                            LinkHref = ml.Href,
                            LinkOrder = ml.Order,
                        };

            // 
            var objUserSiteDetailsViewModel = new UserSiteDetailsViewModel()
            {
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,

                UserLinks = query.ToList()
            };

            return View(objUserSiteDetailsViewModel);
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
