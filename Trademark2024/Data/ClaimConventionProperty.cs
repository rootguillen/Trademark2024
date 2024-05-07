using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("ClaimConventionPropertyID")]
    public class ClaimConventionProperty
    {
        public int ClaimConventionPropertyID { get; set; }
        public int PriorForeignApplicationNo { get; set; }
        public DateTime DateValue { get; set; } = DateTime.Now;
        public string CCPCountry { get; set; }
    }
}
