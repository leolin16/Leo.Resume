using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leo.ResumeProfile.Data;
using Leo.ResumeProfile.Entities;
using Leo.ResumeProfile.Interfaces;

namespace Leo.ResumeProfile.Repositories
{
    public class ResumeRepository : IResumeRepository, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public ResumeRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public void AddResume(Guid resumeUserId, Resume resume)
        {
            if (resumeUserId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(resumeUserId));
            }

            if (resume == null)
            {
                throw new ArgumentNullException(nameof(resume));
            }
            // always set the AuthorId to the passed-in authorId
            resume.ResumeUserId = resumeUserId;
            _context.Resumes.Add(resume); 
        }

        public void AddResumeUser(ResumeUser resumeUser)
        {
            if (resumeUser == null)
            {
                throw new ArgumentNullException(nameof(resumeUser));
            }

            // the repository fills the id (instead of using identity columns)
            resumeUser.Id = Guid.NewGuid();

            foreach (var resume in resumeUser.Resumes)
            {
                resume.Id = Guid.NewGuid();
            }

            _context.ResumeUsers.Add(resumeUser);
        }

        public void DeleteResume(Resume resume)
        {
            _context.Resumes.Remove(resume);
        }

        public void DeleteResumeUser(ResumeUser resumeUser)
        {
            if (resumeUser == null)
            {
                throw new ArgumentNullException(nameof(resumeUser));
            }

            _context.ResumeUsers.Remove(resumeUser);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
               // dispose resources when needed
            }
        }

        public Resume GetResume(Guid resumeUserId, Guid resumeId)
        {
            if (resumeUserId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(resumeUserId));
            }

            if (resumeId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(resumeId));
            }

            return _context.Resumes
              .Where(c => c.ResumeUserId == resumeUserId && c.Id == resumeId).FirstOrDefault();
        }

        public IEnumerable<Resume> GetResumes(Guid resumeUserId)
        {
            if (resumeUserId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(resumeUserId));
            }

            return _context.Resumes
                        .Where(c => c.ResumeUserId == resumeUserId)
                        .OrderBy(c => c.Title).ToList();
        }

        public ResumeUser GetResumeUser(Guid resumeUserId)
        {
            if (resumeUserId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(resumeUserId));
            }

            return _context.ResumeUsers.FirstOrDefault(a => a.Id == resumeUserId);
        }

        public IEnumerable<ResumeUser> GetResumeUsers()
        {
            return _context.ResumeUsers.ToList<ResumeUser>();
        }

        public IEnumerable<ResumeUser> GetResumeUsers(IEnumerable<Guid> resumeUserIds)
        {
            if (resumeUserIds == null)
            {
                throw new ArgumentNullException(nameof(resumeUserIds));
            }

            return _context.ResumeUsers.Where(a => resumeUserIds.Contains(a.Id))
                .OrderBy(a => a.NameChn)
                .OrderBy(a => a.NameEng)
                .ToList();
        }

        public bool ResumeUserExists(Guid resumeUserId)
        {
            if (resumeUserId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(resumeUserId));
            }

            return _context.ResumeUsers.Any(a => a.Id == resumeUserId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateResume(Resume resume)
        {
            throw new NotImplementedException();
        }

        public void UpdateResumeUser(ResumeUser resumeUser)
        {
            throw new NotImplementedException();
        }

        // public Screen GetScreenByScreenName(string screenName)
        // {
        //     return _applicationDbContext.Screens.First(s => s.ScreenName.Equals(screenName));
        // }

        // public IEnumerable<Screen> GetScreens()
        // {
        //     return _applicationDbContext.Screens;
        // }
        // public async Task<Screen> AddScreen(Screen screen)
        // {
        //     var addedScreen = await _applicationDbContext.Screens.AddAsync(screen);
        //     await _applicationDbContext.SaveChangesAsync();
        //     return addedScreen.Entity;
        // }
    }
}