using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Leo.ResumeProfile.Entities;

namespace Leo.ResumeProfile.Interfaces
{
    public interface IDataStore
    {
    }
    public interface IResumeRepository
    {
        // Task<IEnumerable<PersonalInfo>> GetPersonalInfosForUserAsync(string userName);
        // Task<IEnumerable<Skill>> GetSkillsForUserAsync(string userName);
        // Task<IEnumerable<Education>> GetEducationsForUserAsync(string userName);
        // Task<IEnumerable<Employment>> GetEmploymentsForUserAsync(string userName);
        // Task<IEnumerable<Certificate>> GetCertificatesForUserAsync(string userName);
        IEnumerable<Resume> GetResumes(Guid resumeUserId);
        Resume GetResume(Guid resumeUserId, Guid resumeId);
        void AddResume(Guid resumeUserId, Resume resume);
        void UpdateResume(Resume resume);
        void DeleteResume(Resume resume);
        IEnumerable<ResumeUser> GetResumeUsers();
        ResumeUser GetResumeUser(Guid resumeUserId);
        IEnumerable<ResumeUser> GetResumeUsers(IEnumerable<Guid> resumeUserIds);
        void AddResumeUser(ResumeUser resumeUser);
        void UpdateResumeUser(ResumeUser resumeUser);
        void DeleteResumeUser(ResumeUser resumeUser);
        bool ResumeUserExists(Guid resumeUserId);
        bool Save();
    }
}