namespace Trademark2024.Data
{
    public interface ICitiesRepository
    {
        List<Cities> GetCities();
        List<Cities> GetCitiesByStateId(int stateId);
    }
}
