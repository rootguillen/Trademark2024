using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("ClaimConventionPropertyID")]
    public class ClaimConventionProperty
    {
        public int ClaimConventionPropertyID { get; set; }
        public string PriorForeignApplicationNo { get; set; }
        public DateTime? DateValue { get; set; }
        public int? CCPCountry { get; set; }
    }
}
