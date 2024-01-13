using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get extended data about a game with a user proggress about that game.
    /// </summary>
    public record GetGameDataAndUserProgressRequest : IRetroAchievementsRequest<GetGameDataAndUserProgressResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameInfoAndUserProgress";

        ///<inheritdoc cref="GetGameDataAndUserProgressRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetGameDataAndUserProgressRequest(int gameId, string username)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));

            GameId = gameId;
            Username = username;
        }

        ///<summary>
        /// Unique RetroAchievements identifier of the game.
        ///</summary>
        [ApiInputKey("g")]
        public int GameId { get; init; }

        /// <summary>
        /// Username to seek game progress for.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
