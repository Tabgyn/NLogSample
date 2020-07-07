using NLog;
using System;
using System.Web.Mvc;

namespace NLogSample.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost]
        public ActionResult Exception(string nullable, string name, int value)
        {
            try
            {
                if(string.IsNullOrEmpty(nullable))
                    throw new ArgumentNullException(nameof(nullable));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
            }

            return RedirectToAction("Index");
        }
    }
}
