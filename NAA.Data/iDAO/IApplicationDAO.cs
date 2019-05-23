using NAA.Data.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.iDAO
{
    public interface IApplicationDAO
    {
        void CreateApplicant(Applicant applicant);
        void UpdateApplicant(Applicant applicant);
        void GetApplicant(int applicantId);

        List<University> GetUniversities();
        List<University> GetCourses(int universityId);

        void CreateApplication(ApplicationBEAN application);
        void UpdateApplication(ApplicationBEAN application);
        void GetApplicantApplications(int universityId);
        void GetUniversityApplications(int applicantId);
        void GetApplication(int applicationId);
        void DeleteApplication(int applicationId);
        void UpdateOfferOfApplication(int applicationId, ApplicationBEAN application);
    }
}
