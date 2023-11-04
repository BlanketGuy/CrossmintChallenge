using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CrossmintChallenge.Models
{
    public class Megaverse
    {
        public string[][] Goal { get; set; }
        private HttpClient _client;

        public Megaverse()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var baseUri = configuration["BaseUri"];
            _client = new()
            {
                BaseAddress = new Uri(baseUri)
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Uri?> CreateAstralObject(IAstralObject astralObject)
        {
            JsonSerializerOptions options = new(JsonSerializerDefaults.Web);
            var jsonData = JsonSerializer.Serialize(astralObject, options);
            var contentData = new StringContent(jsonData, Encoding.UTF8, "application/json");
            
            HttpResponseMessage response = await _client.PostAsync(astralObject.GetEndpoint(), contentData);
            response.EnsureSuccessStatusCode();

            await Task.Delay(1000); // Added delay to avoid HTTP error 429: too many requests

            return response.Headers.Location;
        }

        public async Task<string> GetMetaverseGoal()
        {
            var response = await _client.GetAsync("/api/map/5b2c58ec-3cc8-490b-9e20-74e6f535525c/goal");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
