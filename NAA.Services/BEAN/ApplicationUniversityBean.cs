using NAA.Data.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.BEAN
{
    class ApplicationUniversityBean
    {
        public string ApplicantName { get; set; }
        public string CourseName { get; set; }
        public string UniversityName { get; set; }
        public string PersonalStatement { get; set; }
        public string TeacherReference { get; set; }
        public string TeacherContactDetails { get; set; }
        public string UniversityOffer { get; set; }
        public Nullable<bool> Firm { get; set; }

        public ApplicationUniversityBean(ApplicationBEAN application)
        {
            ApplicantName = application.ApplicantName;
            CourseName = application.CourseName;
            UniversityName = application.UniversityName;
            PersonalStatement = application.PersonalStatement;
            TeacherReference = application.TeacherReference;
            TeacherContactDetails = application.TeacherContactDetails;
            UniversityOffer = application.UniversityOffer;
            Firm = application.Firm;
        }
    }
}
