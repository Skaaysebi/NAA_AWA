using NAA.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Webapplication.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationService _applicationService;

        public HomeController()
        {
            _applicationService = new ApplicationService();
        }
        public ActionResult Index()
        {
            ViewBag.id = 0;
            try
            {
                ViewBag.id = _applicationService.GetIdOfUserEmail(System.Web.HttpContext.Current.User.Identity.Name);
            } catch
            {

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}