using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HSProject.Models
{

    public class Stats
    {
        public string season { get; set; }
        public int gameType { get; set; }
        public Skater[] skaters { get; set; }
        public Goaly[] goalies { get; set; }
    }

    public class Skater
    {
        public int playerId { get; set; }
        public string headshot { get; set; }
        public Firstname firstName { get; set; }
        public Lastname lastName { get; set; }
        public string positionCode { get; set; }
        public int gamesPlayed { get; set; }
        public int goals { get; set; }
        public int assists { get; set; }
        public int points { get; set; }
        public int plusMinus { get; set; }
        public int penaltyMinutes { get; set; }
        public int powerPlayGoals { get; set; }
        public int shorthandedGoals { get; set; }
        public int gameWinningGoals { get; set; }
        public int overtimeGoals { get; set; }
        public int shots { get; set; }
        public float shootingPctg { get; set; }
        public float avgTimeOnIcePerGame { get; set; }
        public float avgShiftsPerGame { get; set; }
        public float faceoffWinPctg { get; set; }
        public float? averageRating { get; set; }
    }

    public class Firstname
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
        public string cs { get; set; }
        public string de { get; set; }
        public string es { get; set; }
        public string fi { get; set; }
        public string sk { get; set; }
        public string sv { get; set; }
    }

    public class Lastname
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
        public string cs { get; set; }
        public string fi { get; set; }
        public string sk { get; set; }
    }

    public class Goaly
    {
        public int playerId { get; set; }
        public string headshot { get; set; }
        public Firstname1 firstName { get; set; }
        public Lastname1 lastName { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int ties { get; set; }
        public int overtimeLosses { get; set; }
        public float goalsAgainstAverage { get; set; }
        public float savePercentage { get; set; }
        public int shotsAgainst { get; set; }
        public int saves { get; set; }
        public int goalsAgainst { get; set; }
        public int shutouts { get; set; }
        public int goals { get; set; }
        public int assists { get; set; }
        public int points { get; set; }
        public int penaltyMinutes { get; set; }
        public int timeOnIce { get; set; }
        public float? averageRating { get; set; }
    }

    public class Firstname1
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
        public string cs { get; set; }
        public string fi { get; set; }
        public string sk { get; set; }
    }

    public class Lastname1
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
    }

}
