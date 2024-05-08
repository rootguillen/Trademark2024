using Trademark2024.Data;

namespace Trademark2024.Interface
{
    public interface IClaimConventionPropertyRepository
    {
        List<ClaimConventionProperty> GetClaimConventionProperties();

        void UpdateSelectedCountry(int claimConventionPropertyId, int selectedCCPCountryId);

    }
}
