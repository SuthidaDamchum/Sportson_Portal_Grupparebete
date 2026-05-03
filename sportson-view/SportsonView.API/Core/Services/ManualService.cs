using AutoMapper;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Dto;

namespace SportsonView.API.Core.Services
{
    public class ManualService : IManualService
    {
        private readonly IMapper _mapper;
        private readonly IManualRepository _manualRepository;

        public ManualService(IManualRepository manualRepository, IMapper mapper)
        {
            _mapper = mapper;
            _manualRepository = manualRepository;
        }

        public async Task<IEnumerable<ManualDto>> GetAllAsync(string? type, string? search)
        { 
            var maunals = await _manualRepository.GetAllAsync(type, search);
            return _mapper.Map<IEnumerable<ManualDto>>(maunals);
        }
    }
}
