using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    public class CitiesRepository : ICitiesRepository
    {
        private readonly AppDbContext _dbContext;

        public CitiesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public List<Cities> GetCities()
        {
            return _dbContext.Cities.ToList();
        }

        public async Task<List<Cities>> GetCitiesByStateId(int stateId)
        {
            return await _dbContext.Cities
                                  .Where(c => c.StateId == stateId)
                                  .ToListAsync();
        }
    }
}
