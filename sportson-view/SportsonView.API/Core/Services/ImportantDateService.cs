using AutoMapper;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Dto;

namespace SportsonView.API.Core.Services
{
    public class ImportantDateService : IImportantDatesService
    {
        private readonly IMapper _mapper;
        private readonly IImportantDateRepository _importantDateRepo;

        public ImportantDateService(IMapper mapper, IImportantDateRepository importantDateRepository)
        {
            _mapper = mapper;
            _importantDateRepo = importantDateRepository;
        }

        public async Task<List<ImportantDateDto>> GetAllImportantDatesAsync()
        {
           var importantDates = await _importantDateRepo.GetAllImportantDatesAsync();
               return _mapper.Map<List<ImportantDateDto>>(importantDates);
        }
    }
}
