using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("Id")]
    public class Cities
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }

    }
}
