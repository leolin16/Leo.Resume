using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Leo.ResumeProfile.Entities
{
    public class Resume
    {
        // key: Id and foreign key: ResumeUser's ResumeUserId to be considered auto-gen here, thus omit
        // otherwise, refer pluralsight - building a restful api with asp.net core 3 - demo adding a data store
        [Key]       
        public Guid Id { get; set; }
        [ForeignKey("ResumeUserId")]
        public ResumeUser ResumeUser { get; set; }
        public Guid ResumeUserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(1500)]
        public string Description { get; set; }
        public IEnumerable<ExperienceSummary> ExperienceSummaries { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<ProjectDetail> DetailedProjectExperiences { get; set; }
        
    }
}