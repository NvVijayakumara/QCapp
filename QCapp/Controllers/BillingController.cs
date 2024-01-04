using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models.SchemaViewModel;

namespace QCapp.Controllers
{
    public class BillingController : Controller
    {
        public ActionResult Summary()
        {
            var listBillingSummaryViewModel = new List<BillingSummaryViewModel>();
            listBillingSummaryViewModel.Add(
                    new BillingSummaryViewModel()
                    {
                        ClientName = "ABC inc.",
                        ProcessName = "Post Closing",
                        BillingMonth = "Jan-2023",
                        TotalOrders = "10",
                        BilledAmount = "$10000",
                    }
                );
            listBillingSummaryViewModel.Add(
                    new BillingSummaryViewModel()
                    {
                        ClientName = "XYZ inc.",
                        ProcessName = "Post Closing",
                        BillingMonth = "Jan-2023",
                        TotalOrders = "100",
                        BilledAmount = "$20000",
                    }
                );

            return View("Summary", listBillingSummaryViewModel);
        }
        
        public ActionResult Download()
        {
            return View();
        }
    }
}
