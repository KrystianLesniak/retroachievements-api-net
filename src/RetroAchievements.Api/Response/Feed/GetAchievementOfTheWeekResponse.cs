﻿using RetroAchievements.Api.Internal.Json;
using RetroAchievements.Api.Response.Common;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetAchievementOfTheWeekResponse : BaseRetroAchievementsResponse
    {
        [JsonInclude]
        public Achievement Achievement { get; private set; } = new();

        [JsonInclude]
        public Common.Console Console { get; private set; } = new();

        [JsonInclude]
        [JsonConverter(typeof(DateTimeConverterForCustomApiFormat))]
        public DateTime StartAt { get; private set; }

        [JsonInclude]
        public int UnlocksCount { get; private set; }

        [JsonInclude]
        public int TotalPlayers { get; private set; }

        [JsonInclude]
        public IEnumerable<Unlock> Unlocks { get; private set; } = new List<Unlock>();
    }
}
