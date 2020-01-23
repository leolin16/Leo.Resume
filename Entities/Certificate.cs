
using System;

namespace Leo.ResumeProfile.Entities
{
    public class Certificate
    {
        public int Id { get; set; }


        public string Category { get; set; }
        public DateTimeOffset ObtainedDate { get; set; }
        public string CertOrganizationNameChn { get; set; }
        public string CertOrganizationNameJpn { get; set; }
        public string CertOrganizationNameEng { get; set; }
        public string DesignationDegreeChn { get; set; }
        public string DesignationDegreeJpn { get; set; }
        public string DesignationDegreeEng { get; set; }
        public string StudyWorkContentDescChn { get; set; }
        public string StudyWorkContentDescJpn { get; set; }
        public string StudyWorkContentDescEng { get; set; }
        public string URL { get; set; }
        public int MyProperty { get; set; }
        public virtual ResumeUser User { get; set; }

    }
}