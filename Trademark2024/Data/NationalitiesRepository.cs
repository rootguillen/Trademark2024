namespace Trademark2024.Data
{
    public class NationalitiesRepository : INationalitiesRepository
    {
        private readonly AppDbContext _dbContext;

        public NationalitiesRepository (AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Nationalities> GetNationalities()
        {
            return _dbContext.Nationalities.ToList();
        }
    }
}
