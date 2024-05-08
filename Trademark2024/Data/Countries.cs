using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("Id")]
    public class Countries
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string? CountryCode { get; set; }
    }
}
