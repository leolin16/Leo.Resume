
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leo.Resume.Entities
{
    public class Experience
    {
        public int Id { get; set; }


        public ExperienceType Category { get; set; }
        public Date Start { get; set; }
        public Date End { get; set; }
        public double DurationInYear {
            get { /* do your sum here */ 
                double range;  
                // range = End.CompareTo(Start);  
                // if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)  
                //     age = age - 1;  
                int ys = End.Year - Start.Year;
                int ms = End.Month - Start.Month;
                int monthSpan = ys*12 + ms;
                double yearSpanDecimal = monthSpan / 12;
                range = Math.Round(yearSpanDecimal, 1, MidpointRounding.AwayFromZero);
                return range;
            }
            private set { /* needed for EF */ }
        }
        
        public string StudyWorkPlaceNameChn { get; set; }
        public string StudyWorkPlaceNameJpn { get; set; }
        public string StudyWorkPlaceNameEng { get; set; }
        public string DesignationDegreeChn { get; set; }
        public string DesignationDegreeJpn { get; set; }
        public string DesignationDegreeEng { get; set; }
        public string StudyWorkRole { get; set; }
        public ResumeUser User { get; set; }

    }
}