using Trademark2024.Interface;
namespace Trademark2024.Data
{
    public class GoodsClassRepository : IGoodsClassRepository
    {
        private readonly AppDbContext _dbContext;

        public GoodsClassRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GoodsClass> GetGoodsClass()
        {
            return _dbContext.GoodsClass.ToList();
        }
    }
}
