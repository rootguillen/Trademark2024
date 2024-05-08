using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("GoodsId")]
    public class GoodsClass
    {
        public int GoodsId { get; set; }
        public string? GoodsClassItem { get; set; }
    }
}
