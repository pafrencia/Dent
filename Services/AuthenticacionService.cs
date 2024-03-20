using Dent.Models;

namespace Dent.Services
{
    public class AuthenticacionService
    {
        private readonly HttpClient _httpClient;
        public AuthenticacionService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

     //   public async Task<DateTime> LoginAsync(Login model)
      //  { 
      //  }
    }
}
