using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trademark2024.Data
{
    [PrimaryKey("ApplicantID")]
    public class ApplicantInformation
    {
        public int ApplicantID { get; set; }
        public string ApplicantLName { get; set; }
        public string ApplicantFName { get; set; }
        public string ApplicantMName { get; set; }
        public string ApplicantGender { get; set; }
        public string ApplicantPosition { get; set; }
        public string NameCompanyCorpGovASch { get; set; }
        public string ApplicantAddress { get; set; }
        public int? ApplicantCountry { get; set; }
        public int? ApplicantState { get; set; }
        public int? ApplicantCity { get; set; }
        public string ApplicantZipCode { get; set; }
        public string ApplicantMobNum { get; set; }
        public string ApplicantEmailAdd { get; set; }
        public int? ApplicantNationality { get; set; }

        public string? CompanyEntity { get; set; }

    }
}
