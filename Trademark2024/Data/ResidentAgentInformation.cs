using Microsoft.EntityFrameworkCore;

namespace Trademark2024.Data
{
    [PrimaryKey("ResidentAgentId")]
    public class ResidentAgentInformation
    {
        public int ResidentAgentId { get; set; }
        public string? RALName { get; set; }
        public string? RAFName { get; set; }
        public string? RAMName { get; set; }
        public string? RAGender {  get; set; }
        public string? RAAddress { get; set; }
        public string? RAZipCode { get; set; }
        public string? RAMobNum { get; set; }
        public string? RAEmailAdd { get; set; }
    }
}
