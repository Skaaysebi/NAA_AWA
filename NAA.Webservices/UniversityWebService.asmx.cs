using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NAA.Services;
using NAA.Data;
using NAA.Services.Services;
using NAA.Data.BEAN;

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

        private ApplicationServiceUniversity _universityService;

        public UniversityWebService()
        {
            _universityService = new ApplicationServiceUniversity();
        }
        [WebMethod]
        public Applicant GetApplicantByApplication(int applicationId)
        {
            return _universityService.GetApplicantByApplication(applicationId);
        }
        [WebMethod]
        public List<ApplicationBEAN> GetApplications(int universityId)
        {
            return _universityService.GetUniversityApplications(universityId).ToList();
        }
        [WebMethod]
        public ApplicationBEAN ChangeOfferOfApplication(ApplicationBEAN application)
        {
            try { 
                return _universityService.UpdateOfferOfApplication(application);
            }
            catch (System.Web.Services.Protocols.SoapException e)
            {
                throw e;  
            }
        }
    }
}
