using _01_Api_Rest.Models;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _01_CL_Api_Client
{
    public class ApiClient
    {
        static HttpClient client = new HttpClient();

        static void InitUrl()
        {
            client.BaseAddress = new Uri("https://localhost:7268/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           
        }

        public static async Task<Uri> CreateAchatAsync(Achat achat)
        {
            InitUrl();

            HttpResponseMessage response = await client.PostAsJsonAsync("api/Achat", achat);

            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

    }
}