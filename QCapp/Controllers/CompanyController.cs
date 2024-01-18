using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QCapp.Models;
using QCapp.ViewModels;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace QCapp.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        private readonly QcprojV1Context _qcprojV1Context;
        private readonly IConfiguration _configuration;

        public CompanyController(IMapper mapper, IConfiguration configuration, ILogger<AccountController> logger)
        {
            _mapper = mapper;
            _configuration = configuration;
            _logger = logger;

            _qcprojV1Context = new QcprojV1Context(configuration);
        }

        public ActionResult Create()
        {
            var CountryList = _qcprojV1Context.Countries.ToList();
            ViewBag.Country = new SelectList(CountryList, "Id", "CountryName");

            return View();
        }

        public ActionResult GetStatesById(int Id)
        {
            var listState = _qcprojV1Context.States.Where(x => x.CountryId == Id).ToList();
            var listStateViewModel = _mapper.Map<List<StateViewModel>>(listState);
            
            return Json(listStateViewModel);
        }

        public ActionResult GetCitiesById(int Id)
        {
            var listCity = _qcprojV1Context.Cities.Where(x => x.StateId == Id).ToList();
            var listCityViewModel = _mapper.Map<List<CityViewModel>>(listCity);
            
            return Json(listCityViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Company model)
        {
            try
            {
                model.BillingAdressSameAsCompany = Request.Form["BillingAdressSameAsCompany"] == "on" ? true : false;

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                //get user details
                await _qcprojV1Context.Companies.AddAsync(model);
                await _qcprojV1Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Server Error");
                _logger.LogError(ex, "Server Error");
            }

            return View(model);
        }

        public ActionResult Index()
        {
            var listCompanyViewModel = new List<CompanyViewModel>();
            listCompanyViewModel.Add(
                    new CompanyViewModel()
                    {
                        CompanyId = 1,
                        CompanyName = "ABC inc.",
                        CompanyCode = "AA-AA",
                        CompanyEmailAddress = "abc.inc@mail.com",
                        ContactName = "vijay.nv",
                        ContactPhone = "0123456789"
                    }
                );
            listCompanyViewModel.Add(
                    new CompanyViewModel()
                    {
                        CompanyId = 2,
                        CompanyName = "XYZ inc.",
                        CompanyCode = "XX-AA",
                        CompanyEmailAddress = "xyz.inc@mail.com",
                        ContactName = "vijay.nv",
                        ContactPhone = "0123456789"
                    }
                );

            return View(listCompanyViewModel);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
