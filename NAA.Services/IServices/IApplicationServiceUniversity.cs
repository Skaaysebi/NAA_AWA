using NAA.Data;
using NAA.Data.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IServices
{
    public interface IApplicationServiceUniversity
    {
        Applicant GetApplicantByApplication(int applicationId);
        IList<ApplicationBEAN> GetUniversityApplications(int applicantId);
        void UpdateOfferOfApplication(int applicationId, ApplicationBEAN application);
    }
}
