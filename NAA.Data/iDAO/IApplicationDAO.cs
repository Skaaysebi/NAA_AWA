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
        Applicant GetApplicantByApplication(int applicationId);

        List<University> GetUniversities();

        void CreateApplication(ApplicationBEAN application);
        void UpdateApplication(ApplicationBEAN application);
        IList<ApplicationBEAN> GetApplicantApplications(int applicantId);
        IList<ApplicationBEAN> GetUniversityApplications(int applicantId);
        ApplicationBEAN GetApplication(int applicationId);
        void DeleteApplication(int applicationId);
        void AcceptApplication(int applicationId);
        void DeclineApplication(int applicationId);

        string GetNameFromUniversityId(int universityId);
    }
}
