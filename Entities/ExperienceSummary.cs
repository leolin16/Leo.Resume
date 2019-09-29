using System.ComponentModel.DataAnnotations.Schema;

namespace Leo.Resume.Entities
{
    public class ExperienceSummary
    {
        public int Id { get; set; }


        public string Topic { get; set; }
        public string ContentChn { get; set; }
        public string ContentJpn { get; set; }
        public string ContentEng { get; set; }
        public ResumeUser User { get; set; }

    }
}