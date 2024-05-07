namespace Trademark2024.Data
{
    public class TrademarkInformationRepository : ITrademarkInformationRepository
    {
        private readonly AppDbContext _dbContext;

        public TrademarkInformationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TrademarkInformation> GetTrademarkInformation()
        {
            return _dbContext.TrademarkInformation.ToList();
        }
    }
}
