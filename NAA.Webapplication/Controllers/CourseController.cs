using NAA.Data.BEAN;
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
        public ActionResult GetCourses(string UniversityName, int UniversityId, int ApplicantId)
        {
            ViewBag.ApplicantId = ApplicantId;
            ViewBag.UniversityId = UniversityId;
            ViewBag.UniversityName = UniversityName;
            return View(_applicationService.GetCourses(UniversityId));
        }


        // GET: University/Details/5
        [Authorize]
        public ActionResult GetCourse(int courseId, string UniversityName, int UniversityId, int ApplicantId)
        {
            IList<ApplicationBEAN> _applicantApplication = _applicationService.GetApplicantApplications(ApplicantId);
            ViewBag.applicationCount = _applicantApplication.Count;
            ViewBag.ApplicantId = ApplicantId;
            ViewBag.UniversityId = UniversityId;
            ViewBag.UniversityName = UniversityName;
            return View(_applicationService.GetCourse(UniversityId, courseId));
        }
    }
}
