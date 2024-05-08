using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    public class StatesRepository : IStatesRepository
    {
        private readonly AppDbContext _dbContext;

        public StatesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<States> GetStates()
        {
            return _dbContext.States.ToList();
        }

        public List<States> GetStatesByCountryId(int countryId)
        {
            return _dbContext.States.Where(s => s.CountryId == countryId).ToList();
        }

    }
}
