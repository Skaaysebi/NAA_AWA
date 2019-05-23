using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NAA.Data.BEAN;
using NAA.Services.IServices;

namespace NAA.Webapplication.Controllers
{
    public class ApplicationController : Controller
    {
        private IApplicationService _applicationService;

        public ApplicationController()
        {
            //_applicationService = new IApplicationService();
        }

        public ActionResult ManageApplications()
        {
            return View();
        }

        public ActionResult AcceptApplication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AcceptApplication(int id)
        {
            return RedirectToAction("ManageApplications", new { id = id, controller = "Applicant" });
        }

        public ActionResult DeleteApplication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteApplication(ApplicationBEAN application)
        {
            ApplicationBEAN _applicationToDelete = _applicationService.GetApplication(application.Id);
            _applicationService.DeleteApplication(_applicationToDelete.Id);
            return RedirectToAction("ManageApplications", new { id = _applicationToDelete.Id, controller = "Application" });
        }
    }
}
