using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HSProject.Models
{
    public class Score
    {
        public string prevDate { get; set; }
        public string currentDate { get; set; }
        public string nextDate { get; set; }
        public Gameweek[] gameWeek { get; set; }
        public Oddspartner[] oddsPartners { get; set; }
        public Game[] games { get; set; }
    }

    public class Gameweek
    {
        public string date { get; set; }
        public string dayAbbrev { get; set; }
        public int numberOfGames { get; set; }
    }

    public class Oddspartner
    {
        public int partnerId { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string siteUrl { get; set; }
        public string bgColor { get; set; }
        public string textColor { get; set; }
        public string accentColor { get; set; }
    }

    public class Game
    {
        public int id { get; set; }
        public int season { get; set; }
        public int gameType { get; set; }
        public string gameDate { get; set; }
        public Venue venue { get; set; }
        public DateTime startTimeUTC { get; set; }
        public string easternUTCOffset { get; set; }
        public string venueUTCOffset { get; set; }
        public Tvbroadcast[] tvBroadcasts { get; set; }
        public string gameState { get; set; }
        public string gameScheduleState { get; set; }
        public Awayteam awayTeam { get; set; }
        public Hometeam homeTeam { get; set; }
        public string gameCenterLink { get; set; }
        public string threeMinRecap { get; set; }
        public string threeMinRecapFr { get; set; }
        public Clock clock { get; set; }
        public bool neutralSite { get; set; }
        public string venueTimezone { get; set; }
        public int period { get; set; }
        public Perioddescriptor periodDescriptor { get; set; }
        public Gameoutcome gameOutcome { get; set; }
        public Goal[] goals { get; set; }
    }

    public class Venue
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
    }

    public class Awayteam
    {
        public int id { get; set; }
        public Name name { get; set; }
        public string abbrev { get; set; }
        public int score { get; set; }
        public int sog { get; set; }
        public string logo { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
    }

    public class Hometeam
    {
        public int id { get; set; }
        public Name1 name { get; set; }
        public string abbrev { get; set; }
        public int score { get; set; }
        public int sog { get; set; }
        public string logo { get; set; }
    }

    public class Name1
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
    }

    public class Clock
    {
        public string timeRemaining { get; set; }
        public int secondsRemaining { get; set; }
        public bool running { get; set; }
        public bool inIntermission { get; set; }
    }

    public class Perioddescriptor
    {
        public int number { get; set; }
        public string periodType { get; set; }
    }

    public class Gameoutcome
    {
        public string lastPeriodType { get; set; }
        public int otPeriods { get; set; }
    }

    public class Tvbroadcast
    {
        public int id { get; set; }
        public string market { get; set; }
        public string countryCode { get; set; }
        public string network { get; set; }
        public int sequenceNumber { get; set; }
    }

    public class Goal
    {
        public int period { get; set; }
        public Perioddescriptor1 periodDescriptor { get; set; }
        public string timeInPeriod { get; set; }
        public int playerId { get; set; }
        public Name2 name { get; set; }
        public string mugshot { get; set; }
        public string teamAbbrev { get; set; }
        public int goalsToDate { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public string strength { get; set; }
        public long highlightClip { get; set; }
        public long highlightClipFr { get; set; }
    }

    public class Perioddescriptor1
    {
        public int number { get; set; }
        public string periodType { get; set; }
    }

    public class Name2
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
        public string sv { get; set; }
        public string cs { get; set; }
        public string sk { get; set; }
    }

}
