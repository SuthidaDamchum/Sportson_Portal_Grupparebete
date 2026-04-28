using SportsonView.API.Dto;

namespace SportsonView.API.Core.Interfaces
{
    public interface IManualService
    {
        Task<IEnumerable<ManualDto>> GetAllAsync(string? type, string? search);
    }
}
