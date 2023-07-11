﻿
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    public record GetAchievementCountRequest : IRetroAchievementsRequest<GetAchievementCountResponse>
    {
        public string RequestEndpoint => "API_GetAchievementCount";

        public GetAchievementCountRequest(int gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        [ApiInputKey("i")]
        public int GameId { get; init; }
    }
}
