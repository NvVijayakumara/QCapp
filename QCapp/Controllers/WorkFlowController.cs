using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models.SchemaViewModel;

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
                        IndexingQC = true,
                        DataExtraction = true,
                        DataExtractionQC = true,
                        Checklist = true,
                        ChecklistQC = true,
                        Reverification = true,
                        ReverificationQC = true,
                        Exceptions = true,
                        ExceptionsQC = true,
                    }
                );
            listWorkFlowConfigurationViewModel.Add(
                    new WorkFlowConfigurationViewModel()
                    {
                        WorkflowName = "WorkFlow 2",
                        Indexing = true,
                        IndexingQC = true,
                        DataExtraction = true,
                        DataExtractionQC = true,
                        Checklist = true,
                        ChecklistQC = true,
                        Reverification = true,
                        ReverificationQC = true,
                        Exceptions = true,
                        ExceptionsQC = true,
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
