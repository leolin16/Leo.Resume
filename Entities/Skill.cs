
using System;
using System.Collections.Generic;

namespace Leo.Resume.Entities
{
    public class Skill
    {
        public int Id { get; set; }


        public string Category { get; set; }
        public string Item { get; set; }
        public float DurationHandWrite { get; set; }
        public SkillLevel Level { get; set; }
        public IEnumerable<Certificate> Certificates { get; set; }
        public int PersonalFocusPriority { get; set; }
        public string ExperienceDesc { get; set; }
        public string TargetDesc { get; set; }
        public MoodStatus Status { get; set; }
        public IEnumerable<URL> URLs { get; set; }
        public ResumeUser User { get; set; }

    }
}