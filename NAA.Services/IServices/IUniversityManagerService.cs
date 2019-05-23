using NAA.Data.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IServices
{
    public interface IUniversityManagerService
    {
        IList<CourseBEAN> GetUniversityCourses(int universityId);
        CourseBEAN GetCourse(int universityId, int courseId);
    }
}
