using SportsonView.API.Dto;

namespace SportsonView.API.Core.Interfaces
{
    public interface IImportantDatesService
    {
        Task<List<ImportantDateDto>> GetAllImportantDatesAsync();
    }
}
