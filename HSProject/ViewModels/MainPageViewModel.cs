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
        public Models.Score ScoreOnDisplay { get; set; }
        public Models.Score ScoreYesterday { get; set; }
        

        public MainPageViewModel(string date)
        {
            DateTime tomorrowDate = DateTime.Now.AddDays(+1);
            DateTime yesterdayDate = DateTime.Now.AddDays(-1);
            DateTime todayDate = DateTime.Now.AddDays(+0);
            
            string todayDateString = todayDate.ToString("yyyy-MM-dd");
            string tomorrowDateString = tomorrowDate.ToString("yyyy-MM-dd");
            string yesterdayDateString = yesterdayDate.ToString("yyyy-MM-dd");
            
            var task = Task.Run(() => GetScoreAsync(todayDateString));
            var task3 = Task.Run(() => GetScoreAsync(yesterdayDateString));
            var task2 = Task.Run(() => GetScoreAsync(tomorrowDateString));

            Task.WaitAll(task, task2, task3);

            ScoreTomorrow = task2.Result;
            ScoreToday = task.Result;
            ScoreYesterday = task3.Result;

            if (date == "today")
            {
                ScoreOnDisplay = ScoreToday;
            }
            else if (date == "yesterday")
            {
                ScoreOnDisplay = ScoreYesterday;
            }
            else if (date == "tomorrow") 
            {
                ScoreOnDisplay = ScoreTomorrow;
            }
        }

        public async Task<Models.Score> GetScoreAsync(string date)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api-web.nhle.com/v1/score/");
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
