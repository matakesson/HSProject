using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HSProject.ViewModels
{
    internal class MainPageViewModel
    {
        public Models.Score ScoreToday { get; set; }
        public Models.Score ScoreTomorrow { get; set; }
        

        public MainPageViewModel(string date = "now")
        {
            var task = Task.Run(() => GetScoreAsync(date));
            
            DateTime tomorrowDate = DateTime.Now.AddDays(+0);
            string tomorrowDateString = tomorrowDate.ToString("yyyy-MM-dd");
            var task2 = Task.Run(() => GetScoreAsync(tomorrowDateString));
           
            task.Wait();
            task2.Wait();

            ScoreTomorrow = task2.Result;
            ScoreToday = task.Result;
        }

        public async Task<Models.Score> GetScoreAsync(string date = "now")
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api-web.nhle.com/v1/score/");
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            Models.Score scores = null;

            HttpResponseMessage response = await client.GetAsync(date);
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                scores = JsonSerializer.Deserialize<Models.Score>(responseString);
            }
            return scores;
        }
    }
}
