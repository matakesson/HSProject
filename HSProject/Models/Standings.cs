using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HSProject.Models
{


    public class Standings
    {
        public bool wildCardIndicator { get; set; }
        public Standing[] standings { get; set; }
    }

    public class Standing
    {
        public string conferenceAbbrev { get; set; }
        public int conferenceHomeSequence { get; set; }
        public int conferenceL10Sequence { get; set; }
        public string conferenceName { get; set; }
        public int conferenceRoadSequence { get; set; }
        public int conferenceSequence { get; set; }
        public string date { get; set; }
        public string divisionAbbrev { get; set; }
        public int divisionHomeSequence { get; set; }
        public int divisionL10Sequence { get; set; }
        public string divisionName { get; set; }
        public int divisionRoadSequence { get; set; }
        public int divisionSequence { get; set; }
        public int gameTypeId { get; set; }
        public int gamesPlayed { get; set; }
        public int goalDifferential { get; set; }
        public float goalDifferentialPctg { get; set; }
        public int goalAgainst { get; set; }
        public int goalFor { get; set; }
        public float goalsForPctg { get; set; }
        public int homeGamesPlayed { get; set; }
        public int homeGoalDifferential { get; set; }
        public int homeGoalsAgainst { get; set; }
        public int homeGoalsFor { get; set; }
        public int homeLosses { get; set; }
        public int homeOtLosses { get; set; }
        public int homePoints { get; set; }
        public int homeRegulationPlusOtWins { get; set; }
        public int homeRegulationWins { get; set; }
        public int homeTies { get; set; }
        public int homeWins { get; set; }
        public int l10GamesPlayed { get; set; }
        public int l10GoalDifferential { get; set; }
        public int l10GoalsAgainst { get; set; }
        public int l10GoalsFor { get; set; }
        public int l10Losses { get; set; }
        public int l10OtLosses { get; set; }
        public int l10Points { get; set; }
        public int l10RegulationPlusOtWins { get; set; }
        public int l10RegulationWins { get; set; }
        public int l10Ties { get; set; }
        public int l10Wins { get; set; }
        public int leagueHomeSequence { get; set; }
        public int leagueL10Sequence { get; set; }
        public int leagueRoadSequence { get; set; }
        public int leagueSequence { get; set; }
        public int losses { get; set; }
        public int otLosses { get; set; }
        public Placename placeName { get; set; }
        public float pointPctg { get; set; }
        public int points { get; set; }
        public float regulationPlusOtWinPctg { get; set; }
        public int regulationPlusOtWins { get; set; }
        public float regulationWinPctg { get; set; }
        public int regulationWins { get; set; }
        public int roadGamesPlayed { get; set; }
        public int roadGoalDifferential { get; set; }
        public int roadGoalsAgainst { get; set; }
        public int roadGoalsFor { get; set; }
        public int roadLosses { get; set; }
        public int roadOtLosses { get; set; }
        public int roadPoints { get; set; }
        public int roadRegulationPlusOtWins { get; set; }
        public int roadRegulationWins { get; set; }
        public int roadTies { get; set; }
        public int roadWins { get; set; }
        public int seasonId { get; set; }
        public int shootoutLosses { get; set; }
        public int shootoutWins { get; set; }
        public string streakCode { get; set; }
        public int streakCount { get; set; }
        public Teamname teamName { get; set; }
        public Teamcommonname teamCommonName { get; set; }
        public Teamabbrev teamAbbrev { get; set; }
        public string teamLogo { get; set; }
        public int ties { get; set; }
        public int waiversSequence { get; set; }
        public int wildcardSequence { get; set; }
        public float winPctg { get; set; }
        public int wins { get; set; }
    }

    public class Placename
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
        public string fr { get; set; }
    }

    public class Teamname
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
        public string fr { get; set; }
    }

    public class Teamcommonname
    {
        [JsonPropertyName("default")]   
        public string _default { get; set; }
        public string fr { get; set; }
    }

    public class Teamabbrev
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
    }

}

