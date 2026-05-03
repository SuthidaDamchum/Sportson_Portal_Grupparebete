using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Interfaces
{
    public interface IManualRepository
    {
        Task<IEnumerable<Manual>> GetAllAsync(string? type, string? search);
    }
}
