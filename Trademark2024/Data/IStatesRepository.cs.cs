namespace Trademark2024.Data
{
    public interface IStatesRepository
    {
        List<States> GetStates();

        List<States> GetStatesByCountryId(int countryId);

    }
}
