using Trademark2024.Data;

namespace Trademark2024.Interface
{
    public interface ICitiesRepository
    {
        List<Cities> GetCities();
        List<Cities> GetCitiesByStateId(int stateId);
    }
}
