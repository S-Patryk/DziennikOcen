using DziennikOcen.Client.Models;
using System.Text;
using System.Text.Json;

namespace DziennikOcen.Client.Services
{
    public class UserService
    {
        public async Task<List<User>> GetAll()
        {
            var url = "https://localhost:7180/User";
            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync(url);

            var responseData = JsonSerializer.Deserialize<List<User>>(response);
            return responseData;
        }

        public async Task Delete(int userId)
        {
            var url = "https://localhost:7180/User/" + userId;
            var httpClient = new HttpClient();

            var response = await httpClient.DeleteAsync(url);

            response.EnsureSuccessStatusCode();
        }

        public async Task Add(User user)
        {
            var url = "https://localhost:7180/User";
            var httpClient = new HttpClient();

            HttpContent httpContent = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, httpContent);

            response.EnsureSuccessStatusCode();
        }

        public async Task Edit(User user)
        {
            var url = "https://localhost:7180/User";
            var httpClient = new HttpClient();

            HttpContent httpContent = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync(url, httpContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
