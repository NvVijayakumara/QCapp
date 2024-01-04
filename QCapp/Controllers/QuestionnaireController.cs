using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models.SchemaViewModel;

namespace QCapp.Controllers
{
    public class QuestionnaireController : Controller
    {
        public ActionResult Index()
        {
            var listQuestionnaireViewModel = new List<QuestionnaireViewModel>();
            listQuestionnaireViewModel.Add(
                    new QuestionnaireViewModel()
                    {
                        Id = 1,
                        QuestionnaireName = "sample",
                        FileName = "file.xls",
                        UploadedByName = "vijay",
                        UploadedDate = DateTime.Now,
                    }
                );
            listQuestionnaireViewModel.Add(
                    new QuestionnaireViewModel()
                    {
                        Id = 2,
                        QuestionnaireName = "sample 2",
                        FileName = "file2.xls",
                        UploadedByName = "kumar",
                        UploadedDate = DateTime.Now,
                    }
                );

            return View(listQuestionnaireViewModel);
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(IFormCollection collection)
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
