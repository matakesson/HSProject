using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HSProject.ViewModels
{
    internal class SchedulePageViewModel
    {
        public Models.Score Score { get; set; }

        //public SchedulePageViewModel()
        //{
        //    var task = Task.Run(() => GetScoreAsync());
        //    task.Wait();
        //    Score = task.Result;
        //}

        //public async Task<Models.Score> GetScoreAsync()
        //{
        //    var client = new HttpClient();
        //    client.BaseAddress = new Uri("https://api-web.nhle.com/v1/score/");
        //    string now = DateTime.Now.ToString("yyyy-MM-dd");
        //    Models.Score scores = null;

        //    HttpResponseMessage response = await client.GetAsync("now");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        string responseString = await response.Content.ReadAsStringAsync();
        //        scores = JsonSerializer.Deserialize<Models.Score>(responseString);
        //    }
        //    return scores;
        //}
    }
}
