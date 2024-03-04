
using HSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace HSProject.ViewModels
{

    internal class StatsPageViewModel
    {
        public Models.Stats Stats { get; set; }  

        public StatsPageViewModel(string team)
        {
            // https://api.nhle.com/stats/rest/en/team

            var task = Task.Run(() => GetStatsAsync(team));
            task.Wait();
            Stats = task.Result;
            foreach (var s in Stats.skaters)
            {
                CalculateRatingSkater(s);
            }
            foreach (var g in Stats.goalies)
            {
                CalculateRatingGoalie(g);
            }
        }


        public static async Task<Models.Stats> GetStatsAsync(string team)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://api-web.nhle.com/v1/club-stats/{team}/");
            Models.Stats stats = null;

            HttpResponseMessage response = await client.GetAsync("now");
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                stats = JsonSerializer.Deserialize<Models.Stats>(responseString);
            }
            return stats;
        }

        public static void CalculateRatingSkater(Models.Skater skater)
        {
            float rating = 6; // Starting point

            //// Adjust rating based on various stats
            rating += skater.points * 0.1f;
            rating += skater.goals * 0.2f;
            rating += skater.assists * 0.1f;
            rating += skater.plusMinus * 0.02f;
            rating -= skater.penaltyMinutes * 0.3f;
            rating += skater.powerPlayGoals * 0.2f;
            rating += skater.shorthandedGoals * 0.2f;
            rating += skater.gameWinningGoals * 0.3f;
            rating += skater.overtimeGoals * 0.2f;
            rating += skater.shootingPctg * 0.1f;
            rating += skater.faceoffWinPctg * 0.2f;
            rating += skater.avgTimeOnIcePerGame * 0.003f;


            // Ensure rating stays within 1-10 range
            skater.averageRating = Math.Max(1, Math.Min(10, rating));
        }

        public static void CalculateRatingGoalie(Models.Goaly goalie)
        {
            float rating = 6; // Starting point

            // Adjust rating based on various goalie stats
            rating += goalie.wins * 0.2f;
            rating -= goalie.losses * 0.3f;
            rating += goalie.ties * 0.25f;
            rating -= goalie.overtimeLosses * 0.3f;
            rating += goalie.shutouts * 0.5f;
            rating -= goalie.goalsAgainstAverage * 0.5f;
            rating += goalie.savePercentage * 0.1f;
            rating -= goalie.penaltyMinutes * 0.05f;
            rating += goalie.saves * 0.02f;

            // Ensure rating stays within 1-10 range
            goalie.averageRating = Math.Max(1, Math.Min(10, rating));
        }

        public void SortByLastName()
        {
            if (Stats != null && Stats.skaters != null)
            {
                Stats.skaters = Stats.skaters.OrderByDescending(x => x.lastName._default).ToArray();
            }
        }
    }
}
