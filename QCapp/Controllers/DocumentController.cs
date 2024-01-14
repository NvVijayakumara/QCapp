using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.ViewModels;

namespace QCapp.Controllers
{
    public class DocumentController : Controller
    {
        public ActionResult Index()
        {
            var listDocumentConfigurationViewModel = new List<DocumentConfigurationViewModel>();
            listDocumentConfigurationViewModel.Add(
                    new DocumentConfigurationViewModel()
                    {
                        DocumentId = 90001,
                        DocumentSubId = 900011,
                        DocumentName = "Closing Disclosure",
                        ClientDocumentName = "Closing Disclosure",
                        Critical = true,
                        Enable = true,
                        Template = ""
                    }
                );
            listDocumentConfigurationViewModel.Add(
                    new DocumentConfigurationViewModel()
                    {
                        DocumentId = 90002,
                        DocumentSubId = 900021,
                        DocumentName = "Note",
                        ClientDocumentName = "Note",
                        Critical = false,
                        Enable = true,
                        Template = ""
                    }
                );

            return View(listDocumentConfigurationViewModel);
        }

        public ActionResult Create()
        {
            var objDocumentConfigurationViewModel = new DocumentConfigurationViewModel();
            return View(objDocumentConfigurationViewModel);
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
