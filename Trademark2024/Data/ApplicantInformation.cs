using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trademark2024.Data
{
    [PrimaryKey("ApplicantID")]
    public class ApplicantInformation
    {
        public int ApplicantID { get; set; }
        [Required]
        public string ApplicantLName { get; set; }
        [Required]
        public string ApplicantFName { get; set; }
        public string ApplicantMName { get; set; }
        [Required]
        public string ApplicantGender { get; set; }
        [Required]
        public string ApplicantPosition { get; set; }
        [Required]
        public string NameCompanyCorpGovASch { get; set; }
        [Required]
        public string ApplicantAddress { get; set; }
        [Required]
        public int? ApplicantCountry { get; set; }
        [Required]
        public int? ApplicantState { get; set; }
        [Required]
        public int? ApplicantCity { get; set; }
        [Required]
        public string ApplicantZipCode { get; set; }
        [Required]
        public string ApplicantMobNum { get; set; }
        [Required]
        public string ApplicantEmailAdd { get; set; }
        [Required]
        public int? ApplicantNationality { get; set; }

        public string? CompanyEntity { get; set; }

    }
}
