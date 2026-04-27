using AutoMapper;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Core.Services
{
    public class SupportService : ISupportService
    {
        private readonly IMapper _mapper;
        private readonly ISupportRepository _supportRepository;

        public SupportService(IMapper mapper, ISupportRepository supportRepository)
        {
            _mapper = mapper;
            _supportRepository = supportRepository;
        }

        public async Task<bool> SendSupportMessage(string username, string? store, string email, string department, string message)
        {
            return await _supportRepository.SendSupportMessageAsync(username, store, email, department, message);
        }
        
    }
}