using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.ViewModels;

namespace QCapp.Controllers
{
    public class WorkFlowController : Controller
    {
        public ActionResult Index()
        {
            var listWorkFlowConfigurationViewModel = new List<WorkFlowConfigurationViewModel>();
            listWorkFlowConfigurationViewModel.Add(
                    new WorkFlowConfigurationViewModel()
                    {
                        WorkflowName = "WorkFlow 1",
                        Indexing = true,
                        IndexingQc = true,
                        DataExtraction = true,
                        DataExtractionQc = true,
                        Checklist = true,
                        ChecklistQc = true,
                        Reverification = true,
                        ReverificationQc = true,
                        Exceptions = true,
                        ExceptionsQc = true,
                    }
                );
            listWorkFlowConfigurationViewModel.Add(
                    new WorkFlowConfigurationViewModel()
                    {
                        WorkflowName = "WorkFlow 2",
                        Indexing = true,
                        IndexingQc = true,
                        DataExtraction = true,
                        DataExtractionQc = true,
                        Checklist = true,
                        ChecklistQc = true,
                        Reverification = true,
                        ReverificationQc = true,
                        Exceptions = true,
                        ExceptionsQc = true,
                    }
                );

            return View(listWorkFlowConfigurationViewModel);
        }

        public ActionResult Create()
        {
            var objWorkFlowConfigurationViewModel = new WorkFlowConfigurationViewModel();
            return View(objWorkFlowConfigurationViewModel);
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
