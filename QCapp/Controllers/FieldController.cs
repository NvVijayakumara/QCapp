using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models.SchemaViewModel;

namespace QCapp.Controllers
{
    public class FieldController : Controller
    {
        public ActionResult Index()
        {
            var listFieldConfigurationViewModel = new List<FieldConfigurationViewModel>();
            listFieldConfigurationViewModel.Add(
                    new FieldConfigurationViewModel()
                    {
                        FieldId = 80001,
                        FieldSubId = 800011,
                        FieldName = "Borrowser Name",
                        FieldType = "nvarchar",
                        DocumentId = 9001,
                        Critical = true,
                        Enable = true,
                        Template = ""
                    }
                );
            listFieldConfigurationViewModel.Add(
                    new FieldConfigurationViewModel()
                    {
                        FieldId = 80002,
                        FieldSubId = 800021,
                        FieldName = "Loan No",
                        FieldType = "nvarchar",
                        DocumentId = 9001,
                        Critical = true,
                        Enable = true,
                        Template = ""
                    }
                );

            return View(listFieldConfigurationViewModel);
        }

        public ActionResult Create()
        {
            var objFieldConfigurationViewModel = new FieldConfigurationViewModel();
            return View(objFieldConfigurationViewModel);
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
