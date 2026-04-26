using SportsonView.API.Data.Entities.OrderCentral;
using SportsonView.API.Dto.OrdenCentralDTO;

namespace SportsonView.API.Core.Interfaces
{
    public interface IOrderService
    {
        Task<string> GetOrdersAsync(string orderNo);
    }
}
