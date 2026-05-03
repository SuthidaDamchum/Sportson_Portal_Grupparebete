using SportsonView.API.Dto;

namespace SportsonView.API.Core.Services
{
    public interface IMaualService
    {
        Task<IEnumerable<ManualDto>> GetAllAsync(string? type, string? search);
    }
}