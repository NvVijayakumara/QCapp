using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.ViewModels;

namespace QCapp.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult Index()
        {
            var listClientViewModel = new List<ClientViewModel>();
            listClientViewModel.Add(
                    new ClientViewModel()
                    {
                        ClientId = 1,
                        ClientName = "ABC",
                        ClientCode = "AB-AB",
                        CompanyName = "XYZ inc",
                        ClientEmailAddress = "vijay.nv@mail.com",
                        ActiveStatus = true,
                        WorkFlowName = "AA"
                    }
                );
            listClientViewModel.Add(
                    new ClientViewModel()
                    {
                        ClientId = 2,
                        ClientName = "ABC 2",
                        ClientCode = "AB-AB-2",
                        CompanyName = "XYZ inc.",
                        ClientEmailAddress = "vijay.nv@mail.com",
                        ActiveStatus = true,
                        WorkFlowName = "AA-2"
                    }
                );

            return View(listClientViewModel);
        }

        public ActionResult Create()
        {
            var objClientViewModel = new ClientViewModel();
            return View(objClientViewModel);
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
