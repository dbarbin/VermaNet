using System;
using System.Web.Mvc;
using System.Diagnostics;
using VermaNet.Data.TigerpawEnhancements;
using VermaNet.Common;


namespace VermaNet.AwesomeBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int daysInMonth = DateHelper.GetWorkDaysInMonth(DateTime.Now.Month, DateTime.Now.Year);
            int quarter = (DateTime.Now.Month + 2) / 3;
            int daysInQuarter = DateHelper.GetWorkDaysInQuarter(quarter, DateTime.Now.Year);
            return RedirectToAction("LeaderBoard");
        }


        public ActionResult LeaderBoard(int? WorkDaysInMonth, int? WorkDaysInQuarter)
        {
            // If Work Days in month/quarter were not supplied, figure them out here...
            WorkDaysInMonth = WorkDaysInMonth.GetValueOrDefault(DateHelper.GetWorkDaysInMonth(DateTime.Now.Month, DateTime.Now.Year));
            int quarter = (DateTime.Now.Month + 2) / 3;
            WorkDaysInQuarter = WorkDaysInQuarter.GetValueOrDefault(DateHelper.GetWorkDaysInQuarter(quarter, DateTime.Now.Year));

            // Run stored procedure to return data and bind that data to our View
            var dbContext = new TigerpawEnhancementsEntities();
            var model = dbContext.GetAwesomeBoardData(DateTime.Today, WorkDaysInMonth, WorkDaysInQuarter);
            return View(model);
        }



    }
}