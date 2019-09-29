using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leo.Resume.Data;
using Leo.Resume.Entities;
using Leo.Resume.Interfaces;

namespace Leo.Resume.Repositories
{
    public class DataStore : IDataStore
    {
        private ApplicationDbContext _applicationDbContext;

        public DataStore(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Screen GetScreenByScreenName(string screenName)
        {
            return _applicationDbContext.Screens.First(s => s.ScreenName.Equals(screenName));
        }

        public IEnumerable<Screen> GetScreens()
        {
            return _applicationDbContext.Screens;
        }
        public async Task<Screen> AddScreen(Screen screen)
        {
            var addedScreen = await _applicationDbContext.Screens.AddAsync(screen);
            await _applicationDbContext.SaveChangesAsync();
            return addedScreen.Entity;
        }
    }
}