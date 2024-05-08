using Trademark2024.Interface;
using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    public class CountriesRepository : ICountriesRepository
    {
        private readonly AppDbContext _dbContext;

        public CountriesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Countries> GetCountries()
        {
            return _dbContext.Countries.ToList();
        }
    }
}
