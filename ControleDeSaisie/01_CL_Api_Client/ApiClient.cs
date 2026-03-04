
using _01_CL_Achat;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace _01_CL_Api_Client
{
    public class ApiClient
    {
        static HttpClient client = new HttpClient();

        static ApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7268/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        public static async Task<List<Achat>?> GetAchatsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("api/Achat");

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            List<Achat>? result = JsonSerializer.Deserialize<List<Achat>>(json);

            return result;
        }

        /// <summary>
        /// Emet une requête POST vers l'api
        /// </summary>
        /// <param name="achat">L'objet à ajouter</param>
        /// <returns>L'URI de l'objet créé</returns>
        public static async Task<Uri> CreateAchatAsync(Achat achat)
        {       
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Achat", achat);

            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        /// <summary>
        /// Emet une requête POST vers l'api
        /// </summary>
        /// <param name="json">La représentation JSON des données à ajouter</param>
        /// <returns>L'URI de l'objet créé</returns>
        public static async Task<Uri> CreateAchatAsyncFromJson(string json)
        {
            StringContent content = new StringContent(json, new MediaTypeHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsync("api/Achat", content);

            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

    }
}