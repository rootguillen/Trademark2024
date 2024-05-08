using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trademark2024.Data
{
    [PrimaryKey("GoodsServicesInformationID")]
    public class GoodsServicesInformation
    {
        public int GoodsServicesInformationID { get; set; }
        [NotMapped]
        public string[] ServiceClassId { get; set; } = new string[] { };
        [NotMapped]
        public string[] GoodsClassId { get; set; } = new string[] { };


    }
}
