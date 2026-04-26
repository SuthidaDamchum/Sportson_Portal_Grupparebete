using SportsonView.API.Controllers.Clients;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Dto.OrdenCentralDTO;

namespace SportsonView.API.Core.Services
{
    public class OrderService : IOrderService
    {

        private readonly SportsonClient _sportsonClient;

        public OrderService(SportsonClient sportsonClient)
        {
            _sportsonClient = sportsonClient;
        }

        public async Task<string> GetOrdersAsync(string orderNo)
        {
            return await _sportsonClient.GetOrdersAsync(orderNo);

        }
    }
}
