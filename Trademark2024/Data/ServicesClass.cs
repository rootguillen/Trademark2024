using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("ServicesId")]
    public class ServicesClass
    {
        public int ServicesId { get; set; }
        public string? ServicesClassItem {  get; set; }
        public string? ServicesClassDescription { get; set; }
    }
}
