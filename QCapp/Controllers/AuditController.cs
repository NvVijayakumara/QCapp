using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models.SchemaViewModel;

namespace QCapp.Controllers
{
    public class AuditController : Controller
    {
        public ActionResult Index()
        {
            var listAuditViewModel = new List<AuditViewModel>();
            listAuditViewModel.Add(
                    new AuditViewModel()
                    {
                        AuditId = 1,
                        AuditName = "Audit 1",
                        AuditStartDate = DateTime.Now,
                        AuditEndDate = DateTime.Now,
                        AuditTypeName = "Audit Type 1",
                        QuestionBatch = "QB 1",
                        AuditDueDate = DateTime.Now
                    }
                );
            listAuditViewModel.Add(
                    new AuditViewModel()
                    {
                        AuditId = 2,
                        AuditName = "Audit 2",
                        AuditStartDate = DateTime.Now,
                        AuditEndDate = DateTime.Now,
                        AuditTypeName = "Audit Type 2",
                        QuestionBatch = "QB 2",
                        AuditDueDate = DateTime.Now
                    }
                );

            return View(listAuditViewModel);
        }

        public ActionResult Create()
        {
            var objAuditViewModel = new AuditViewModel();
            return View(objAuditViewModel);
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
    }
}
