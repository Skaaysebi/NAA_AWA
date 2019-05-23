using NAA.Data;
using NAA.Data.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IServices
{
    public interface IApplicationService
    {
        void CreateApplicant(Applicant applicant);
        void UpdateApplicant(Applicant applicant);
        Applicant GetApplicant(int id);

        IList<University> GetUniversities();
        IList<CourseBEAN> GetCourses(int universityId);
        CourseBEAN GetCourse(int universityId, int courseId);

        void CreateApplication(ApplicationBEAN application);
        void UpdateApplication(ApplicationBEAN application);
        IList<ApplicationBEAN> GetApplicantApplications(int applicantID);
        ApplicationBEAN GetApplication(int applicationId);
        void DeleteApplication(int applicationId);
        void AcceptApplication(int applicationId);
        void DeclineApplication(int applicationId);
    }
}
