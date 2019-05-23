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
        Applicant GetApplicant(int applicantId);

        List<University> GetUniversities();
        List<University> GetCourses(int universityId);

        void CreateApplication(ApplicationBEAN application);
        void UpdateApplication(ApplicationBEAN application);
        IList<ApplicationBEAN> GetApplicantApplications(int universityId);
        IList<ApplicationBEAN> GetUniversityApplications(int applicantId);
        ApplicationBEAN GetApplication(int applicationId);
        void DeleteApplication(int applicationId);
        void UpdateOfferOfApplication(int applicationId, ApplicationBEAN application);
    }
}
