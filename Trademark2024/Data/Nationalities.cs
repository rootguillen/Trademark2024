using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("num_code")]
    public class Nationalities
    {
        public int num_code { get; set; }
        public string nationality { get; set; }
        public string alpha_2_code { get; set; }
        public string alpha_3_code { get; set;}
        public string en_short_name { get; set; }

    }
}
