namespace Trademark2024.Data
{
    public interface IClaimConventionPropertyRepository
    {
        List<ClaimConventionProperty> GetClaimConventionProperties();

        void UpdateSelectedCountry(int claimConventionPropertyId, int selectedCCPCountryId);

    }
}
