
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leo.Resume.Entities
{
    public class ProjectDetail
    {
        public int Id { get; set; }


        public string Organization { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Location { get; set; }
        public Date Start { get; set; }
        public Date End { get; set; }
        public string Client { get; set; }
        public string OperatingSystem { get; set; }
        public string Tools { get; set; }
        public int TeamSize { get; set; }
        public string RoleNameChn { get; set; }
        public string RoleNameJpn { get; set; }
        public string RoleNameEng { get; set; }
        public Skill Skills { get; set; }
        
        public string ProjectObjectiveChn { get; set; }
        public string ProjectObjectiveJpn { get; set; }
        public string ProjectObjectiveEng { get; set; }
        public string ProjectDescriptionChn { get; set; }
        public string ProjectDescriptionJpn { get; set; }
        public string ProjectDescriptionEng { get; set; }
        public string RoleAndResponsibilityChn { get; set; }
        public string RoleAndResponsibilityJpn { get; set; }
        public string RoleAndResponsibilityEng { get; set; }
        public string Comment { get; set; }
        public ResumeUser User { get; set; }

    }
}