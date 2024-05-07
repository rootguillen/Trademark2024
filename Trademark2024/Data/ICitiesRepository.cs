namespace Trademark2024.Data
{
    public interface ICitiesRepository
    {
        List<Cities> GetCities();
        Task<List<Cities>> GetCitiesByStateId(int StateId);
    }
}
