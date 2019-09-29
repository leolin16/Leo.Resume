using System.Collections.Generic;
using System.Threading.Tasks;
using Leo.Resume.Entities;

namespace Leo.Resume.Interfaces
{
    public interface IResumeRepository
    {
        Task<IEnumerable<PersonalInfo>> GetPersonalInfosForUserAsync(string userName);
        Task<IEnumerable<Skill>> GetSkillsForUserAsync(string userName);
        Task<IEnumerable<Education>> GetEducationsForUserAsync(string userName);
        Task<IEnumerable<Employment>> GetEmploymentsForUserAsync(string userName);
        Task<IEnumerable<Certificate>> GetCertificatesForUserAsync(string userName);
    }
}