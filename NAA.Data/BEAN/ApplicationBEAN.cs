using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.BEAN
{
    public class ApplicationBEAN
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; }

        public int ApplicantId { get; set; }
        public int UniversityId { get; set; }
        public string CourseName { get; set; }
        public string UniversityName { get; set; }
        public string PersonalStatement { get; set; }
        public string TeacherReference { get; set; }
        public string TeacherContactDetails { get; set; }
        public string UniversityOffer { get; set; }
        public Nullable<bool> Firm { get; set; }
    }
}
