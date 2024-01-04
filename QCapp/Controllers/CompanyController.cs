using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models.SchemaViewModel;

namespace QCapp.Controllers
{
    public class CompanyController : Controller
    {
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

        public ActionResult Create()
        {
            var objCompanyViewModel = new CompanyViewModel();
            return View(objCompanyViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
