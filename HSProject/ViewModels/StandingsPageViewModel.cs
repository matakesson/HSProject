using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HSProject.ViewModels
{
    internal class StandingsPageViewModel
    {
        public Models.Standings Standings { get; set; }

        public StandingsPageViewModel()
        {
            var task = Task.Run(() => GetStandingsAsync());
            task.Wait();
            Standings = task.Result;
        }

        public async Task<Models.Standings> GetStandingsAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://api-web.nhle.com/v1/standings/");
            Models.Standings standings = null;

            HttpResponseMessage response = await client.GetAsync("now");
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                standings = JsonSerializer.Deserialize<Models.Standings>(responseString);
            }
            return standings;
        }

    }
}
