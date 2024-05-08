using Trademark2024.Interface;

namespace Trademark2024.Data
{
    public class ApplicantInformationRepository : IApplicantInformationRepository
    {
        private readonly AppDbContext _dbContext;

        public ApplicantInformationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ApplicantInformation> GetApplicantInformation()
        {
            return _dbContext.ApplicantInformation.ToList();
        }
    }
}
