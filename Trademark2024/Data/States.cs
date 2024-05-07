using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("Id")]
    public class States
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
    }
}
