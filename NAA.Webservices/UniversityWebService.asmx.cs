using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NAA.Services;
using NAA.Data;
using NAA.Services.Services;

namespace NAA.Webservices
{
    /// <summary>
    /// Summary description for UniversityWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UniversityWebService : System.Web.Services.WebService
    {

        private NAA.Services.Services.ApplicationServiceUniversity _universityService;

        public UniversityWebService()
        {
            _universityService = new NAA.Services.Services.ApplicationServiceUniversity();
        }
        [WebMethod]
        public NAA.Data.Applicant GetApplicantByApplication(int applicationId)
        {
            return _universityService.GetApplicantByApplication(applicationId);
        }

        public List<NAA.Data.BEAN.ApplicationBEAN> GetApplications(int universityId)
        {
            return _universityService.GetUniversityApplications(universityId).ToList();
        }

        public NAA.Data.BEAN.ApplicationBEAN ChangeOfferOfApplication(int applicationId, NAA.Data.BEAN.ApplicationBEAN application)
        {
            return _universityService.UpdateOfferOfApplication(applicationId, application);
        }
    }
}
