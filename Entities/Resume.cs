using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Leo.Resume.Entities
{
    public class Resume
    {
        public ResumeUser User { get; set; }
        public IEnumerable<ExperienceSummary> ExperienceSummaries { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<ProjectDetail> DetailedProjectExperiences { get; set; }
        
    }
}