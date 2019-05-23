using NAA.Data.BEAN;
using NAA.Data.DAO;
using NAA.Data.iDAO;
using NAA.Services.IServices;
using NAA.Services.uk.ac.shu.hallam.webteach_net;
using NAA.Services.uk.ac.shu.hallam.webteach_net1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Services
{
    class UniversityManagerService : IUniversityManagerService
    {
        private IApplicationDAO _dao;
        private SheffieldWebService _sheffieldService;
        private SHUWebService _shuWebService;

        public UniversityManagerService()
        {
            _dao = new ApplicationDAO();
            _sheffieldService = new SheffieldWebService();
            _shuWebService = new SHUWebService();
        }

        public CourseBEAN GetCourse(int universityId, int courseId)
        {
            var universityName = _dao.GetNameFromUniversityId(universityId);
            switch (universityName)
            {
                case "Sheffield":
                    {
                        var results = _sheffieldService.SheffCourses();
                        var course = results.Where(c => c.Id == courseId).First();
                        return new CourseBEAN(course);
                    }
                case "SHU":
                    {
                        var results = _shuWebService.SHUCourses();
                        var course = results.Where(c => c.CourseId == courseId).First();
                        return new CourseBEAN(course);
                    }
                default: throw new Exception("University could not be found!");
            }
        }

        public IList<CourseBEAN> GetUniversityCourses(int universityId)
        {
            var universityName = _dao.GetNameFromUniversityId(universityId);
            List<CourseBEAN> courses = new List<CourseBEAN>();
            switch(universityName)
            {
                case "Sheffield":
                    {
                        var results = _sheffieldService.SheffCourses();
                        foreach(var item in results)
                        {
                            courses.Add(new CourseBEAN(item));
                        }
                    }
            break;
                case "SHU":
                    {
                        var results = _shuWebService.SHUCourses();
                        foreach (var item in results)
                        {
                            courses.Add(new CourseBEAN(item));
                        }
                    }
            break;
            }
            return courses;
        }
    }
}
