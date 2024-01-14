using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.ViewModels;

namespace QCapp.Controllers
{
    public class LoanController : Controller
    {
        #region Loans File Upload
        public ActionResult Index()
        {
            var listLoansFileViewModel = new List<LoansFileViewModel>();
            listLoansFileViewModel.Add(
                    new LoansFileViewModel()
                    {
                        Id = 1,
                        FileName = "file1.xml",
                        LoanUploadStatusName = "Success",
                        TotalLoans = 10,
                        LoansSuccessCount = 10,
                        LoansFailedCount = 0,
                        WorkFlowName = "WorkFlow 1",
                        ProcessName = "Process 1",
                        AuditName = "Audit 1",
                    }
                );
            listLoansFileViewModel.Add(
                    new LoansFileViewModel()
                    {
                        Id = 1,
                        FileName = "file1.xml",
                        LoanUploadStatusName = "Success",
                        TotalLoans = 10,
                        LoansSuccessCount = 10,
                        LoansFailedCount = 0,
                        WorkFlowName = "WorkFlow 1",
                        ProcessName = "Process 1",
                        AuditName = "Audit 1",
                    }
                );

            return View(listLoansFileViewModel);
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
        #endregion


        #region Loan Selection
        public ActionResult Selection()
        {
            var listLoanViewModel = new List<LoanViewModel>();
            listLoanViewModel.Add(
                    new LoanViewModel()
                    {
                        LoanNumber = "12345",
                        BorrowerLastName = "vijay",
                        AuditName = "Audit 1",
                        ProcessName = "Process 1",
                        WorkFlowName = "WorkFlow 1",
                        LoanType = "Loan Type 1"
                    }
                );
            listLoanViewModel.Add(
                    new LoanViewModel()
                    {
                        LoanNumber = "67890",
                        BorrowerLastName = "kumar",
                        AuditName = "Audit 2",
                        ProcessName = "Process 2",
                        WorkFlowName = "WorkFlow 2",
                        LoanType = "Loan Type 2"
                    }
                );

            return View(listLoanViewModel);
        }
        #endregion
    }
}
