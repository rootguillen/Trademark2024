using Trademark2024.Interface;
using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    public class ClaimConventionPropertyRepository : IClaimConventionPropertyRepository
    {
        private readonly AppDbContext _dbContext;

        public ClaimConventionPropertyRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ClaimConventionProperty> GetClaimConventionProperties()
        {
            return _dbContext.ClaimConventionProperty.ToList();
        }
    }
}
