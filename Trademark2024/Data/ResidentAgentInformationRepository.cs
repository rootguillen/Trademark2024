using Trademark2024.Interface;

namespace Trademark2024.Data
{
    public class ResidentAgentInformationRepository : IResidentAgentInformationRepository
    {
        private readonly AppDbContext _dbContext;

        public ResidentAgentInformationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //add here for condition what to do with its data
        public List<ResidentAgentInformation> GetAgentInformation()
        {
            return _dbContext.ResidentAgentInformation.ToList();
        }
    }
}
