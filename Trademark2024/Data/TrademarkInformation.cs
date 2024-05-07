using Microsoft.EntityFrameworkCore;
using Trademark2024.Shared.Enum;

namespace Trademark2024.Data
{
    [PrimaryKey("TrademarkinformationID")]
    public class TrademarkInformation
    {
        public int TrademarkinformationID { get; set; }
        public string MarkType { get; set; }
        public string Title { get; set; }
        public string ClaimColors { get; set; }
        public string TranslationTransliteration { get; set; }
        public string Disclaimer { get; set; }
        //public string TrademarkIMG { get; set; }
    }
}
