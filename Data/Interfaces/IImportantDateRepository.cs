using SportsonView.API.Data.Entities;
using SportsonView.API.Dto;

namespace SportsonView.API.Data.Interfaces
{
    public interface IImportantDateRepository
    {
        Task<List<ImportantDate>> GetAllImportantDatesAsync();
    }
}
