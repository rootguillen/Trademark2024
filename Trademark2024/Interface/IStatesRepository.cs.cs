using Trademark2024.Data;

namespace Trademark2024.Interface
{
    public interface IStatesRepository
    {
        List<States> GetStates();

        List<States> GetStatesByCountryId(int countryId);

    }
}
