using Microsoft.EntityFrameworkCore;
namespace Trademark2024.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TrademarkInformation> TrademarkInformation { get; set; }
        public DbSet<GoodsServicesInformation> GoodsServicesInformation { get; set; }
        public DbSet<ApplicantInformation> ApplicantInformation { get; set; }
        public DbSet <ResidentAgentInformation> ResidentAgentInformation { get; set; }
        public DbSet <ClaimConventionProperty> ClaimConventionProperty {  get; set; }
        
        public DbSet <Countries> Countries { get; set; }
        public DbSet <States> States { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Nationalities> Nationalities { get; set; }

        public DbSet<GoodsClass> GoodsClass { get; set; }
        public DbSet<ServicesClass> ServicesClass { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
