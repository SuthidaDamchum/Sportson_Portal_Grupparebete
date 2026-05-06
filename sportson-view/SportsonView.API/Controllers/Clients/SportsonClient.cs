namespace SportsonView.API.Controllers.Clients
{
    public class SportsonClient
    {
        private static HttpClient sportsonClient = new()
        {
            BaseAddress = new Uri("https://stage.api.sportson.se"),
        };

        private const string Token = "";

        public async Task<string> GetOrdersAsync(string orderNo)
        {
           sportsonClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

            var response = await sportsonClient.GetAsync($"/Orders/GetCollatedOrder/{orderNo}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
