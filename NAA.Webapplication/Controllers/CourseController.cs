using NAA.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Webapplication.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationService _applicationService;

        public CourseController()
        {
            _applicationService = new ApplicationService();
        }

        // GET: University/Details/5
        [Authorize]
        public ActionResult GetCourses(int UniversityId, int ApplicantId)
        {
            ViewBag.ApplicantId = ApplicantId;
            ViewBag.UniversityId = UniversityId;
            return View(_applicationService.GetCourses(UniversityId));
        }


        // GET: University/Details/5
        [Authorize]
        public ActionResult GetCourse(int CourseId, int UniversityId, int ApplicantId)
        {
            ViewBag.ApplicantId = ApplicantId;
            ViewBag.UniversityId = UniversityId;
            return View(_applicationService.GetCourse(UniversityId, CourseId));
        }
    }
}
