namespace Trademark2024.Data
{
    public class ServicesClassRepository : IServicesClassRepository
    {
        private readonly AppDbContext _dbContext;

        public ServicesClassRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ServicesClass> GetServicesClass()
        {
            return _dbContext.ServicesClass.ToList();
        }
    }
}
